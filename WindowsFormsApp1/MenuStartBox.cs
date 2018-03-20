using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MenuStartBox : Form
    {
        object controller;

        bool dragging = false;
        Point startPoint = new Point(0, 0);


        public MenuStartBox()
        {
            InitializeComponent();

            closeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void playervsplayer_Click(object sender, EventArgs e)
        {
            Board.type = 0;
            this.Hide();
            controller = new Standard(this);
            
        }

        private void playervscomputer_Click(object sender, EventArgs e)
        {
            Board.type = 1;
            this.Hide();
            controller = new Computer(this);
        }

        private void MenuStartBox_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            Board.type = 2;
            this.Hide();
            controller = new Multiplayer(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButtonMouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButtonMouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}
