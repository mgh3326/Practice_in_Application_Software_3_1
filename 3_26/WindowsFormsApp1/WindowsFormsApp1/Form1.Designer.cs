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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictProfile = new System.Windows.Forms.PictureBox();
            this.texUrl = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoStretchImage = new System.Windows.Forms.RadioButton();
            this.rdoAutoSize = new System.Windows.Forms.RadioButton();
            this.rdoCenterImage = new System.Windows.Forms.RadioButton();
            this.rdoZoom = new System.Windows.Forms.RadioButton();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictProfile
            // 
            this.pictProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictProfile.Image")));
            this.pictProfile.Location = new System.Drawing.Point(12, 34);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.Size = new System.Drawing.Size(288, 332);
            this.pictProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProfile.TabIndex = 0;
            this.pictProfile.TabStop = false;
            // 
            // texUrl
            // 
            this.texUrl.Location = new System.Drawing.Point(56, 24);
            this.texUrl.Name = "texUrl";
            this.texUrl.Size = new System.Drawing.Size(422, 25);
            this.texUrl.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(403, 63);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(342, 182);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(72, 19);
            this.rdoNormal.TabIndex = 3;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoStretchImage
            // 
            this.rdoStretchImage.AutoSize = true;
            this.rdoStretchImage.Location = new System.Drawing.Point(420, 182);
            this.rdoStretchImage.Name = "rdoStretchImage";
            this.rdoStretchImage.Size = new System.Drawing.Size(112, 19);
            this.rdoStretchImage.TabIndex = 4;
            this.rdoStretchImage.TabStop = true;
            this.rdoStretchImage.Text = "StretchImage";
            this.rdoStretchImage.UseVisualStyleBackColor = true;
            // 
            // rdoAutoSize
            // 
            this.rdoAutoSize.AutoSize = true;
            this.rdoAutoSize.Location = new System.Drawing.Point(538, 182);
            this.rdoAutoSize.Name = "rdoAutoSize";
            this.rdoAutoSize.Size = new System.Drawing.Size(87, 19);
            this.rdoAutoSize.TabIndex = 5;
            this.rdoAutoSize.TabStop = true;
            this.rdoAutoSize.Text = "AutoSize";
            this.rdoAutoSize.UseVisualStyleBackColor = true;
            // 
            // rdoCenterImage
            // 
            this.rdoCenterImage.AutoSize = true;
            this.rdoCenterImage.Location = new System.Drawing.Point(631, 182);
            this.rdoCenterImage.Name = "rdoCenterImage";
            this.rdoCenterImage.Size = new System.Drawing.Size(108, 19);
            this.rdoCenterImage.TabIndex = 6;
            this.rdoCenterImage.TabStop = true;
            this.rdoCenterImage.Text = "CenterImage";
            this.rdoCenterImage.UseVisualStyleBackColor = true;
            // 
            // rdoZoom
            // 
            this.rdoZoom.AutoSize = true;
            this.rdoZoom.Location = new System.Drawing.Point(745, 182);
            this.rdoZoom.Name = "rdoZoom";
            this.rdoZoom.Size = new System.Drawing.Size(66, 19);
            this.rdoZoom.TabIndex = 7;
            this.rdoZoom.TabStop = true;
            this.rdoZoom.Text = "Zoom";
            this.rdoZoom.UseVisualStyleBackColor = true;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(342, 249);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(74, 19);
            this.chkVisible.TabIndex = 8;
            this.chkVisible.Text = "숨기기";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(321, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 332);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "프로필관리";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnChange);
            this.groupBox2.Controls.Add(this.texUrl);
            this.groupBox2.Location = new System.Drawing.Point(6, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 92);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사진변경";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "옵션";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 376);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.rdoZoom);
            this.Controls.Add(this.rdoCenterImage);
            this.Controls.Add(this.rdoAutoSize);
            this.Controls.Add(this.rdoStretchImage);
            this.Controls.Add(this.rdoNormal);
            this.Controls.Add(this.pictProfile);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictProfile;
        private System.Windows.Forms.TextBox texUrl;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoStretchImage;
        private System.Windows.Forms.RadioButton rdoAutoSize;
        private System.Windows.Forms.RadioButton rdoCenterImage;
        private System.Windows.Forms.RadioButton rdoZoom;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

