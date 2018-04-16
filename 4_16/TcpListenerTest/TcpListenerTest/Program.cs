using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace TcpListenerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            IPAddress locAddr = IPAddress.Parse("127.0.0.1"); int port = 13000;
            try
            {
                server = new TcpListener(locAddr, port);
                server.Start();

                //listening loop
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException:{0}", e);
            }
            finally
            {
                server.Stop();
            }
            Console.WriteLine("\n서버가 종료됩니다.");
            //listening loop
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Conneted!");

                DateTime t = DateTime.Now;
                // string to byte
                string message = string.Format("서버에서 보내는 메세지 {0}", t.ToString("yyyy-MM-dd hh:mm:ss"));
                byte[] wrtieBuffer = Encoding.UTF8.GetBytes(message);

                //int to byte
                int bytes = wrtieBuffer.Length;
                byte[] wrtieBufferSize = BitConverter.GetBytes(bytes);

                //send to client
                NetworkStream stream = client.GetStream();
                stream.Write(wrtieBufferSize, 0, wrtieBufferSize.Length);
                Console.WriteLine("Sent: {0}", message);
                stream.Close();
                client.Close();
                Console.WriteLine();
            }
        }
    }
}

