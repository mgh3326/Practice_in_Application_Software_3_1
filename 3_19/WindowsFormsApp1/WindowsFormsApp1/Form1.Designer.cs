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
            this.btnMessage = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpFonts = new System.Windows.Forms.GroupBox();
            this.rdoGungsuh = new System.Windows.Forms.RadioButton();
            this.rdoGulim = new System.Windows.Forms.RadioButton();
            this.rdoDotum = new System.Windows.Forms.RadioButton();
            this.grpStyles = new System.Windows.Forms.GroupBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.grpFonts.SuspendLayout();
            this.grpStyles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(309, 51);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(12, 12);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(200, 182);
            this.txtNote.TabIndex = 2;
            this.txtNote.Text = "TestBox 예제\r\nSelect 클릭 후\r\nMessage 클릭\r\n\r\n혹은 TextBox 드래그 후\r\nMessage";
            this.txtNote.WordWrap = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(309, 117);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grpFonts
            // 
            this.grpFonts.Controls.Add(this.rdoGungsuh);
            this.grpFonts.Controls.Add(this.rdoGulim);
            this.grpFonts.Controls.Add(this.rdoDotum);
            this.grpFonts.Location = new System.Drawing.Point(31, 264);
            this.grpFonts.Name = "grpFonts";
            this.grpFonts.Size = new System.Drawing.Size(200, 188);
            this.grpFonts.TabIndex = 4;
            this.grpFonts.TabStop = false;
            this.grpFonts.Text = "Fonts";
            // 
            // rdoGungsuh
            // 
            this.rdoGungsuh.AutoSize = true;
            this.rdoGungsuh.Location = new System.Drawing.Point(6, 120);
            this.rdoGungsuh.Name = "rdoGungsuh";
            this.rdoGungsuh.Size = new System.Drawing.Size(58, 19);
            this.rdoGungsuh.TabIndex = 2;
            this.rdoGungsuh.TabStop = true;
            this.rdoGungsuh.Text = "궁서";
            this.rdoGungsuh.UseVisualStyleBackColor = true;
            this.rdoGungsuh.CheckedChanged += new System.EventHandler(this.rdoGungsuh_CheckedChanged);
            // 
            // rdoGulim
            // 
            this.rdoGulim.AutoSize = true;
            this.rdoGulim.Location = new System.Drawing.Point(6, 69);
            this.rdoGulim.Name = "rdoGulim";
            this.rdoGulim.Size = new System.Drawing.Size(58, 19);
            this.rdoGulim.TabIndex = 1;
            this.rdoGulim.TabStop = true;
            this.rdoGulim.Text = "굴림";
            this.rdoGulim.UseVisualStyleBackColor = true;
            this.rdoGulim.CheckedChanged += new System.EventHandler(this.rdoGulim_CheckedChanged);
            // 
            // rdoDotum
            // 
            this.rdoDotum.AutoSize = true;
            this.rdoDotum.Location = new System.Drawing.Point(6, 24);
            this.rdoDotum.Name = "rdoDotum";
            this.rdoDotum.Size = new System.Drawing.Size(58, 19);
            this.rdoDotum.TabIndex = 0;
            this.rdoDotum.TabStop = true;
            this.rdoDotum.Text = "돋움";
            this.rdoDotum.UseVisualStyleBackColor = true;
            this.rdoDotum.CheckedChanged += new System.EventHandler(this.rdoDotum_CheckedChanged);
            // 
            // grpStyles
            // 
            this.grpStyles.Controls.Add(this.chkItalic);
            this.grpStyles.Controls.Add(this.chkUnderline);
            this.grpStyles.Controls.Add(this.chkBold);
            this.grpStyles.Location = new System.Drawing.Point(309, 264);
            this.grpStyles.Name = "grpStyles";
            this.grpStyles.Size = new System.Drawing.Size(190, 188);
            this.grpStyles.TabIndex = 5;
            this.grpStyles.TabStop = false;
            this.grpStyles.Text = "Styles";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(23, 25);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(59, 19);
            this.chkBold.TabIndex = 3;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(23, 69);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(89, 19);
            this.chkUnderline.TabIndex = 4;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(23, 120);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(58, 19);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 464);
            this.Controls.Add(this.grpStyles);
            this.Controls.Add(this.grpFonts);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpFonts.ResumeLayout(false);
            this.grpFonts.PerformLayout();
            this.grpStyles.ResumeLayout(false);
            this.grpStyles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grpFonts;
        private System.Windows.Forms.RadioButton rdoGungsuh;
        private System.Windows.Forms.RadioButton rdoGulim;
        private System.Windows.Forms.RadioButton rdoDotum;
        private System.Windows.Forms.GroupBox grpStyles;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkBold;
    }
}

