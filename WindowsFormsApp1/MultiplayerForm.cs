using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MultiplayerForm : Form
    {
        public string host;
        public int port;
        int action;
        static string IPAddress = GetIPAddress();

        public MultiplayerForm()
        {
            InitializeComponent();

            hostTextBox.Text = IPAddress;
        }

        public int start()
        {
            return action;
        }

        public void fieldsDisable()
        {
            createNewServerButton.Enabled = false;
        }

        private void createNewServerButton_Click(object sender, EventArgs e)
        {
            action = 1;

            host = hostTextBox.Text;
            Int32.TryParse(portTextBox.Text, out port);

            if (Helpers.serverExist(host, port))
                MessageBox.Show("Podany serwer już istnieje !!!");
            else
                this.Close();
        }

        private void joinToServerButton_Click(object sender, EventArgs e)
        {
            action = 2;

            host = hostTextBox.Text;
            Int32.TryParse(portTextBox.Text, out port);

            if (!Helpers.serverExist(host, port))
                MessageBox.Show("Podany serwer nie istnieje !!!");
            else
                this.Close();
        }

        public static string GetIPAddress()
        {
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }
    }
}
