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
                        pG.FillEllipse(new SolidBrush(Color.Red), (boxWidth * c) - 4, (boxHeight * r) - 4, 10, 10);
                    }//if
                }
            }
        }
    }
}
