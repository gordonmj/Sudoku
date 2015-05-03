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
    }
}
