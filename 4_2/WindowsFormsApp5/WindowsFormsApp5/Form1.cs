using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp5
{
    public partial class ThreadForm : Form
    {
        private Thread m_threadPlus;
        private Thread m_threadMinus;

        private int m_nValue = 0;
        private int m_nPlusCount = 0;
        private int m_nMinusCount = 0;

        public delegate void DelegateShowText(string strLabel, string strText);
        public DelegateShowText delegateShowTextInstance;

        public ThreadForm()
        {
            delegateShowTextInstance = new DelegateShowText(this.ShowText);
            InitializeComponent();
        }
        private void ShowText(string strLabel, string strText)
        {
            switch (strLabel)
            {
                case "label1":
                    label1.Text = strText;
                    break;
                case "label2":
                    label2.Text = strText;
                    break;
                case "label3":
                    label3.Text = strText;
                    break;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Thread 시작
            m_threadPlus = new Thread(new ThreadStart(ThreadPlus));
            m_threadMinus = new Thread(new ThreadStart(ThreadMinus));

            m_threadPlus.Start();
            m_threadMinus.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Thread 중지
            if (m_threadPlus.IsAlive == true)
                m_threadPlus.Abort();
            if (m_threadMinus.IsAlive == true)
                m_threadMinus.Abort();
        }
        private void ThreadPlus()
        {
            lock (this)
            {
                while (m_nPlusCount < 1000)
                {
                    int nValue = m_nValue + 1;
                    Thread.Sleep(1);
                    m_nValue = nValue;
                    //label1.Text = Convert.ToString(m_nValue);
                    Invoke(delegateShowTextInstance, new object[] { "label1", Convert.ToString(m_nValue) });
                    m_nPlusCount++;
                    //label2.Text = Convert.ToString(m_nPlusCount);
                    Invoke(delegateShowTextInstance, new object[] { "label2", Convert.ToString(m_nPlusCount) });
                }
            }
        }
        private void ThreadMinus()
        {
            lock (this)
            {
                while (m_nMinusCount > -1000)
                {
                    int nValue = m_nValue - 1;
                    Thread.Sleep(1);
                    m_nValue = nValue;
                    Invoke(delegateShowTextInstance, new object[] { "label3", Convert.ToString(m_nValue) });
                    //label1.Text = Convert.ToString(m_nValue);
                    m_nMinusCount--;
                    Invoke(delegateShowTextInstance, new object[] { "label4", Convert.ToString(m_nMinusCount) });
                    //label3.Text = Convert.ToString(m_nMinusCount);
                }
            }

        }
    }
}
