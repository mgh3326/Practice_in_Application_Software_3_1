using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            pictProfile.ImageLocation = txtUrl.Text;
        }

        private void rdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            pictProfile.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void rdoStretchImage_CheckedChanged(object sender, EventArgs e)
        {
            pictProfile.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void rdoAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            pictProfile.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void rdoCenterImage_CheckedChanged(object sender, EventArgs e)
        {
            pictProfile.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void rdoZoom_CheckedChanged(object sender, EventArgs e)
        {
            pictProfile.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            pictProfile.Visible = !chkVisible.Checked;
        }
        private void rdoOption_CheckedChanged(object sender, EventArgs e)
        {
            //chap 4 p22 보고 해야됨 수업때 못함 이거 하면 위에 함수들을 한번에 동작할수 있다고함
        }
    }
}
