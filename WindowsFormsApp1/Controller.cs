using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
   abstract public class Controller
    {
        MenuStartBox application;
        protected Board board;

        public int[,] winTypes = {
            { 0,1,2 },
            { 3,4,5 },
            { 6,7,8 },
            { 0,4,8 },
            { 2,4,6 },
            { 0,3,6 },
            { 1,4,7 },
            { 2,5,8 }
        };

        public Controller(MenuStartBox app)
        {
            application = app;
        }

        public Random randomObject = new Random();

        virtual public void nextMove(int player = 0) { }

        virtual public void formLoaded(){}

        virtual public void clickInField(string clickedInFieldName)
        {
            board.clickInFieldByName(clickedInFieldName);
        }

        virtual public void continueGame(){ }

        virtual public void endOfTheRound() { }

        public void close()
        {
            application.Close();
        }
    }
}
