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
        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNote.SelectedText);
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtNote.SelectAll();
            txtNote.Focus();
        }

        private void rdoDotum_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoDotum.Text, txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void rdoGulim_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoGulim.Text, txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void rdoGungsuh_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(rdoGungsuh.Text, txtNote.Font.Size, txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Bold ^ txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Underline ^ txtNote.Font.Style);
            txtNote.Font = f;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(txtNote.Font.FontFamily, txtNote.Font.Size, FontStyle.Italic ^ txtNote.Font.Style);
            txtNote.Font = f;
        }
    }
}
