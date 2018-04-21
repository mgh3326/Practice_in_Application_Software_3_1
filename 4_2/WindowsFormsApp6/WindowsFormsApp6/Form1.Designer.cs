namespace WindowsFormsApp6
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmuListView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuDetail = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuList = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSmall = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLarge = new System.Windows.Forms.ToolStripMenuItem();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.lvwFiles = new System.Windows.Forms.ListView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.trvDir = new System.Windows.Forms.TreeView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.cmuListView.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtPath);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 50);
			this.panel1.TabIndex = 0;
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(94, 18);
			this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(526, 21);
			this.txtPath.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "전체경로";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lvwFiles);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.trvDir);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 50);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(700, 310);
			this.panel2.TabIndex = 1;
			// 
			// cmuListView
			// 
			this.cmuListView.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmuListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripMenuItem1,
            this.mnuDetail,
            this.mnuList,
            this.mnuSmall,
            this.mnuLarge});
			this.cmuListView.Name = "contextMenuStrip1";
			this.cmuListView.Size = new System.Drawing.Size(139, 120);
			// 
			// mnuOpen
			// 
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Size = new System.Drawing.Size(138, 22);
			this.mnuOpen.Text = "열기";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
			// 
			// mnuDetail
			// 
			this.mnuDetail.Name = "mnuDetail";
			this.mnuDetail.Size = new System.Drawing.Size(138, 22);
			this.mnuDetail.Text = "자세히";
			this.mnuDetail.Click += new System.EventHandler(this.mnuView_Click);
			// 
			// mnuList
			// 
			this.mnuList.Name = "mnuList";
			this.mnuList.Size = new System.Drawing.Size(138, 22);
			this.mnuList.Text = "간단히";
			this.mnuList.Click += new System.EventHandler(this.mnuView_Click);
			// 
			// mnuSmall
			// 
			this.mnuSmall.Name = "mnuSmall";
			this.mnuSmall.Size = new System.Drawing.Size(138, 22);
			this.mnuSmall.Text = "작은 아이콘";
			this.mnuSmall.Click += new System.EventHandler(this.mnuView_Click);
			// 
			// mnuLarge
			// 
			this.mnuLarge.Name = "mnuLarge";
			this.mnuLarge.Size = new System.Drawing.Size(138, 22);
			this.mnuLarge.Text = "큰 아이콘";
			this.mnuLarge.Click += new System.EventHandler(this.mnuView_Click);
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "20171214_164123.png");
			this.imgList.Images.SetKeyName(1, "20171214_164624.png");
			this.imgList.Images.SetKeyName(2, "introduce1.png");
			this.imgList.Images.SetKeyName(3, "스크린샷(2).png");
			// 
			// lvwFiles
			// 
			this.lvwFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvwFiles.ContextMenuStrip = this.cmuListView;
			this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			listViewGroup1.Header = "ListViewGroup";
			listViewGroup1.Name = "colFileName";
			listViewGroup2.Header = "ListViewGroup";
			listViewGroup2.Name = "colFileSize";
			listViewGroup3.Header = "ListViewGroup";
			listViewGroup3.Name = "colFileDate";
			this.lvwFiles.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
			this.lvwFiles.LargeImageList = this.imgList;
			this.lvwFiles.Location = new System.Drawing.Point(109, 0);
			this.lvwFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lvwFiles.Name = "lvwFiles";
			this.lvwFiles.Size = new System.Drawing.Size(591, 310);
			this.lvwFiles.SmallImageList = this.imgList;
			this.lvwFiles.TabIndex = 2;
			this.lvwFiles.UseCompatibleStateImageBehavior = false;
			this.lvwFiles.DoubleClick += new System.EventHandler(this.lvwFiles_DoubleClick);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(106, 0);
			this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 310);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// trvDir
			// 
			this.trvDir.Dock = System.Windows.Forms.DockStyle.Left;
			this.trvDir.ImageIndex = 0;
			this.trvDir.ImageList = this.imgList;
			this.trvDir.Location = new System.Drawing.Point(0, 0);
			this.trvDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.trvDir.Name = "trvDir";
			this.trvDir.SelectedImageIndex = 0;
			this.trvDir.Size = new System.Drawing.Size(106, 310);
			this.trvDir.TabIndex = 0;
			this.trvDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeExpand);
			this.trvDir.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeSelect);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 360);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "MyExplorer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.cmuListView.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView trvDir;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ContextMenuStrip cmuListView;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDetail;
        private System.Windows.Forms.ToolStripMenuItem mnuList;
        private System.Windows.Forms.ToolStripMenuItem mnuSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuLarge;
    }
}

