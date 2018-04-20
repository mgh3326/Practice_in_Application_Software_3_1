using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp2
{
    public partial class Parent : Form
    {

        Child child;
        int nChild = 0;

        public Parent()
        {

            InitializeComponent();
        }

        
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child = new Child();
            child.MidParent = this;//이거 안되서 아마 새로 만들거 같다.
            child.Text = "NONAME" + nChild++;
            child.Show();
        }
		private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(openFDlg.ShowDialog() == DialogResult.OK)
			{
				
				Stream str = openFDlg.OpenFile();
				StreamReader reader = new StreamReader(str);

				child = new Child();
				child.MdiParent = this;
				child.Text = "NONAME" + nChild++;
				child. Show();

				child.getTextBox().Text = reader.ReadToEnd();
				reader.Close();
				str.Close();
			}


		}

		private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFDlg.ShowDialog() == DialogResult.OK)
			{
				child = (Child)(this.ActiveMdiChild);
				string fName = child.Text;
				StreamWriter write = new StreamWriter(Name);
				write.Write(child.getTextBox().Text);
				write.Close();
			}
				

		}


	}
}
