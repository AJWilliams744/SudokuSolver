
namespace SudokuSolver
{
    partial class BoxControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBox
            // 
            this.TBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBox.Location = new System.Drawing.Point(3, 16);
            this.TBox.MaxLength = 1;
            this.TBox.Multiline = true;
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(50, 50);
            this.TBox.TabIndex = 0;
            this.TBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBox.TextChanged += new System.EventHandler(this.TBox_TextChanged);
            // 
            // BoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BoxControl";
            this.Size = new System.Drawing.Size(60, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBox;
    }
}
