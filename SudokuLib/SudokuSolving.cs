using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace SudokuSolver
{
    public static class SudokuSolving
    {
        public static bool Solve(List<List<BoxControl>> grid)
        {            
            return false;
        }

        public static bool IsGridValid(List<List<BoxControl>> grid)
        {
            bool rows = CheckRowsCols(grid, true);
            bool cols = CheckRowsCols(grid, false);

            return rows & cols;
        }

        private static bool CheckRowsCols(List<List<BoxControl>> grid, bool checkRows)
        {
            int size = grid.Count;

            for (var y = 0; y < size; y++)
            {
                int expectedSum = 0;
                int currentSum = 0;

                for (var x = 0; x < grid[0].Count; x++)
                {
                    expectedSum += x + 1;
                    if (checkRows)
                    {
                        currentSum += grid[y][x].GetValue();
                    }
                    else
                    {
                        currentSum += grid[x][y].GetValue();
                    }
                    

                }
                if(expectedSum != currentSum)
                {
                    return false;
                }
            }

            return true;
        }

        private static List<BoxControl> CreateTxtboxRow(int size)
        {
            var newRow = new List<BoxControl>();
            for (var x = 0; x < size; x++)
            {
                var box = new BoxControl();                
                box.SendToBack();
                newRow.Add(box);
            }
            return newRow;
        }
        public static List<List<BoxControl>> CreateTxtBoxGrid(int size)
        {
            var grid = new List<List<BoxControl>>();

            for (var x = 0; x < size; x++)
            {
                grid.Add(CreateTxtboxRow(size));
            }

            return grid;
        }
        public static List<PictureBox> CreateGridLines(int txtWidth, int txtHeight, int size, int flowPanelX, int flowPanelY)
        {
            var Gridlines = new List<PictureBox>();

            // Horizontal Lines.
            AddDirectionalGrids(Gridlines, txtWidth, 2, 2, size, flowPanelY, flowPanelX, true, BoxControl.height);
            AddDirectionalGrids(Gridlines, txtWidth, 1, 1, size, flowPanelY, flowPanelX, false, BoxControl.height);

            // Verticle Lines.
            AddDirectionalGrids(Gridlines, 2, txtHeight, 2, size, flowPanelX, flowPanelY, true, BoxControl.width);
            AddDirectionalGrids(Gridlines, 1, txtHeight, 1, size, flowPanelX, flowPanelY, false, BoxControl.width);

            return Gridlines;
        }


        private static List<PictureBox> AddDirectionalGrids(List<PictureBox> Gridlines, int pictureWidth, int pictureHeight, int thickenss, int size, int originalLocation, int fixedPoint, bool outside, int boxDirection)
        {         

            size = (int)Math.Sqrt(size);
            int gap = size * boxDirection;

            int start = 0;
            if (!outside)
            {
                start = 1;
                size = (int)Math.Pow(size, 2);
                gap = boxDirection;
            }

            for (var x = start; x <= size; x++)
            {
                int position = (gap * x) + originalLocation;

                PictureBox p;

                if (pictureHeight < pictureWidth)
                {
                    p = CreateTextBox(new Point(fixedPoint + thickenss, position), pictureWidth, pictureHeight);
                }
                else
                {
                    p = CreateTextBox(new Point(position, fixedPoint + thickenss), pictureWidth, pictureHeight);
                }

                Gridlines.Add(p);

            }

            return Gridlines;
        }

        public static PictureBox CreateTextBox(Point location, int width, int height)
        {
            PictureBox p = new PictureBox
            {
                Location = location,
                Width = width,
                Height = height,
                BackColor = Color.Black,
                Margin = new Padding(0)
            };
            p.BringToFront();

            return p;
        }

    }


    

}
