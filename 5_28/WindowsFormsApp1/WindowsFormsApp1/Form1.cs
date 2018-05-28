using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int num_log = 1;
        Thread thread;
        public Form1()
        {

            InitializeComponent();
            btnStart.Click += Button_Chain;
        }
        private void Button_Chain(object sender,EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Red;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(()=>
            {
                while (num_log < 1000)
                {
                    lblLog.Invoke((MethodInvoker)(() => { lblLog.Text = (++num_log).ToString(); }));

                }

            }
                );

                        thread.Start();
        }
        //public delegate void DelegatePlus();
        //private void LabelPlus()
        //{
        //    while (num_log < 1000)
        //    {
        //        lblLog.Invoke((MethodInvoker)(delegate () { lblLog.Text = (++num_log).ToString(); }));
        //    }
        //}
        //public void lblLogPlus()
        //{
        //    lblLog.Text = (++num_log).ToString();
        //}
    }
}
