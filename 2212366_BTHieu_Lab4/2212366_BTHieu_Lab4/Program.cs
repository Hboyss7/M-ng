using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Globalization;

namespace _2212366_BTHieu_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener sock = new TcpListener(6174);
            sock.Start();
            Console.WriteLine("Waiting for client");

            TcpClient sockServer = sock.AcceptTcpClient();

            Console.WriteLine("Connecting sucessfully");
            Console.WriteLine(sockServer.Client.RemoteEndPoint.ToString());
            // Thành lập kết nối 

            //Khai báo dữ liệu
            NetworkStream ns = sockServer.GetStream();
            byte[] buffer = new byte[1024];

            // Gửi thông tin cố định
            string hello = "Xin chao client";

            buffer = Encoding.ASCII.GetBytes(hello); // Tách chuỗi thành byte
            ns.Write(buffer, 0, buffer.Length);


            // Gửi nhiều thông tin
            while (true)
            {
                string chuoi = Console.ReadLine();
                
                if (chuoi.Length == 0)
                {
                    break;
                }
                buffer = Encoding.ASCII.GetBytes(chuoi);
                ns.Write(buffer, 0, buffer.Length);
               

            }
            ns.Close();
            sockServer.Close();
            sock.Stop();
           
        }
    }
}
