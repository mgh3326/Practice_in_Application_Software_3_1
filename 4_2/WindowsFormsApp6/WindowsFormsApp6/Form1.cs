using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Drv_list;
            TreeNode root;
            //전체 드라이브 리스트를 가지고 홈 
            Drv_list = Environment.GetLogicalDrives();

            foreach (string Drv in Drv_list)
            {
                root = trvDir.Nodes.Add(Drv);
                root.ImageIndex = 2; //이미지 리스트 번호

                //처음 실행시 첫번째 드라이브가 선택되도록 함 
                if (trvDir.SelectedNode == null)
                    trvDir.SelectedNode = root;
                root.SelectedImageIndex = root.ImageIndex;
                root.Nodes.Add("");
            }
        }
        public void setPlus(TreeNode node)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;
            try
            {
                path = node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();
                if (di.Length > 0)
                    node.Nodes.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void OpenFiles()
        {
            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;
            //아이템이 여러개이기 때문에 다음과 같이 설정 
            foreach (ListViewItem item in siList)
            {
                OpenItem(item);
            }
        }
        public void OpenItem(ListViewItem item)
        {
            TreeNode node;
            TreeNode child;

            if (item.Tag.ToString() == "D")
            {
                //현재 선택된 트리뷰의 노드를 확장
                node = trvDir.SelectedNode;
                node.Expand();
                //확장된 노드 중 현재 리스트뷰에서 선택한 같은 노드를 선택
                child = node.FirstNode;

                while (child != null)
                {
                    if (child.Text == item.Text)
                    {
                        trvDir.SelectedNode = child;
                        trvDir.Focus();
                        break;
                    }
                    child = child.NextNode;
                }
            }
            else
            {
                //파일 실행을 위해 using System.Diagnostics;추가
                Process.Start(txtPath.Text + "\\" + item.Text);
            }


        }

        private void trvDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            String path; //경로지정변수
            DirectoryInfo dir; //디렉토리 정보
            DirectoryInfo[] di; //하위 디렉토리
            TreeNode node;
            try
            {
                e.Node.Nodes.Clear();
                path = e.Node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();
                foreach (DirectoryInfo dirs in di)
                {
                    //루트 디렉토리 바로 및 디렉토리를 보여줌.
                    node = e.Node.Nodes.Add(dirs.Name);
                    setPlus(node);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void trvDir_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DirectoryInfo di;
            DirectoryInfo[] diarray;
            ListViewItem item;
            FileInfo[] fiArray;
            try
            {
                di = new DirectoryInfo(e.Node.FullPath);
                txtPath.Text = e.Node.FullPath.Substring(0, 2) + e.Node.FullPath.Substring(3);
                lvwFiles.Items.Clear(); // 기존 정보초기화

                //디렉토리
                diarray = di.GetDirectories();
                foreach (DirectoryInfo tdis in diarray)
                {
                    item = lvwFiles.Items.Add(tdis.Name);//이름
                    item.SubItems.Add(""); //디렉토리의 크기는 표시하지 않는다.
                    item.SubItems.Add(tdis.LastWriteTime.ToString()); //수정한날짜
                    item.ImageIndex = 0;
                    item.Tag = "D";
                }
                //파일
                fiArray = di.GetFiles();
                foreach (FileInfo fis in fiArray)
                {
                    item = lvwFiles.Items.Add(fis.Name);//이름
                    item.SubItems.Add(fis.Length.ToString()); //크7|(byte)
                    item.SubItems.Add(fis.LastWriteTime.ToString()); //수정한날짜
                    item.ImageIndex = 1;
                    item.Tag = "F";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lvwFiles_DoubleClick(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void mnuView_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            mnuDetail.Checked = false;
            mnuList.Checked = false;
            mnuSmall.Checked = false;
            mnuLarge.Checked = false;
            switch (item.Text)
            {
                case "자세히":
                    mnuDetail.Checked = true;
                    lvwFiles.View = View.Details;
                    break;
                case "간단히":
                    mnuList.Checked = true;
                    lvwFiles.View = View.List;
                    break;

                case "작은 아이콘":
                    mnuSmall.Checked = true;
                    lvwFiles.View = View.SmallIcon;
                    break;
                case "큰 아이콘":
                    mnuLarge.Checked = true;
                    lvwFiles.View = View.LargeIcon;
                    break;

            }
        }
    }
}





