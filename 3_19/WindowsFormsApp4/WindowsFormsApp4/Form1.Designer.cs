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
			this.lvwPeopleInfo = new System.Windows.Forms.ListView();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvwPeopleInfo
			// 
			this.lvwPeopleInfo.Location = new System.Drawing.Point(10, 10);
			this.lvwPeopleInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lvwPeopleInfo.Name = "lvwPeopleInfo";
			this.lvwPeopleInfo.Size = new System.Drawing.Size(680, 146);
			this.lvwPeopleInfo.TabIndex = 0;
			this.lvwPeopleInfo.UseCompatibleStateImageBehavior = false;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(86, 201);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(88, 21);
			this.txtName.TabIndex = 1;
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(262, 202);
			this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(88, 21);
			this.txtAge.TabIndex = 2;
			this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(11, 209);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(39, 12);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Name";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.Location = new System.Drawing.Point(207, 204);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(27, 12);
			this.lblAge.TabIndex = 4;
			this.lblAge.Text = "Age";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.Location = new System.Drawing.Point(400, 204);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(46, 12);
			this.lblGender.TabIndex = 5;
			this.lblGender.Text = "Gender";
			// 
			// cmbGender
			// 
			this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
			this.cmbGender.Location = new System.Drawing.Point(521, 198);
			this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(106, 20);
			this.cmbGender.TabIndex = 6;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(108, 284);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(66, 18);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(229, 284);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(66, 18);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(363, 284);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(66, 18);
			this.btnEdit.TabIndex = 9;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 360);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lvwPeopleInfo);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPeopleInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}

