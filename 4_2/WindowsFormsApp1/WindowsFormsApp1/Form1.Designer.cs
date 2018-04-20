namespace WindowsFormsApp1
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
			this.testFileBtn = new System.Windows.Forms.Button();
			this.testDirBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// testFileBtn
			// 
			this.testFileBtn.Location = new System.Drawing.Point(48, 44);
			this.testFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.testFileBtn.Name = "testFileBtn";
			this.testFileBtn.Size = new System.Drawing.Size(213, 56);
			this.testFileBtn.TabIndex = 0;
			this.testFileBtn.Text = "File.Exists (string filepath)";
			this.testFileBtn.UseVisualStyleBackColor = true;
			this.testFileBtn.Click += new System.EventHandler(this.testFileBtn_Click);
			// 
			// testDirBtn
			// 
			this.testDirBtn.Location = new System.Drawing.Point(48, 130);
			this.testDirBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.testDirBtn.Name = "testDirBtn";
			this.testDirBtn.Size = new System.Drawing.Size(213, 56);
			this.testDirBtn.TabIndex = 1;
			this.testDirBtn.Text = "Directory.Exists (string directorypath)";
			this.testDirBtn.UseVisualStyleBackColor = true;
			this.testDirBtn.Click += new System.EventHandler(this.testDirBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 360);
			this.Controls.Add(this.testDirBtn);
			this.Controls.Add(this.testFileBtn);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testFileBtn;
        private System.Windows.Forms.Button testDirBtn;
    }
}

