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
    public partial class Board : Form
    {
        public bool server = false;
        public string version = "normal";

        public static int type;
        public Controller controller;

        public int player = 0;

        public List<RichTextBox> listOfFields = new List<RichTextBox>();

        string[] playerPosName = { "X", "O" };

        int[,] winTypes = { 
            { 0,1,2 }, 
            { 3,4,5 },
            { 6,7,8 },
            { 0,4,8 },
            { 2,4,6 },
            { 0,3,6 },
            { 1,4,7 },
            { 2,5,8 }
        };

        int scoreX, scoreY;
        Random randomObject = new Random();
        public bool endOfTheRoundFlag = false;

        bool dragging = false;
        Point startPoint = new Point(0, 0);

        public Board(Controller cont)
        {
            InitializeComponent();
            controller = cont;

            closeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        public void init()
        {
            player = randPlayer();
            playerName.Text = playerPosName[player];

            addAllFieldsToList();
            fieldTextCenter();
            textTypeOfGame();

            if (type == 1 || type == 2)
            {
                label3.Visible = true;
                playAsLabel.Text = playerPosName[player];
            }
        }


        private void addAllFieldsToList()
        {
            listOfFields.Add(field1);
            listOfFields.Add(field2);
            listOfFields.Add(field3);
            listOfFields.Add(field4);
            listOfFields.Add(field5);
            listOfFields.Add(field6);
            listOfFields.Add(field7);
            listOfFields.Add(field8);
            listOfFields.Add(field9);
        }

        private void textTypeOfGame()
        {
            switch (type)
            {
                case 0:
                    typeOfGameLabel.Text = "Gracz vs Gracz";
                    break;
                case 1:
                    typeOfGameLabel.Text = "Gracz vs Komputer";
                    break;
                case 2:
                    typeOfGameLabel.Text = "Mulitplayer";
                    break;
                default:
                    break;
            }
        }

        private int randPlayer()
        {
            return randomObject.Next(0, 1);
        }

        public int getOppositePlayer()
        {
            return (player == 0 ? 1 : 0);
        }

        private void nextMove()
        {
            controller.nextMove(player);
        }

        private void insertPlayer(object sender, EventArgs e)
        {
            RichTextBox clickedTextBox = sender as RichTextBox;

            controller.clickInField(clickedTextBox.Name);
        }

        public void clickInField(RichTextBox clickedField)
        {
            if (clickedField.Enabled == true)
            {
                clickedField.Text = playerPosName[player];
                clickedField.Enabled = false;
                checkWin();
                changePlayer();
                nextMove();
            }
        }

        private void checkWin()
        {
            for (int i = 0; i < winTypes.GetLength(0); i++)
            {
                if(listOfFields[winTypes[i, 0]].Text != String.Empty && listOfFields[winTypes[i,0]].Text == listOfFields[winTypes[i, 1]].Text && listOfFields[winTypes[i, 0]].Text == listOfFields[winTypes[i, 2]].Text)
                {
                    listOfFields[winTypes[i, 0]].ForeColor = System.Drawing.Color.Red;
                    listOfFields[winTypes[i, 1]].ForeColor = System.Drawing.Color.Red;
                    listOfFields[winTypes[i, 2]].ForeColor = System.Drawing.Color.Red;

                    setAllFieldOnDisable();
                    addScoreToPlayer(listOfFields[winTypes[i, 0]].Text);
                    refreshScore();

                    endOfTheRound();

                    return;
                }

            }

            if (!checkAllFieldsIsEnabled())
            {
                endOfTheRound();
            }

        }

        private void endOfTheRound()
        {
            endOfTheRoundFlag = true;

            if (version == "normal")
            {
                continueGameButton.Visible = true;
                continueGameButton.Enabled = true;
                continueGameButton.Focus();

                newGameButton.Enabled = true;
            }

             controller.endOfTheRound();
        }

        public bool checkAllFieldsIsEnabled()
        {
            foreach (RichTextBox field in listOfFields)
            {
                if (field.Enabled == true)
                    return true;
            }

            return false;
        }

        public void setAllFieldOnDisable()
        {
            newGameButton.Visible = false;
            newGameButton.Enabled = false;
            foreach (RichTextBox field in listOfFields)
            {
                field.Enabled = false;
            }
        }

        private void addScoreToPlayer(string player)
        {
            if (player.ToUpper() == "X")
                scoreX++;
            else if(player.ToUpper() == "O")
                scoreY++;
        }

        private void changePlayer()
        {
            player = getOppositePlayer();
            playerName.Text = playerPosName[player];
        }

        public void continueGame(object sender, EventArgs e)
        {
            resetFields();
            continueGameButton.Enabled = false;
            nextMove();

            if (server)
                controller.continueGame();
        }

        private void refreshScore()
        {
            labelScoreX.Text = scoreX.ToString();
            labelScoreY.Text = scoreY.ToString();

            if (scoreX > scoreY)
            {
                labelScoreX.ForeColor = System.Drawing.Color.Green;
                labelScoreY.ForeColor = System.Drawing.Color.Red;
            }
            else if(scoreY > scoreX)
            {
                labelScoreX.ForeColor = System.Drawing.Color.Red;
                labelScoreY.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelScoreX.ForeColor = System.Drawing.Color.Green;
                labelScoreY.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void fieldTextCenter()
        {
            foreach (RichTextBox field in listOfFields)
            {
                field.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void resetFields()
        {
            foreach (RichTextBox field in listOfFields)
            {
                field.Text = String.Empty;
                field.Enabled = true;
                field.ForeColor = System.Drawing.Color.Gray;
            }
            endOfTheRoundFlag = false;
            continueGameButton.Visible = false;
        }

        public void newGame(object sender, EventArgs e)
        {
            resetFields();
            resetScore();
            refreshScore();
            nextMove();
        }

        private void Board_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.close();
        }

        public void addNewMessage(string message)
        {
            //messagesTextBox.Text += message + "\r\n";
        }

        private void resetScore()
        {
            scoreX = 0;
            scoreY = 0;
        }

        public void initClient(int playerSet, int clientPlayer)
        {
            synchronization(playerSet);

            addAllFieldsToList();
            fieldTextCenter();
            textTypeOfGame();

            newGameButton.Visible = false;
            newGameButton.Enabled = false;

            label3.Visible = true;
            playAsLabel.Text = playerPosName[clientPlayer];

        }

        public void synchronization(int playerSet)
        {
            player = playerSet;
            playerName.Text = playerPosName[player];
        }

        #region New UI control

        private void closeButton_Click(object sender, EventArgs e)
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

        public void clickInFieldByName(string fieldName)
        {
            Control[] field = this.Controls.Find(fieldName, true);
            RichTextBox fieldd = field[0] as RichTextBox;

            clickInField(fieldd);
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

        #endregion
    }

}
