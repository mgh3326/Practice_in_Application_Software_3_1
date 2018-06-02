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
        private void Button_Chain(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.Color.Red;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(() =>
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
// 비고
// Thread입력인자인 ThreadStart는 입력인자와 반환값이 없는 Delegate형 인자를 입력받는다.
// 한편, Invoke method의 첫 번째 인자는 모든 Delegate형의 인자를 입력받기 때문에 (MethodInvoker)로 명시적 형 변환을 해야한다. (안하면 에러!)





// new Thread((ThreadStart)delegate()...{  ...} 은 (ThreadStart) 부분을 생략 가능 하지만
// lblLog.Invoke(delegate () {  ...} 은 불가능 하다.
// 이거 바꾸는거 할줄 알아야겠다.