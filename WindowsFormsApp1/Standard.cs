using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Standard : Controller
    {
        Board board;

        public Standard(MenuStartBox application) : base(application)
        {
            board = new Board(this);
            board.init();
            start();
        }

        public void start()
        {
            board.ShowDialog();
            board.newGame(new object(), new EventArgs());
        }

        public override void nextMove(int player)
        {

        }
    }
}
