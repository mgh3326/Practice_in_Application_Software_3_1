namespace WindowsFormsApp2
{
    partial class Parent
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.바둑판배열세로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.바둑판배열가로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.계단식배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFDlg = new System.Windows.Forms.OpenFileDialog();
			this.saveFDlg = new System.Windows.Forms.SaveFileDialog();
			this.fontDlg = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.창ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(700, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 파일ToolStripMenuItem
			// 
			this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem});
			this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
			this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.파일ToolStripMenuItem.Text = "파일";
			// 
			// 새로만들기ToolStripMenuItem
			// 
			this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
			this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.새로만들기ToolStripMenuItem.Text = "새 파일";
			this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
			// 
			// 열기ToolStripMenuItem
			// 
			this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
			this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.열기ToolStripMenuItem.Text = "열기";
			this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
			// 
			// 저장ToolStripMenuItem
			// 
			this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
			this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.저장ToolStripMenuItem.Text = "저장";
			this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
			// 
			// 창ToolStripMenuItem
			// 
			this.창ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.바둑판배열세로ToolStripMenuItem,
            this.바둑판배열가로ToolStripMenuItem,
            this.계단식배열ToolStripMenuItem});
			this.창ToolStripMenuItem.Name = "창ToolStripMenuItem";
			this.창ToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
			this.창ToolStripMenuItem.Text = "창";
			// 
			// 바둑판배열세로ToolStripMenuItem
			// 
			this.바둑판배열세로ToolStripMenuItem.Name = "바둑판배열세로ToolStripMenuItem";
			this.바둑판배열세로ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.바둑판배열세로ToolStripMenuItem.Text = "바둑판 배열(세로)";
			// 
			// 바둑판배열가로ToolStripMenuItem
			// 
			this.바둑판배열가로ToolStripMenuItem.Name = "바둑판배열가로ToolStripMenuItem";
			this.바둑판배열가로ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.바둑판배열가로ToolStripMenuItem.Text = "바둑판 배열(가로)";
			// 
			// 계단식배열ToolStripMenuItem
			// 
			this.계단식배열ToolStripMenuItem.Name = "계단식배열ToolStripMenuItem";
			this.계단식배열ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.계단식배열ToolStripMenuItem.Text = "계단식 배열";
			// 
			// Parent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 360);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Parent";
			this.Text = "Parent";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFDlg;
        private System.Windows.Forms.SaveFileDialog saveFDlg;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바둑판배열세로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바둑판배열가로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계단식배열ToolStripMenuItem;
    }
}

