using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace TicTacToe
{
    class Multiplayer : Controller
    {
        
        protected MultiplayerForm multiplayerForm;
        protected string host;
        protected int port;

        protected TcpListener server;
        protected TcpClient client;

        protected bool isServer = false;
        protected bool isClient = false;
        protected int serverPlayer;
        protected int clientPlayer;

        protected BinaryWriter writer;
        protected BinaryReader reader;

        protected string responseField;

        protected bool error = false;

        public Multiplayer(MenuStartBox application, bool isChosen = false) : base(application)
        {
            if (!isChosen)
            {
                multiplayerForm = new MultiplayerForm();
                multiplayerForm.ShowDialog();

                int action = multiplayerForm.start();
                host = multiplayerForm.host;
                port = multiplayerForm.port;

                board = new Board(this);

                switch (action)
                {
                    case 1:
                        isChosen = true;
                        startServer();
                        break;
                    case 2:
                        isChosen = true;
                        //new MulitplayerClient(application, true);
                        joinToServer();
                        break;
                    default:
                        this.close();
                        break;
                }
            }
        }

        public void startServer()
        {
            server = new TcpListener(IPAddress.Parse(host), port);
            server.Start();
            isServer = true;

            board.server = true;
            board.init();
            start();

            serverPlayer = board.player;

            board.addNewMessage("Server started");
            board.setAllFieldOnDisable();

            addNewPlayer();
        }

        public async void addNewPlayer()
        {
            Task addNewPlayerTask = new Task(waitOnPlayerTwo);
            addNewPlayerTask.Start();

            await addNewPlayerTask;

            playerTwoIsAvailable();
        }

        public void waitOnPlayerTwo()
        {
            do
            {
                client = server.AcceptTcpClient();
                reader = new BinaryReader(client.GetStream());
            } while (reader.ReadString() != "ticTacToe");
        }

        public void playerTwoIsAvailable()
        {
            board.addNewMessage("New player available");
            board.newGame(new object(), new EventArgs());

            writer = new BinaryWriter(client.GetStream());
            reader = new BinaryReader(client.GetStream());

            writer.Write(board.player);
        }

        public async override void clickInField(string clickedInFieldName)
        {
            try
            {
                if ((isServer && board.player == serverPlayer) || (isClient && board.player == clientPlayer))
                {
                    board.clickInFieldByName(clickedInFieldName);
                    writer.Write(clickedInFieldName);

                    if (!board.endOfTheRoundFlag)
                    {
                        Task waitForClickTask = new Task(waitOnServerClick);
                        waitForClickTask.Start();

                        await waitForClickTask;

                        board.addNewMessage(responseField);
                        board.clickInFieldByName(responseField);
                    }
                }
                else
                {
                    MessageBox.Show("Teraz kolej na drugiego gracza");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
                this.close();
            }
        }

        public void joinToServer()
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse(host), port);

            if (client.Connected)
            {
                isClient = true;
                writer = new BinaryWriter(client.GetStream());
                reader = new BinaryReader(client.GetStream());

                writer.Write("ticTacToe");

                int startPlayer = serverPlayer = reader.ReadInt32();
                clientPlayer = board.getOppositePlayer();

                board.initClient(startPlayer, clientPlayer);
                board.version = "client";
                start();
                waitForServerResponse();
            }
        }

        public async void waitForServerResponse()
        {
            Task waitForClickTask = new Task(waitOnServerClick);
            waitForClickTask.Start();

            await waitForClickTask;

            if (!error)
                board.clickInFieldByName(responseField);
            else
                this.close();
        }

        public void waitOnServerClick()
        {
            try
            {
                responseField = "";
                responseField = reader.ReadString();
            }
            catch (Exception)
            {
                error = true;
            }
        }

        public void start()
        {
            board.Show();
        }

        public async override void endOfTheRound()
        {
            if (isClient)
            {
                Task waitForClickTask = new Task(waitOnServerClick);
                waitForClickTask.Start();

                await waitForClickTask;

                if (string.Equals(responseField, "continueGame"))
                {
                    board.continueGame(new object(), new EventArgs());
                    synchronizationClient(); 

                    if (isClient && board.player != clientPlayer)
                        waitForServerResponse();
                }
            }
        }

        public override void continueGame()
        {
            writer.Write("continueGame");
            synchronizationServer();

            if(isServer && board.player != serverPlayer)
                waitForServerResponse();
        }

        public void synchronizationServer()
        {
            writer.Write(board.player);
        }

        public void synchronizationClient()
        {
            int player = reader.ReadInt32();
            board.player = player;
        }
    }
}
