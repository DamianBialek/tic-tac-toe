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
    class MulitplayerClient : Multiplayer
    {
        public MulitplayerClient(MenuStartBox application, bool isChosen) : base(application, isChosen)
        {
            joinToServer();
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

        public void synchronizationClient()
        {
            int player = reader.ReadInt32();
            board.player = player;
        }
    }
}
