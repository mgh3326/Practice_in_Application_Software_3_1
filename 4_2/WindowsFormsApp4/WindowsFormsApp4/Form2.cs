using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MyApplyDialog : Form
    {
        public event EventHandler Changed;
        public MyApplyDialog()
        {
            InitializeComponent();
            this.btnApply.Enabled = false;
        }

        private void Color_Scroll(object sender, ScrollEventArgs e)
        {
            this.btnApply.Enabled = true;
            this.BackColor = Color.FromArgb(this.hsbRed.Value, this.hsbGreen.Value, this.hsbBlue.Value);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Changed != null)
            {
                if (this.btnApply.Enabled == true)
                {

                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
