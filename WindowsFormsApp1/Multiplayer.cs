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
        Board board;
        MultiplayerForm multiplayerForm;
        string host;
        int port;

        TcpListener server;
        TcpClient client;

        bool isServer = false;
        bool isClient = false;
        int serverPlayer;
        int clientPlayer;

        BinaryWriter writer;
        BinaryReader reader;

        string responseField;

        public Multiplayer(MenuStartBox application) : base(application)
        {
            multiplayerForm = new MultiplayerForm();
            multiplayerForm.ShowDialog();

            int action = multiplayerForm.start();
            host = multiplayerForm.host;
            port = multiplayerForm.port;

            board = new Board(this);
            board.multiplayer = true;

            switch (action)
            {
                case 1:
                    startServer();
                    break;
                case 2:
                    joinToServer();
                    break;
                default:
                    break;
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
            MessageBox.Show("Drugi gracz dołączył. Rozpoczynam nową grę");
            board.newGame(new object(), new EventArgs());

            writer = new BinaryWriter(client.GetStream());
            reader = new BinaryReader(client.GetStream());

            writer.Write(board.player);
        }

        public async override void clickInField(string clickedInFieldName)
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

        public void joinToServer()
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse(host), port);

            if(client.Connected)
            {
                isClient = true;
                writer = new BinaryWriter(client.GetStream());
                reader = new BinaryReader(client.GetStream());

                writer.Write("ticTacToe");

                int startPlayer = serverPlayer = reader.ReadInt32();
                clientPlayer = board.getOppositePlayer();

                board.initClient(startPlayer);
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

            board.clickInFieldByName(responseField);
        }

        public void waitOnServerClick()
        {
            responseField = "";
            responseField = reader.ReadString();
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

                if(string.Equals(responseField, "continueGame"))
                {
                    board.continueGame(new object(), new EventArgs());
                    synchronizationClient();

                    if(isClient && board.player != clientPlayer)
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
