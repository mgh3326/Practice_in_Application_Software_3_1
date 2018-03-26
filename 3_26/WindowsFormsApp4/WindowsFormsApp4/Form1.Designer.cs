namespace WindowsFormsApp4
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
            this.mns = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cld = new System.Windows.Forms.ColorDialog();
            this.mns.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns
            // 
            this.mns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.서식ToolStripMenuItem});
            this.mns.Location = new System.Drawing.Point(0, 0);
            this.mns.Name = "mns";
            this.mns.Size = new System.Drawing.Size(800, 28);
            this.mns.TabIndex = 0;
            this.mns.Text = "mns";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(216, 26);
            this.tsmiOpen.Text = "열기(&O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackColor});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.서식ToolStripMenuItem.Text = "서식";
            // 
            // tsmiBackColor
            // 
            this.tsmiBackColor.Name = "tsmiBackColor";
            this.tsmiBackColor.Size = new System.Drawing.Size(216, 26);
            this.tsmiBackColor.Text = "화면 배경(&B)";
            this.tsmiBackColor.Click += new System.EventHandler(this.tsmiBackColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mns);
            this.MainMenuStrip = this.mns;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mns.ResumeLayout(false);
            this.mns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackColor;
        private System.Windows.Forms.ColorDialog cld;
    }
}

