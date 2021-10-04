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
    public partial class BoxControl : UserControl
    {
        static public int width = 60;
        static public int height = 60;
        public BoxControl()
        {
            InitializeComponent();
            width = Size.Width; //Not sure why this doesnt give 60 so removed
            height = Size.Height;
        }

        public void ResetData()
        {
            TBox.Text = "";
        }

        public int GetValue() 
        {
            if(TBox.Text == "")
            {
                return 0;
            }

            return Int32.Parse(TBox.Text);
        }

        public int GetSize()
        {
            return Size.Width;
        }

        private void TBox_TextChanged(object sender, EventArgs e)
        {
            if (TBox.Text == "")
            {
                return;
            }

            if (!Char.IsDigit(TBox.Text[0]))
            {
                TBox.Text = "";
            }
        }
    }
}
