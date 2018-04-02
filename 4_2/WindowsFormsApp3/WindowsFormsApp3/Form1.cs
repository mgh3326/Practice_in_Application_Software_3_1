using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class dlgForm : Form
    {
        public dlgForm()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            MyDlg md = new MyDlg();
            DialogResult dResult = md.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
            else if (dResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancle");
            }
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            MyDlg md = new MyDlg();
            md.Owner = this;
            md.Show();
        }
    }
}
