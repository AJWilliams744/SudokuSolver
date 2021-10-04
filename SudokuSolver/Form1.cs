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

        private void UpdateCurrentSize(int size)
        {
            

            int width = BoxControl.width * size;
            int height = BoxControl.height * size;

            FlowPanel.MaximumSize = new Size(width, height);
            FlowPanel.Size = new Size(width, height);

            AddBoxes(size);

            AddHGrids(width, size, FlowPanel.Location.Y, FlowPanel.Location.X,2, true);
            AddVGrids(height, size, FlowPanel.Location.X, FlowPanel.Location.Y,2, true);

            AddHGrids(width, size, FlowPanel.Location.Y, FlowPanel.Location.X, 1, false);
            AddVGrids(height, size, FlowPanel.Location.X, FlowPanel.Location.Y, 1, false);
        }

        private void AddHGrids(int width, int size, int originalLocation, int fixedPoint, int thickness, bool outside)
        {
            size = (int)Math.Sqrt(size);
            int gap = size * BoxControl.height;

            int start = 0;
            if (!outside)
            {
                start = 1;
                size = (int)Math.Pow(size, 2);
                gap = BoxControl.height;
            }

            for (var x = start; x <= size; x++)
            {
                int position = (gap * x) + originalLocation;

                PictureBox p = CreateTextBox(new Point(fixedPoint + thickness, position), width, thickness);

                GridLines.Add(p);
                Controls.Add(p);

                p.BringToFront();
                
            }
        }
        private void AddVGrids(int height, int size, int originalLocation, int fixedPoint, int thickness, bool outside)
        {
            size = (int)Math.Sqrt(size);
            int gap = size * BoxControl.width;

            int start = 0;
            if (!outside)
            {
                start = 1;
                size = (int)Math.Pow(size, 2);
                gap = BoxControl.width;
            }

            for (var x = start; x <= size; x++)
            {
                int position = (gap * x) + originalLocation;

                PictureBox p = CreateTextBox(new Point(position, fixedPoint + thickness), thickness, height);

                GridLines.Add(p);
                Controls.Add(p);

                p.BringToFront();

            }
        }

        private PictureBox CreateTextBox(Point location, int width, int height)
        {
            PictureBox p = new PictureBox();
            p.Location = location;
            p.Width = width;
            p.Height = height;
            p.BackColor = Color.Black;
            p.Margin = new Padding(0);
            p.BringToFront();

            return p;
        }

        private void AddBoxes(int size)
        {
            for (var x = 0; x < size; x++)
            {
                AddRow(size);
            }
        }
        private void AddRow(int size)
        {
            var newRow = new List<BoxControl>();
            for (var x = 0; x < size; x++)
            {
                var box = new BoxControl();
                FlowPanel.Controls.Add(box);
                box.SendToBack();
                newRow.Add(box);
            }
            Grid.Add(newRow);
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
            FlowPanel.Controls.Clear();
            ClearGridLines();

            Grid = new List<List<BoxControl>>();
            UpdateCurrentSize((int)Math.Pow((int)gridSizeAdj.Value, 2));
        }

        private void gridSizeAdj_ValueChanged(object sender, EventArgs e)
        {
            FlowPanel.Controls.Clear();
            ClearGridLines();

            Grid = new List<List<BoxControl>>();
            UpdateCurrentSize((int)Math.Pow((int)gridSizeAdj.Value, 2));
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

            UpdateCurrentSize(4);
            FlowPanel.Controls.Clear();
            Grid = new List<List<BoxControl>>();

            ClearGridLines();
            UpdateCurrentSize(4);
        }

        private void ValidBt_Click(object sender, EventArgs e)
        {
            IsValidTx.Text = SudokuSolving.IsGridValid(Grid).ToString();
        }

        private void SolveBt_Click(object sender, EventArgs e)
        {

        }
    }
}
