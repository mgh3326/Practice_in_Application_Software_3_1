namespace WindowsFormsApp3
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
            this.booksTB = new System.Windows.Forms.TextBox();
            this.periodicalsTB = new System.Windows.Forms.TextBox();
            this.foodsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // booksTB
            // 
            this.booksTB.Location = new System.Drawing.Point(134, 41);
            this.booksTB.Name = "booksTB";
            this.booksTB.Size = new System.Drawing.Size(100, 25);
            this.booksTB.TabIndex = 0;
            this.booksTB.TextChanged += new System.EventHandler(this.booksTB_TextChanged);
            // 
            // periodicalsTB
            // 
            this.periodicalsTB.Location = new System.Drawing.Point(134, 72);
            this.periodicalsTB.Name = "periodicalsTB";
            this.periodicalsTB.Size = new System.Drawing.Size(100, 25);
            this.periodicalsTB.TabIndex = 1;
            this.periodicalsTB.TextChanged += new System.EventHandler(this.periodicalsTB_TextChanged);
            // 
            // foodsTB
            // 
            this.foodsTB.Location = new System.Drawing.Point(134, 103);
            this.foodsTB.Name = "foodsTB";
            this.foodsTB.Size = new System.Drawing.Size(100, 25);
            this.foodsTB.TabIndex = 2;
            this.foodsTB.TextChanged += new System.EventHandler(this.foodsTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // displayBTN
            // 
            this.displayBTN.Location = new System.Drawing.Point(32, 171);
            this.displayBTN.Name = "displayBTN";
            this.displayBTN.Size = new System.Drawing.Size(75, 23);
            this.displayBTN.TabIndex = 6;
            this.displayBTN.Text = "Display";
            this.displayBTN.UseVisualStyleBackColor = true;
            this.displayBTN.Click += new System.EventHandler(this.displayBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(32, 200);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 7;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(32, 229);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 8;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.displayBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodsTB);
            this.Controls.Add(this.periodicalsTB);
            this.Controls.Add(this.booksTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox booksTB;
        private System.Windows.Forms.TextBox periodicalsTB;
        private System.Windows.Forms.TextBox foodsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button displayBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label label4;
    }
}

