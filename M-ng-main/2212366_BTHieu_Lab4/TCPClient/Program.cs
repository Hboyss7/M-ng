using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace TCPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpClient sockClient = new TcpClient("127.0.0.1", 6174);
            Console.WriteLine("Connecting to sever ");
            //Thiết lập kết nối 

            //Khai báo dữ liệu
            NetworkStream ns = sockClient.GetStream();
            byte[] buffer = new byte[1024];
            int recv;

            //Nhận và gửi dữ liệu cố định 
            recv = ns.Read(buffer, 0, buffer.Length);
            string hello = Encoding.ASCII.GetString(buffer, 0, recv);
            Console.WriteLine(hello);

            // Gửi nhiều thông tin
            while (true)
            {
                buffer = new byte[1024];
                recv = ns.Read(buffer, 0, buffer.Length);
                if (recv == 0)
                {
                    break;
                }
                string chuoi = Encoding.ASCII.GetString(buffer, 0, recv);
                Console.WriteLine(chuoi);
            }
            Console.WriteLine("Disconnecting from sever...........");
            ns.Close();
            sockClient.Close();

            
        }
    }
}
