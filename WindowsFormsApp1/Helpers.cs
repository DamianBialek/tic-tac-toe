using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TicTacToe
{
    public static class Helpers
    {
        public static bool serverExist(string host, int port)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IPAddress.Parse(host), port);

                BinaryWriter writer = new BinaryWriter(client.GetStream());
                writer.Write("testConnection");

                client.Close();

                return true;
            }
            catch(SocketException)
            {
                return false;
            }

        }
    }
}
