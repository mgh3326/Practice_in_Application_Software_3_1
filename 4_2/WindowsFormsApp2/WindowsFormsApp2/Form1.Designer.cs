﻿namespace WindowsFormsApp2
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
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.오려내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙혀넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.글자색바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바탕색바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바둑판배열세로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바둑판배열가로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계단식배열ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFDlg = new System.Windows.Forms.SaveFileDialog();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.창ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.파일ToolStripMenuItem.Text = "파일(F)";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.새로만들기ToolStripMenuItem.Text = "새 파일";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른 이름으로 저장";
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.오려내기ToolStripMenuItem,
            this.복사하기ToolStripMenuItem,
            this.붙혀넣기ToolStripMenuItem,
            this.지우기ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.편집ToolStripMenuItem.Text = "편집(E)";
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.실행취소ToolStripMenuItem.Text = "실행취소";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // 오려내기ToolStripMenuItem
            // 
            this.오려내기ToolStripMenuItem.Name = "오려내기ToolStripMenuItem";
            this.오려내기ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.오려내기ToolStripMenuItem.Text = "오려내기";
            // 
            // 복사하기ToolStripMenuItem
            // 
            this.복사하기ToolStripMenuItem.Name = "복사하기ToolStripMenuItem";
            this.복사하기ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.복사하기ToolStripMenuItem.Text = "복사하기";
            // 
            // 붙혀넣기ToolStripMenuItem
            // 
            this.붙혀넣기ToolStripMenuItem.Name = "붙혀넣기ToolStripMenuItem";
            this.붙혀넣기ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.붙혀넣기ToolStripMenuItem.Text = "붙혀넣기";
            // 
            // 지우기ToolStripMenuItem
            // 
            this.지우기ToolStripMenuItem.Name = "지우기ToolStripMenuItem";
            this.지우기ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.지우기ToolStripMenuItem.Text = "지우기";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈ToolStripMenuItem,
            this.글꼴ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.글자색바꾸기ToolStripMenuItem,
            this.바탕색바꾸기ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.보기ToolStripMenuItem.Text = "보기(V)";
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            this.자동줄바꿈ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.자동줄바꿈ToolStripMenuItem.Text = "자동 줄 바꿈";
            this.자동줄바꿈ToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈ToolStripMenuItem_Click);
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.글꼴ToolStripMenuItem.Text = "글꼴";
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // 글자색바꾸기ToolStripMenuItem
            // 
            this.글자색바꾸기ToolStripMenuItem.Name = "글자색바꾸기ToolStripMenuItem";
            this.글자색바꾸기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.글자색바꾸기ToolStripMenuItem.Text = "글자색 바꾸기";
            this.글자색바꾸기ToolStripMenuItem.Click += new System.EventHandler(this.글자색바꾸기ToolStripMenuItem_Click);
            // 
            // 바탕색바꾸기ToolStripMenuItem
            // 
            this.바탕색바꾸기ToolStripMenuItem.Name = "바탕색바꾸기ToolStripMenuItem";
            this.바탕색바꾸기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.바탕색바꾸기ToolStripMenuItem.Text = "바탕색 바꾸기";
            this.바탕색바꾸기ToolStripMenuItem.Click += new System.EventHandler(this.바탕색바꾸기ToolStripMenuItem_Click);
            // 
            // 창ToolStripMenuItem
            // 
            this.창ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.바둑판배열세로ToolStripMenuItem,
            this.바둑판배열가로ToolStripMenuItem,
            this.계단식배열ToolStripMenuItem});
            this.창ToolStripMenuItem.Name = "창ToolStripMenuItem";
            this.창ToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.창ToolStripMenuItem.Text = "창(W)";
            // 
            // 바둑판배열세로ToolStripMenuItem
            // 
            this.바둑판배열세로ToolStripMenuItem.Name = "바둑판배열세로ToolStripMenuItem";
            this.바둑판배열세로ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.바둑판배열세로ToolStripMenuItem.Text = "바둑판 배열(세로)";
            this.바둑판배열세로ToolStripMenuItem.Click += new System.EventHandler(this.바둑판배열세로ToolStripMenuItem_Click);
            // 
            // 바둑판배열가로ToolStripMenuItem
            // 
            this.바둑판배열가로ToolStripMenuItem.Name = "바둑판배열가로ToolStripMenuItem";
            this.바둑판배열가로ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.바둑판배열가로ToolStripMenuItem.Text = "바둑판 배열(가로)";
            this.바둑판배열가로ToolStripMenuItem.Click += new System.EventHandler(this.바둑판배열가로ToolStripMenuItem_Click);
            // 
            // 계단식배열ToolStripMenuItem
            // 
            this.계단식배열ToolStripMenuItem.Name = "계단식배열ToolStripMenuItem";
            this.계단식배열ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.계단식배열ToolStripMenuItem.Text = "계단식 배열";
            this.계단식배열ToolStripMenuItem.Click += new System.EventHandler(this.계단식배열ToolStripMenuItem_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바둑판배열세로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바둑판배열가로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계단식배열ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 오려내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙혀넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 글자색바꾸기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바탕색바꾸기ToolStripMenuItem;
    }
}

