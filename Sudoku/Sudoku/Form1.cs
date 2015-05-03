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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            sudokuBoard.displayBoard();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sudokuBoard.clearDisplay();
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
                sudokuBoard.fillSquare(e.Location, numClicked);
                numClicked = 0;
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
            startButton_Click(sender, e);
            gameStarted = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
