
namespace SudokuSolver
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clBt = new System.Windows.Forms.Button();
            this.gridSizeAdj = new System.Windows.Forms.NumericUpDown();
            this.gridSizeLb = new System.Windows.Forms.Label();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StartBt = new System.Windows.Forms.Button();
            this.SolveBt = new System.Windows.Forms.Button();
            this.ValidBt = new System.Windows.Forms.Button();
            this.IsValidLable = new System.Windows.Forms.Label();
            this.IsValidTx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeAdj)).BeginInit();
            this.SuspendLayout();
            // 
            // clBt
            // 
            this.clBt.Location = new System.Drawing.Point(75, 96);
            this.clBt.Name = "clBt";
            this.clBt.Size = new System.Drawing.Size(259, 74);
            this.clBt.TabIndex = 2;
            this.clBt.Text = "Clear All";
            this.clBt.UseVisualStyleBackColor = true;
            this.clBt.Click += new System.EventHandler(this.clBt_Click);
            // 
            // gridSizeAdj
            // 
            this.gridSizeAdj.Location = new System.Drawing.Point(214, 191);
            this.gridSizeAdj.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.gridSizeAdj.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gridSizeAdj.Name = "gridSizeAdj";
            this.gridSizeAdj.Size = new System.Drawing.Size(120, 22);
            this.gridSizeAdj.TabIndex = 3;
            this.gridSizeAdj.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gridSizeAdj.ValueChanged += new System.EventHandler(this.gridSizeAdj_ValueChanged);
            // 
            // gridSizeLb
            // 
            this.gridSizeLb.AutoSize = true;
            this.gridSizeLb.Location = new System.Drawing.Point(75, 191);
            this.gridSizeLb.Name = "gridSizeLb";
            this.gridSizeLb.Size = new System.Drawing.Size(100, 17);
            this.gridSizeLb.TabIndex = 4;
            this.gridSizeLb.Text = "Grid Size ? x ?";
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FlowPanel.Location = new System.Drawing.Point(377, 96);
            this.FlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanel.MaximumSize = new System.Drawing.Size(180, 180);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(120, 120);
            this.FlowPanel.TabIndex = 5;
            // 
            // StartBt
            // 
            this.StartBt.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartBt.Location = new System.Drawing.Point(75, 180);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(259, 38);
            this.StartBt.TabIndex = 6;
            this.StartBt.Text = "Start";
            this.StartBt.UseVisualStyleBackColor = true;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
            // 
            // SolveBt
            // 
            this.SolveBt.Location = new System.Drawing.Point(75, 241);
            this.SolveBt.Name = "SolveBt";
            this.SolveBt.Size = new System.Drawing.Size(259, 74);
            this.SolveBt.TabIndex = 7;
            this.SolveBt.Text = "Solve";
            this.SolveBt.UseVisualStyleBackColor = true;
            //this.SolveBt.Click += new System.EventHandler(this.SolveBt_Click);
            // 
            // ValidBt
            // 
            this.ValidBt.Location = new System.Drawing.Point(75, 321);
            this.ValidBt.Name = "ValidBt";
            this.ValidBt.Size = new System.Drawing.Size(259, 74);
            this.ValidBt.TabIndex = 8;
            this.ValidBt.Text = "Is Valid?";
            this.ValidBt.UseVisualStyleBackColor = true;
            this.ValidBt.Click += new System.EventHandler(this.ValidBt_Click);
            // 
            // IsValidLable
            // 
            this.IsValidLable.AutoSize = true;
            this.IsValidLable.Location = new System.Drawing.Point(78, 402);
            this.IsValidLable.Name = "IsValidLable";
            this.IsValidLable.Size = new System.Drawing.Size(65, 17);
            this.IsValidLable.TabIndex = 9;
            this.IsValidLable.Text = "Is Valid : ";
            // 
            // IsValidTx
            // 
            this.IsValidTx.AutoSize = true;
            this.IsValidTx.Location = new System.Drawing.Point(150, 402);
            this.IsValidTx.Name = "IsValidTx";
            this.IsValidTx.Size = new System.Drawing.Size(0, 17);
            this.IsValidTx.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2367, 1162);
            this.Controls.Add(this.IsValidTx);
            this.Controls.Add(this.IsValidLable);
            this.Controls.Add(this.ValidBt);
            this.Controls.Add(this.SolveBt);
            this.Controls.Add(this.gridSizeLb);
            this.Controls.Add(this.gridSizeAdj);
            this.Controls.Add(this.clBt);
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.StartBt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeAdj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clBt;
        private System.Windows.Forms.NumericUpDown gridSizeAdj;
        private System.Windows.Forms.Label gridSizeLb;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Button StartBt;
        private System.Windows.Forms.Button SolveBt;
        private System.Windows.Forms.Button ValidBt;
        private System.Windows.Forms.Label IsValidLable;
        private System.Windows.Forms.Label IsValidTx;
    }
}

