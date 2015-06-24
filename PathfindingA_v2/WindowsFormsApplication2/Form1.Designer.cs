namespace WindowsFormsApplication2
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
            this.CreateGrid = new System.Windows.Forms.Button();
            this.GridW = new System.Windows.Forms.TextBox();
            this.GridH = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.BetterRectButton = new System.Windows.Forms.Button();
            this.getTargetableRect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateGrid
            // 
            this.CreateGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateGrid.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CreateGrid.Location = new System.Drawing.Point(943, 43);
            this.CreateGrid.Name = "CreateGrid";
            this.CreateGrid.Size = new System.Drawing.Size(67, 48);
            this.CreateGrid.TabIndex = 0;
            this.CreateGrid.Text = "CreateGrid";
            this.CreateGrid.UseVisualStyleBackColor = true;
            this.CreateGrid.Click += new System.EventHandler(this.CreateGrid_Click);
            // 
            // GridW
            // 
            this.GridW.Location = new System.Drawing.Point(943, 97);
            this.GridW.Name = "GridW";
            this.GridW.Size = new System.Drawing.Size(18, 20);
            this.GridW.TabIndex = 1;
            this.GridW.Text = "10";
            // 
            // GridH
            // 
            this.GridH.Location = new System.Drawing.Point(987, 97);
            this.GridH.Name = "GridH";
            this.GridH.Size = new System.Drawing.Size(18, 20);
            this.GridH.TabIndex = 2;
            this.GridH.Tag = "";
            this.GridH.Text = "10";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(967, 97);
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Size = new System.Drawing.Size(14, 20);
            this.X.TabIndex = 3;
            this.X.Text = "X";
            this.X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getTargetableRect
            // 
            this.getTargetableRect.Location = new System.Drawing.Point(942, 147);
            this.getTargetableRect.Name = "getTargetableRect";
            this.getTargetableRect.Size = new System.Drawing.Size(76, 23);
            this.getTargetableRect.TabIndex = 5;
            this.getTargetableRect.Text = "GetTargetableRect";
            this.getTargetableRect.UseVisualStyleBackColor = true;
            this.getTargetableRect.Click += new System.EventHandler(this.getTargetableRect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.getTargetableRect);
            this.Controls.Add(this.BetterRectButton);
            this.Controls.Add(this.X);
            this.Controls.Add(this.GridH);
            this.Controls.Add(this.GridW);
            this.Controls.Add(this.CreateGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateGrid;
        private System.Windows.Forms.TextBox GridW;
        private System.Windows.Forms.TextBox GridH;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Button BetterRectButton;
        private System.Windows.Forms.Button getTargetableRect;
    }
}

