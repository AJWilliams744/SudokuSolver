using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SudokuSolver;
using static SudokuSolver.SudokuSolving;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Solve()
        {
            var grid = new List<List<BoxControl>>();

            Assert.IsFalse(Solve(grid));
        }

        [TestMethod]
        public void Test_GridIsNotValidH()
        {
            var grid = new List<List<BoxControl>>();

            var data = new List<String>();

            data.Add("1234");
            data.Add("3412");
            data.Add("2343");
            data.Add("4231");

            grid = CreateMinSizeGrid(data);

            Assert.IsFalse(IsGridValid(grid));
        }

        [TestMethod]
        public void Test_GridIsNotValidV()
        {
            var grid = new List<List<BoxControl>>();

            var data = new List<String>();

            data.Add("1234");
            data.Add("3412");
            data.Add("3142");
            data.Add("4321");

            grid = CreateMinSizeGrid(data);

            Assert.IsFalse(IsGridValid(grid));
        }

        [TestMethod]
        public void Test_GridIsValid()
        {
            var grid = new List<List<BoxControl>>();

            var data = new List<String>();

            data.Add("1234");
            data.Add("3412");
            data.Add("2143");
            data.Add("4321");

            grid = CreateMinSizeGrid(data);

            Assert.IsTrue(IsGridValid(grid));
        }

        [TestMethod]
        public void Test_CreateTxtboxGrid()
        {
            var grid = new List<List<BoxControl>>();

            grid = CreateTxtBoxGrid(4);

            Assert.IsTrue(grid.Count == 4 && grid[0].Count == 4);

        }

        [TestMethod]
        public void Test_CreateGridLines()
        {
            var grid = new List<PictureBox>();

            grid = CreateGridLines(60, 60, 4, 10, 10);

            Assert.IsTrue(grid.Count == 12);

        }

        [TestMethod]
        public void Test_CreateTextBox()
        {
            PictureBox p = CreateTextBox(new Point(5,5),20,20);

            Assert.IsTrue(p.Location == new Point(5,5) &&
                          p.Width == 20 &&
                          p.Height == 20 &&
                          p.BackColor == Color.Black &&
                          p.Margin == new Padding(0));

        }


        public List<List<BoxControl>> CreateMinSizeGrid(List<string> numberCollection)
        {
            var grid = new List<List<BoxControl>>();

            for (var y = 0; y < 4; y++)
            {
                var row = new List<BoxControl>();

                for (var x = 0; x < 4; x++)
                {
                    var b = new BoxControl();

                    b.SetValue(numberCollection[x][y].ToString());

                    row.Add(b);
                }

                grid.Add(row);
            }



            return grid;
        }
    }
}
