using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Board sudokuBoard;
        public int numClicked;
        public bool gameStarted = false;
        public bool setUp = false;
        //public Button buttons[] = {button1,button2, button3, button4, button5, button6, button7, button8, button9};
        public static List<int[]> prevMoves = new List<int[]>();
        public static String playerId = "";
        public static int filled;
        public int level = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void board_Paint(object sender, PaintEventArgs e)
        {
            sudokuBoard = new Board(board);
            start();
        }

        private void start()
        {
            if (setUp)
            {
                return;
            }
            sudokuBoard.displayBoard();
            setUp = true;
            newGameButton.ForeColor = Color.Black;
            exitButton.ForeColor = Color.Black;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sudokuBoard.clearDisplay();
            prevMoves.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numClicked = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numClicked = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numClicked = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numClicked = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numClicked = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numClicked = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numClicked = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numClicked = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numClicked = 9;
        }

        private void board_Click(object sender, EventArgs e)
        {


        }

        private void board_MouseClick(object sender, MouseEventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("Please start a new game first.");
                return;
            }
            if (numClicked > 0 && numClicked < 10)
            {
                if (sudokuBoard.fillSquare(e.Location, numClicked))
                {
                    numClicked = 0;
                }
                if (filled >= 81)
                {
                    MessageBox.Show("Game over! Well done!");
                }
            }
            else if (numClicked == -1)
            {
                sudokuBoard.eraseSquare(e.Location);
                numClicked = 0;
            }
            else
            {
                numClicked = 0;
                return;
            }
        }

        private void buttonBlank_Click(object sender, EventArgs e)
        {
            numClicked = -1;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("Enter your name in the text box below, then select a level.");
            }
            gameStarted = true;
            resetButton_Click(sender, e);
            setButton.ForeColor = Color.Black;
            lastGame.ForeColor = Color.Black;
            sudokuBoard.textFileToGrid(1);
            sudokuBoard.textFileToGrid(2);
            sudokuBoard.textFileToGrid(3);
            if (level == 1)
            {
                Beginner_Click(sender, e);
            }
            else if (level == 2)
            {
                moderate_Click(sender, e);
            }
            else if (level == 3)
            {
                Advanced_Click(sender, e);
            }
            else
            {

            }
            prevGames.DataSource = sudokuBoard.getPrevGames(level);
            prevGames.Update();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("Please start a new game first.");
                return;
            }
            try
            {
                int[] prevMove = prevMoves.ElementAt(prevMoves.Count() - 1);
                sudokuBoard.fillHelper(prevMove[0], prevMove[1], prevMove[2], true, true);
                prevMoves.RemoveAt(prevMoves.Count() - 1);

            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("No more to undo.");
            }

        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            sudokuBoard.showSolution();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void stuckButton_Click(object sender, EventArgs e)
        {
            if (sudokuBoard.isStuck())
            {
                MessageBox.Show("You are stuck. New game?");
            }
            else
            {
                MessageBox.Show("No. You're not stuck. Keep trying!");
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (playerId == "")
            {
                playerId = textBox1.Text;
                playerID.Text = playerId;
                resetNameButton.ForeColor = Color.Black;
                playerID.ForeColor = Color.Black;
                Beginner.ForeColor = Color.Black;
                moderate.ForeColor = Color.Black;
                Advanced.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Player ID already entered.");
                textBox1.Text = playerId;
            }
        }

        private void resetNameButton_Click(object sender, EventArgs e)
        {
            playerId = "";
            playerID.Text = "Player ID";
            playerID.ForeColor = Color.Gray;
            textBox1.Text = "";
        }

        private void Beginner_Click(object sender, EventArgs e)
        {
            levelSet(sender, e, 1);
        }

        private void moderate_Click(object sender, EventArgs e)
        {
            levelSet(sender, e, 2);
        }

        private void Advanced_Click(object sender, EventArgs e)
        {
            levelSet(sender, e, 3);
        }

        public void levelSet(object sender, EventArgs e,int l)
        {
            activateButtons();
            resetButton_Click(sender, e);
            level = l;
            sudokuBoard.loadBoard(l);
            String levelName;
            if (l == 1)
            {
                levelName = "Beginner";
            }
            else if (l == 2)
            {
                levelName = "Moderate";
            }
            else if (l == 3)
            {
                levelName = "Advanced";
            }
            else
            {
                levelName = "ERROR!";
            }
            currentLevel.Text = "Current Level: "+levelName+". Game #" + sudokuBoard.getGameNumber();
        }
        public void activateButtons()
        {
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
            buttonBlank.ForeColor = Color.Black;
            solutionButton.ForeColor = Color.Black;
            stuckButton.ForeColor = Color.Black;
            undoButton.ForeColor = Color.Black;
            resetButton.ForeColor = Color.Black;
        }

        private void lastGame_Click(object sender, EventArgs e)
        {
            sudokuBoard.loadLastGame(level);
        }

        private void prevGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
