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
        public bool m_bStop = false;//서버 시작&중단 플래그
        private TcpListener m_listener;//서버 작동 리스너
        private Thread m_thServer; //서버 스레드
        
        //client members
        public bool m_bConnect = false;//서버 접속 플래그
        TcpClient m_Client;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerStop();//서버 중지
            Disconnect();//연결 종료
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
                txt_send.Focus();
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
                    if (hClient.Connected)
                    {
                        m_bConnect = true;
                        Message("클라이언트 접속");

                        m_Stream = hClient.GetStream();
                        m_Read = new StreamReader(m_Stream);
                        m_Write = new StreamWriter(m_Stream);

                        m_ThReader = new Thread(new ThreadStart(Receive));
                        m_ThReader.Start();
                    }
                }
            }
            catch
            {
                Message("시작 도중에 오류 발생");
                return;
            }
        }
        public void ServerStop()
        {
            if (!m_bStop)
                return;
            m_listener.Stop();//서버 소켓 작동 중지

            m_Read.Close();
            m_Write.Close();

            m_Stream.Close();

            m_ThReader.Abort();//서버 소켓 스레드 종료
            m_thServer.Abort();//스레드 종료

            Message("서비스 종료");

        }

        public void Disconnect()
        {
            if (!m_bConnect)
                return;
            m_bConnect = false;

            m_Read.Close();
            m_Write.Close();

            m_Stream.Close();
            m_ThReader.Abort();

            Message("상대방과 연결 중단");

        }
        public void Connect()
        {
            m_Client = new TcpClient();
            try
            {
                m_Client.Connect(txt_ServerIp.Text, PORT);
            }

            catch
            {
                m_bConnect = false;
                return;

            }
            m_bConnect = true;
            Message("서버에 연결");
            m_Stream = m_Client.GetStream();

            m_Read = new StreamReader(m_Stream);
            m_Write = new StreamWriter(m_Stream);
            m_ThReader = new Thread(new ThreadStart(Receive));
            m_ThReader.Start();

        }
        public void Receive()
        {
            try
            {
                while (m_bConnect)
                {
                    string szMessage = m_Read.ReadLine();
                    if (szMessage != null)
                        Message("상대방 >>> : " + szMessage);
                }
            }
            catch
            {
                Message("데이터를 읽는 과정에서 오류가 발생");
            }
            Disconnect();
        }
        void Send()
        {
            try
            {
                m_Write.WriteLine(txt_send.Text);
                m_Write.Flush();

                Message(">>> : " + txt_send.Text);
                txt_send.Text = "";
            }
            catch
            {
                Message("데이터 전송 실패");
            }
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            if (btn_Server.Text == "서버 켜기")
            {
                m_thServer = new Thread(new ThreadStart(ServerStart));
                m_thServer.Start();
                btn_Server.Text = "서버 멈춤";
                btn_Server.ForeColor = Color.Red;

            }
            else
            {
                ServerStop();
                btn_Server.Text = "서버 켜기";
                btn_Server.ForeColor = Color.Black;
            }




        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "서버 연결")
            {
                Connect();
                if (m_bConnect)
                {
                    btn_Connect.Text = "연결 끊기";
                    btn_Connect.ForeColor = Color.Red;
                }
                else
                {
                    Disconnect();
                    btn_Connect.Text = "서버 연결";
                    btn_Connect.ForeColor = Color.Black;
                }
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void txt_send_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send();
        }
    }
}
