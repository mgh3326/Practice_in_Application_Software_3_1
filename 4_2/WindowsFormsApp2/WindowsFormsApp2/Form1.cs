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


        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                child = (Child)(this.ActiveMidChild);
                Stream fName = Child.Text;
                StreamWriter writer new= StreamWriter(fName);
                write.Write(Child.getTextBox())
            }
        }

        
    }
}
