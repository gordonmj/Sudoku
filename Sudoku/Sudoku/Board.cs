using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace Sudoku
{
    public class Board
    {
        public Panel panel;
        public System.Drawing.Graphics pG;
        public int width;
        public int height;
        public int boxWidth;
        public int boxHeight;
        public int[,] brd = new int[9,9]; 
        public bool[,] fxd = new bool[9,9];
        List<int[,]> allBoards = new List<int[,]>();
        public int boardIndex = 0;
        public int[,] sol = new int[9, 9];

        public Board(Panel p)
        {
            panel = p;
            pG = panel.CreateGraphics();
            width = panel.Width;
            height = panel.Height;
            boxHeight = panel.Height / 9;
            boxWidth = panel.Width / 9;
        }

        public void displayBoard()
        {
            pG.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);
            for (int r = 0; r < 9; r++)
            {

                for (int c = 0; c < 9; c++)
                {
                    if (r % 3 == 0 && c % 3 == 0)
                    {
                        pG.DrawRectangle(new Pen(new SolidBrush(Color.Red),5), c * boxWidth, r * boxHeight, 3*boxWidth, 3*boxHeight);
                    }
                    pG.DrawRectangle(new Pen(new SolidBrush(Color.Red)), c * boxWidth, r * boxHeight, boxWidth, boxHeight);
                    if ((r == 3 || r == 6) && (c == 3 || c == 6))
                    {
                        pG.FillEllipse(new SolidBrush(Color.Red), (boxWidth * c) - 10, (boxHeight * r) - 10, 20, 20);
                    }//if
                }//for c
            }//for r
        }//method

        public void clearDisplay()
        {
            displayBoard();
            brd = new int[9,9];
        }

        public bool fillSquare(Point pt, int num)
        {
            int probR = -1, probC = -1;
            try
            {
                probC = pt.X / boxWidth;
                probR = pt.Y / boxHeight;
                return fillHelper(probR, probC, num,false,true);
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Index out of range. probR is " + probR + " and probC is " + probC+ioore.ToString());
                return false;
            }
        }

        public bool fillHelper(int row, int col, int num, bool isUndo, bool isManual)
        {
            if (!isManual || (isValidinCol(num, col) && isValidinRow(num, row) && isValidinSquare(num, row, col)))
            {
                eraseSquare(new Point(col * boxWidth + 20, row * boxHeight + 20));
                if (fxd[row, col])
                {
                    MessageBox.Show("Sorry. You cannot change this space. Try again.");
                    return false;
                }
                int[] prevMove = { row, col, brd[row, col], num };
                if (!isUndo)
                {
                    Form1.prevMoves.Add(prevMove);
                }
                brd[row, col] = num;
                String number;
                if (num == 0)
                {
                    number = "";
                }
                else
                {
                    number = num.ToString();
                }
                //new Point(probC*boxWidth+boxWidth/2,probR*boxHeight+boxHeight/2)
                pG.DrawString(number, new Font("Arial", 22), new SolidBrush(Color.Black), new Point(col * boxWidth + 20, row * boxHeight + 20));
                return true;
            }
            else
            {
                return false;
            }

        }
        public void eraseSquare(Point pt)
        {
            int probR = -1, probC = -1;
            try
            {
                probC = pt.X / boxWidth;
                probR = pt.Y / boxHeight;
                if (fxd[probR, probC])
                {
                    return;
                }
                brd[probR, probC] = 0;
                //new Point(probC*boxWidth+boxWidth/2,probR*boxHeight+boxHeight/2)
                pG.FillRectangle(new SolidBrush(Color.White), (probC*boxWidth)+10, (probR*boxHeight)+10, boxWidth-20, boxHeight-20);
                pG.DrawRectangle(new Pen (new SolidBrush(Color.Red)), probC * boxWidth, probR * boxHeight, boxWidth, boxHeight);
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Index out of range. probR is " + probR + " and probC is " + probC);
            }
        }//method

        public bool isValidinRow(int num, int row)
        {
            if (num == 0)
            {
                return true;
            }
            for (int i = 0; i < 9; i++)
            {
                if (brd[row, i] == num)
                {
                    pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.Red), new Point(i * boxWidth + 20, row * boxHeight + 20));
                    MessageBox.Show("Can't put "+num+" in that row.");
                    pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.Black), new Point(i * boxWidth + 20, row * boxHeight + 20));
                    return false;
                }
            }
            return true;
        }

        public bool isValidinCol(int num, int col)
        {
            if (num == 0)
            {
                return true;
            } 
            for (int i = 0; i < 9; i++)
            {
                if (brd[i,col] == num)
                {
                    pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.Red), new Point(col * boxWidth + 20, i * boxHeight + 20));
                    MessageBox.Show("Can't put " + num + " in that column.");
                    pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.Black), new Point(col * boxWidth + 20, i * boxHeight + 20));
                    return false;
                }
            }
            return true;
        }

        public bool isValidinSquare(int num, int row, int col)
        {
            if (num == 0)
            {
                return true;
            } 
            row = row / 3;
            col = col / 3;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (brd[row * 3 + r, col * 3 + c] == num)
                    {
                        pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.Red), new Point((col * 3 + c) * boxWidth + 20, (row * 3 + r) * boxHeight + 20));
                        MessageBox.Show("Can't put " + num + " in that 3x3.");
                        pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.Black), new Point((col * 3 + c) * boxWidth + 20, (row * 3 + r) * boxHeight + 20));
                        return false;
                    }
                }
            }
            return true;
        }

        public void textFileToGrid()
        {
            /*
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "Plaintext Files|*.txt";
            oFD.Title = "Select a Plaintext File";
            String filename = "";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                filename = oFD.FileName;
            }
            */
            //filename = "/solutions.txt";
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\mgordon\\Documents\\solutions.txt");
            char[] delims = { '\n' };
            string line;
            for (int game = 0; game < 7000; game += 70)
            {
                line = lines[game];
                int[,] newBoard = new int[9, 9];
                int numeral = 0;
                for (int r = 0; r < 9; r++)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        newBoard[r, c] = Convert.ToInt32(line[numeral++])-48;
                    }//c
                }//r
                allBoards.Add(newBoard);
            }//for game
        }//method

        public void loadBoard()
        {
            sol = allBoards.ElementAt(boardIndex++);
            fxd = new bool[9, 9];
        }

        public void loadFirstNine()
        {
            Random rnd = new Random();
            int done = 0;
            int randRow, randCol;
            while (done <= 9){
            randRow = rnd.Next(0, 9);
            randCol = rnd.Next(0, 9);
            if (brd[randRow,randCol]==0){
                fillHelper(randRow, randCol, sol[randRow, randCol], false, false);
                fxd[randRow, randCol] = true;
                done++;
                }
            }
        }

        public void showSolution()
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (!fxd[r, c])
                    {
                        fillHelper(r, c, sol[r, c], false, false);
                    }
                }
            }
        }

    }//class
}//namespace
