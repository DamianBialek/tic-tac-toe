using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Computer : Controller
    {
        int computerName;
        string[] playerPosName = { "X", "O" };
        bool foundAllIndex = false;

        public List<RichTextBox> listOfFields = new List<RichTextBox>();

        public Computer(MenuStartBox application) : base(application)
        {
            board = new Board(this);
            board.init();

            computerName = board.getOppositePlayer();
            listOfFields = board.listOfFields;
            start();
        }

        public void start()
        {
            board.ShowDialog();
            board.newGame(new object(), new EventArgs());
        }

        public override void nextMove(int player)
        {
            if(player == computerName)
                computerClick();
        }

        public void computerClick()
        {
            int randFieldIndex = 900;

            if (board.checkAllFieldsIsEnabled())
            {
                int[] indexesToAttack = foundAllAvailableIndex();

                if (foundAllIndex)
                {
                    board.addNewMessage("Indeks one: " + indexesToAttack[0] + " : indekstwo" + indexesToAttack[1] + " : " + indexesToAttack[2]);

                    int indexToClick = (string.Equals(listOfFields[indexesToAttack[1]].Text, string.Empty) ? indexesToAttack[1] : indexesToAttack[2]);

                    if(indexToClick != null)
                    {
                        board.clickInField(listOfFields[indexToClick]);
                    }

                }
                else
                {
                    while (true)
                    {
                        randFieldIndex = randomObject.Next(listOfFields.Count);
                        if (listOfFields[randFieldIndex].Enabled == true)
                            break;
                    }

                    board.clickInField(listOfFields[randFieldIndex]);
                }
            }

        }

        public int[] foundAllAvailableIndex()
        {
            int[] foundAllAvailableIndex = {0,0,0};
            int indexOne = 0, indexTwo = 0, indexThree = 0;
            foundAllIndex = false;

            for (int i = 0; i < winTypes.GetLength(0); i++)
            {
                if (foundAllIndex)
                    break;

                for (int j = 0; j < winTypes.GetLength(1); j++)
                {
                    if (listOfFields[winTypes[i, j]].Text == playerPosName[computerName])
                    {
                        indexOne = winTypes[i, j]; indexTwo = j; indexThree = j;

                        if (j == 0)
                        {
                            indexTwo = winTypes[i, j + 1];
                            indexThree = winTypes[i, j + 2];
                        }
                        else if (j == 1)
                        {
                            indexTwo = winTypes[i, j - 1];
                            indexThree = winTypes[i, j + 1];
                        }
                        else
                        {
                            indexTwo = winTypes[i, j - 2];
                            indexThree = winTypes[i, j - 1];
                        }
                    }

                    if ((string.Equals(listOfFields[indexTwo].Text, string.Empty) && string.Equals(listOfFields[indexThree].Text, string.Empty)) || (string.Equals(listOfFields[indexTwo].Text, playerPosName[computerName]) && string.Equals(listOfFields[indexThree].Text, string.Empty)) || (string.Equals(listOfFields[indexTwo].Text, string.Empty) && string.Equals(listOfFields[indexThree].Text, playerPosName[computerName])))
                    {
                        foundAllIndex = true;
                        break;
                    }
                }
            }

            foundAllAvailableIndex[0] = indexOne;
            foundAllAvailableIndex[1] = indexTwo;
            foundAllAvailableIndex[2] = indexThree;

            return foundAllAvailableIndex;
        }
    }
}
