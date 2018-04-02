namespace WindowsFormsApp4
{
    partial class DialogApplyForm
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
            this.btnModaless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(27, 27);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(230, 43);
            this.btnModaless.TabIndex = 0;
            this.btnModaless.Text = "모달리스창 띄우기";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // DialogApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 96);
            this.Controls.Add(this.btnModaless);
            this.Name = "DialogApplyForm";
            this.Text = "DialogApplyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModaless;
    }
}

