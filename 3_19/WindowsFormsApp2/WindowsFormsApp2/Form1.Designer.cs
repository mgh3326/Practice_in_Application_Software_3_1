namespace WindowsFormsApp2
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
			this.lstLanguages = new System.Windows.Forms.ListBox();
			this.btnList2Checked = new System.Windows.Forms.Button();
			this.btnChecked2List = new System.Windows.Forms.Button();
			this.btnChecked2TextBox = new System.Windows.Forms.Button();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.ck1Languages = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// lstLanguages
			// 
			this.lstLanguages.FormattingEnabled = true;
			this.lstLanguages.ItemHeight = 12;
			this.lstLanguages.Items.AddRange(new object[] {
            "Java",
            "C",
            "C++",
            "Python",
            "C#",
            "Visual Basic .NET",
            "PHP",
            "JavaScript",
            "Ruby",
            "SQL",
            "Perl",
            "Swift",
            "Delphi/Object Pascal",
            "Objective-C",
            "Visual Basic",
            "Assembly language",
            "Go",
            "MATLAB",
            "PL/SQL",
            "R"});
			this.lstLanguages.Location = new System.Drawing.Point(10, 10);
			this.lstLanguages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lstLanguages.Name = "lstLanguages";
			this.lstLanguages.Size = new System.Drawing.Size(135, 112);
			this.lstLanguages.TabIndex = 0;
			// 
			// btnList2Checked
			// 
			this.btnList2Checked.Location = new System.Drawing.Point(172, 34);
			this.btnList2Checked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnList2Checked.Name = "btnList2Checked";
			this.btnList2Checked.Size = new System.Drawing.Size(46, 31);
			this.btnList2Checked.TabIndex = 1;
			this.btnList2Checked.Text = "▶";
			this.btnList2Checked.UseVisualStyleBackColor = true;
			this.btnList2Checked.Click += new System.EventHandler(this.btnList2Checked_Click);
			// 
			// btnChecked2List
			// 
			this.btnChecked2List.Location = new System.Drawing.Point(172, 70);
			this.btnChecked2List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnChecked2List.Name = "btnChecked2List";
			this.btnChecked2List.Size = new System.Drawing.Size(46, 31);
			this.btnChecked2List.TabIndex = 2;
			this.btnChecked2List.Text = "◀";
			this.btnChecked2List.UseVisualStyleBackColor = true;
			this.btnChecked2List.Click += new System.EventHandler(this.btnChecked2List_Click);
			// 
			// btnChecked2TextBox
			// 
			this.btnChecked2TextBox.Location = new System.Drawing.Point(313, 217);
			this.btnChecked2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnChecked2TextBox.Name = "btnChecked2TextBox";
			this.btnChecked2TextBox.Size = new System.Drawing.Size(80, 31);
			this.btnChecked2TextBox.TabIndex = 3;
			this.btnChecked2TextBox.Text = "◀◀";
			this.btnChecked2TextBox.UseVisualStyleBackColor = true;
			this.btnChecked2TextBox.Click += new System.EventHandler(this.btnChecked2TextBox_Click);
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(28, 162);
			this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNote.Size = new System.Drawing.Size(260, 168);
			this.txtNote.TabIndex = 4;
			this.txtNote.WordWrap = false;
			// 
			// ck1Languages
			// 
			this.ck1Languages.CheckOnClick = true;
			this.ck1Languages.FormattingEnabled = true;
			this.ck1Languages.Location = new System.Drawing.Point(298, 34);
			this.ck1Languages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ck1Languages.Name = "ck1Languages";
			this.ck1Languages.Size = new System.Drawing.Size(106, 68);
			this.ck1Languages.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 344);
			this.Controls.Add(this.ck1Languages);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.btnChecked2TextBox);
			this.Controls.Add(this.btnChecked2List);
			this.Controls.Add(this.btnList2Checked);
			this.Controls.Add(this.lstLanguages);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.Button btnList2Checked;
        private System.Windows.Forms.Button btnChecked2List;
        private System.Windows.Forms.Button btnChecked2TextBox;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.CheckedListBox ck1Languages;
    }
}

