using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            string messageString = string.Format("사과 {0}개, 바나나 {1}개", txtApple.Text, txtBanana.Text);
            MessageBox.Show(messageString + "입력받았습니다.");
            var result = MessageBox.Show(
                messageString + " 입력받았습니다. \r\n계속 하시겠습니까?",
                "Caption",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
                MessageBox.Show("OK를 눌렀습니다.");
        }
    }
}
