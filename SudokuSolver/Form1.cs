using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {

        private List<List<BoxControl>> Grid;
        private List<PictureBox> GridLines;

        public Form1()
        {
            InitializeComponent();

            //FlowPanel.AutoSize = true;
            Grid = new List<List<BoxControl>>();
            GridLines = new List<PictureBox>();

            gridSizeAdj.Visible = false;
            gridSizeLb.Visible = false;

            ValidBt.Visible = false;
            IsValidLable.Visible = false;
            IsValidTx.Visible = false;
            SolveBt.Visible = false;

            //UpdateCurrentSize(2);
        }
        #region Methods

 

        private void RefreshSudokuGrid(int size)
        {
            ClearSudoku();
            RefreshInternalSudokuGrid(size);
            RefreshExternalSudokuGrid();
        }

        private void RefreshInternalSudokuGrid(int size)
        {      

            int width = BoxControl.width * size;
            int height = BoxControl.height * size;

            FlowPanel.MaximumSize = new Size(width, height);
            FlowPanel.Size = new Size(width, height);

            Grid = SudokuSolving.CreateTxtBoxGrid(size);
            GridLines = SudokuSolving.CreateGridLines(width, height, size, FlowPanel.Location.X, FlowPanel.Location.Y);

        }

        private void RefreshExternalSudokuGrid()
        {           

            //Add all to screen
            AddGrid();
            AddGridLines();                    

        }

        private void AddGridLines()
        {
            foreach (var line in GridLines)
            {
                Controls.Add(line);
                line.BringToFront();
            }
        }

        private void AddGrid()
        {
            foreach (var gridList in Grid)
            {
                foreach (var grid in gridList)
                {
                    FlowPanel.Controls.Add(grid);
                }
            }
        }

        private void ClearSudoku()
        {
            FlowPanel.Controls.Clear();
            ClearGridLines();
        }

        private void ClearGridLines() { 
            foreach (var line in GridLines)
            {
                Controls.Remove(line);
            }
        }

        #endregion

        #region Events

        private void clBt_Click(object sender, EventArgs e)
        {
            RefreshSudokuGrid((int)Math.Pow((int)gridSizeAdj.Value, 2));
        }

        private void gridSizeAdj_ValueChanged(object sender, EventArgs e)
        {
            RefreshSudokuGrid((int)Math.Pow((int)gridSizeAdj.Value, 2));
        }
        #endregion

        private void StartBt_Click(object sender, EventArgs e)
        {
            gridSizeAdj.Visible = true;
            gridSizeLb.Visible = true;
            StartBt.Visible = false;

            ValidBt.Visible = true;
            IsValidLable.Visible = true;
            IsValidTx.Visible = true;
            SolveBt.Visible = true;

            //Flush the data grid
            RefreshSudokuGrid(4);
            RefreshSudokuGrid(4);

            /// RUN WHEN TESTING SPECIFIC GRID

            //ClearSudoku();
            //int width = BoxControl.width * 4;
            //int height = BoxControl.height * 4;

            //var data = new List<String>();

            //data.Add("1234");
            //data.Add("3412");
            //data.Add("2143");
            //data.Add("4321");

            //FlowPanel.MaximumSize = new Size(width, height);
            //FlowPanel.Size = new Size(width, height);

            //Grid = CreateMinSizeGrid(data);
            //GridLines = SudokuSolving.CreateGridLines(width, height, 4, FlowPanel.Location.X, FlowPanel.Location.Y);
            //RefreshExternalSudokuGrid();


           
        }

        //public List<List<BoxControl>> CreateMinSizeGrid(List<string> numberCollection)
        //{
        //    var grid = new List<List<BoxControl>>();

        //    for (var y = 0; y < 4; y++)
        //    {
        //        var row = new List<BoxControl>();

        //        for (var x = 0; x < 4; x++)
        //        {
        //            var b = new BoxControl();

        //            b.SetValue(numberCollection[x][y].ToString());

        //            row.Add(b);
        //        }

        //        grid.Add(row);
        //    }

        //    return grid;
        //}

        private void ValidBt_Click(object sender, EventArgs e)
        {
            IsValidTx.Text = SudokuSolving.IsGridValid(Grid).ToString();
        }

    }
}
