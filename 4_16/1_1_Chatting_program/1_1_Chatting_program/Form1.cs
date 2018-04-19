using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace _1_1_Chatting_program
{

    public partial class Form1 : Form
    {
        // server client members 
        public NetworkStream m_Stream;//네트워크 스트림 
        public StreamReader m_Read;// 읽기  
        public StreamWriter m_Write;//쓰기
        const int PORT = 2002;//포트번호 
        private Thread m_ThReader;//읽기 쓰레드


        //server members 
        public bool _bStop = false;//서버 시작&중단 플래그
        private TcpListener m_listener;
        private Thread m_thServer;
        //서버 작동 리스너 //서버 스레드
        //client members
        public bool m_bConnect = false;//서버 접속 플래그
        TcpClient m_Client;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerStop();
            DisConnect();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Message(String msg)
        {
            //txt_all.AppendText(msg + "\r\n");
            //txt_all.Focus();
            //txt_all.ScrollToCaret();
            //txt_Send.Focus();

            this.Invoke(new MethodInvoker(delegate ()
            {
                txt_all.AppendText(msg + "\n");
                txt_all.Focus();
                txt_all.ScrollToCaret();
                txt_Send.Focus();

            }));
        }
        public void ServerStart()
        {
            try
            {
                m_listener = new TcpListener(PORT);
                m_listener.Start();

                m_bStop = true;
                Message("클라이언트 접속 대기중");

                while (m_bStop)
                {
                    TcpClient hClient = m_listener.AcceptTcpClient();
                }
            }
        }
    }
}
