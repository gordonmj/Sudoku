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
        List<int[,]> beginnerBoards = new List<int[,]>();
        List<int[,]> moderateBoards = new List<int[,]>();
        List<int[,]> advancedBoards = new List<int[,]>();
        List<int> beginnerGamesPlayed = new List<int>();
        List<int> moderateGamesPlayed = new List<int>();
        List<int> advancedGamesPlayed = new List<int>();
        List<bool[,]> beginnerFixed = new List<bool[,]>();
        List<bool[,]> moderateFixed = new List<bool[,]>();
        List<bool[,]> advancedFixed = new List<bool[,]>(); 
        public int beginnerBoardIndex = 0;
        public int moderateBoardIndex = 0;
        public int advancedBoardIndex = 0;
        public int[,] sol = new int[9, 9];
        public int lastGame = 0;

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
            drawLines(true);
        }//method

        public void displayCurrentBoard()
        {
            pG.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);
            drawLines(false);
        }

        public void drawLines(bool isNew)
        {
            for (int r = 0; r < 9; r++)
            {

                for (int c = 0; c < 9; c++)
                {
                    if (r % 3 == 0 && c % 3 == 0)
                    {
                        pG.DrawRectangle(new Pen(new SolidBrush(Color.Red), 5), c * boxWidth, r * boxHeight, 3 * boxWidth, 3 * boxHeight);
                    }
                    pG.DrawRectangle(new Pen(new SolidBrush(Color.Red)), c * boxWidth, r * boxHeight, boxWidth, boxHeight);
                    if ((r == 3 || r == 6) && (c == 3 || c == 6))
                    {
                        pG.FillEllipse(new SolidBrush(Color.Red), (boxWidth * c) - 10, (boxHeight * r) - 10, 20, 20);
                    }//if
                    if (!isNew)
                    {
                        fillHelper(r, c, brd[r, c], false, false);
                        Form1.filled -= 1;
                    }
                }//for c
            }//for r
        }
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
            if (fxd[row, col] && isManual)
            {
                MessageBox.Show("Sorry. You cannot change this space. Try again.");
                return false;
            }
            String number;
            if (num == 0)
            {
                number = "";
            }
            else
            {
                number = num.ToString();
            }
            Color c = Color.Black;
            if (fxd[row, col] && !isManual)
            {
                c = Color.Blue;
            }

            if (isManual)
            {
                eraseSquare(new Point(col * boxWidth + 20, row * boxHeight + 20));
                Form1.filled += 2;
            }
            pG.DrawString(number, new Font("Arial", 22), new SolidBrush(c), new Point(col * boxWidth + 20, row * boxHeight + 20));

            if (!isManual || (isValidinCol(num, col,row) && isValidinRow(num, row,col) && isValidinSquare(num, row, col)))
            {


                int[] prevMove = { row, col, brd[row, col], num };
                if (!isUndo)
                {
                    Form1.prevMoves.Add(prevMove);
                }
                brd[row, col] = num;

                //new Point(probC*boxWidth+boxWidth/2,probR*boxHeight+boxHeight/2)

                return true;
            }
            else
            {
                eraseSquare(new Point(col * boxWidth + 20, row * boxHeight + 20));
                brd[row, col] = 0;
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
                    MessageBox.Show("Can't erase. This is part of the initial configuration.");
                    return;
                }
                brd[probR, probC] = 0;
                //new Point(probC*boxWidth+boxWidth/2,probR*boxHeight+boxHeight/2)
                pG.FillRectangle(new SolidBrush(Color.White), (probC*boxWidth)+10, (probR*boxHeight)+10, boxWidth-20, boxHeight-20);
                pG.DrawRectangle(new Pen (new SolidBrush(Color.Red)), probC * boxWidth, probR * boxHeight, boxWidth, boxHeight);
                Form1.filled--;
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Index out of range. probR is " + probR + " and probC is " + probC);
            }
        }//method

        public bool isValidinRow(int num, int row, int col)
        {
            if (num == 0)
            {
                return true;
            }
            for (int i = 0; i < 9; i++)
            {
                if (brd[row, i] == num)
                {
                    highlightWithMessage(num, row, i, "row");
                    return false;
                }
            }
            return true;
        }

        public bool isValidinCol(int num, int col, int row)
        {
            if (num == 0)
            {
                return true;
            } 
            for (int i = 0; i < 9; i++)
            {
                if (brd[i,col] == num)
                {
                    highlightWithMessage(num, i, col, "column");
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
                        highlightWithMessage(num, (row * 3 + r),(col * 3 + c), "3x3 square");
                        return false;
                    }
                }
            }
            return true;
        }

        public void highlightWithMessage(int num, int row, int col, String msg)
        {
            pG.FillRectangle(new SolidBrush(Color.Red), col * boxWidth, row * boxHeight, boxWidth, boxHeight);
            pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.White), new Point(col * boxWidth + 20, row * boxHeight + 20));
            MessageBox.Show("Can't put " + num + " in that "+msg+".");
            pG.FillRectangle(new SolidBrush(Color.White), col * boxWidth, row * boxHeight, boxWidth, boxHeight);
            pG.DrawRectangle(new Pen(new SolidBrush(Color.Red)), col * boxWidth, row * boxHeight, boxWidth, boxHeight);
            pG.DrawString(num.ToString(), new Font("Arial", 22), new SolidBrush(Color.Black), new Point(col * boxWidth + 20, row * boxHeight + 20));
            drawLines(false);
        }

        public int getGame()
        {
            int level = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\mgordon\\games.txt");
            for (int i = lines.Length-1; i > 0; i-- )
            {
                if (lines[i] == Form1.playerId)
                {
                    lastGame = Convert.ToInt32(lines[i - 1][0])-48;
                    level = Convert.ToInt32(lines[i - 1][2])-48;
                    return level;
                }
            }
            return level;
        }

        public void saveGameNumber(String player, int level)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\Users\\mgordon\\games.txt", true))
            {
                file.WriteLine(player+Environment.NewLine+lastGame+" "+level);
            }
        }

        public void textFileToGrid(int level)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\mgordon\\"+level+".txt");
            char[] delims = { '\n' };
            foreach (String line in lines)
            {
                int[,] newBoard = new int[9, 9];
                bool[,] newFixed = new bool[9, 9];
                int numeral = 0;
                for (int r = 0; r < 9; r++)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        newBoard[r, c] = Convert.ToInt32(line[numeral++])-48;
                    }//c
                }//r
                numeral += 2;
                for (int i = numeral+1; i < line.Length-2; i+=3)
                {
                    newFixed[Convert.ToInt32(line[i])-48, Convert.ToInt32(line[i + 1])-48] = true;
                }
                    if (level == 1)
                    {
                        beginnerBoards.Add(newBoard);
                        beginnerFixed.Add(newFixed);
                    }
                    else if (level == 2)
                    {
                        moderateBoards.Add(newBoard);
                        moderateFixed.Add(newFixed);
                    }
                    else if (level == 3)
                    {
                        advancedBoards.Add(newBoard);
                        advancedFixed.Add(newFixed);
                    }
            }//for game
        }//method

        public void loadBoard(int level)
        {
            try
            {
                Form1.filled = 0;
                if (level == 1)
                {
                    sol = beginnerBoards.ElementAt(beginnerBoardIndex);
                    lastGame = beginnerBoardIndex;
                    fxd = beginnerFixed.ElementAt(beginnerBoardIndex);
                    beginnerGamesPlayed.Add(lastGame);
                    beginnerBoardIndex++;
                }
                else if (level == 2)
                {
                    sol = moderateBoards.ElementAt(moderateBoardIndex);
                    lastGame = moderateBoardIndex;
                    fxd = moderateFixed.ElementAt(moderateBoardIndex);
                    moderateGamesPlayed.Add(lastGame);
                    moderateBoardIndex++;
                }
                else if (level == 3)
                {
                    sol = advancedBoards.ElementAt(advancedBoardIndex);
                    lastGame = advancedBoardIndex;
                    fxd = advancedFixed.ElementAt(advancedBoardIndex);
                    advancedGamesPlayed.Add(lastGame);
                    advancedBoardIndex++;
                }
                else
                {
                    return;
                }
                loadFirst();
                saveGameNumber(Form1.playerId, level);
            }
            catch
            {
                MessageBox.Show("That's all the games we have for this level. Sorry.");
                return;
            }
            
        }

        public void loadFirst()
        {
            for (int r = 0; r<9;r++){
                for (int c=0;c<9;c++){
                    if(fxd[r,c]){
                        fillHelper(r,c,sol[r,c],false,false);
                    }
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

        public bool isStuck()
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    for (int n = 0; n < 9; n++)
                    {
                        if ((isValidinCol(n, c,r) && isValidinRow(n, r,c) && isValidinSquare(n, r, c)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public int getGameNumber()
        {
            return lastGame;
        }

        public void loadLastGame(int level)
        {
            if (lastGame == 0)
            {
                level = getGame();
            }
            if (level == 1)
            {
                sol = beginnerBoards.ElementAt(lastGame);
                fxd = beginnerFixed.ElementAt(lastGame);
            }
            else if (level == 2)
            {
                sol = moderateBoards.ElementAt(lastGame);
                fxd = moderateFixed.ElementAt(lastGame);
            }
            else if (level == 3)
            {
                sol = advancedBoards.ElementAt(lastGame);
                fxd = advancedFixed.ElementAt(lastGame);
            }
            loadFirst();
        }

        public List<int> getPrevGames(int level)
        {
            if (level == 1)
            {
                return beginnerGamesPlayed;
            }
            else if (level == 2)
            {
                return moderateGamesPlayed;
            }
            else if (level == 3)
            {
                return advancedGamesPlayed;
            }
            else
            {
                return null;
            }
        }
    }//class
}//namespace
