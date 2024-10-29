using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212366_LTM_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        static string GetHostInfo(string host)
        {
            string s = Environment.NewLine;
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);
                //Display host name
                s += "Ten mien: " + hostInfo.HostName + Environment.NewLine;
                //Display list of IP address
                s += "Dia chi IP: ";
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                    s += ipaddr.ToString() + " " + Environment.NewLine;
                }
                s += "\n";
            }

            // Get network interfaces


            catch (Exception ex)
            {
                s += "Khong phan giai duoc ten mien: " + host + "\n" + ex.Message;
            }

            return s;
        }

        private void btnPhanGiai_Click(object sender, EventArgs e)
        {
            string host = txtTenMien.Text;
            txtKQ.Text = GetHostInfo(host);
        }
    }
}
