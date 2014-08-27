using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ChatDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void btn_send_Click(object sender, EventArgs e)
        {
            string ip = this.txt_ip.Text;

            string msg = "PUBLIC|" + this.txt_chat.Text +"|fy";
            SendMsg(ip, msg);
        }
        //public bool flag = true;
        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any,0);
                //uc.Receive(ref ipep);
                byte[] bmsg = uc.Receive(ref ipep);
                string scontent = Encoding.Default.GetString(bmsg);
                string[] data = scontent.Split('|');
                if (data[0] == "INROOM")
                {
                    this.txt_person.Text += data[1] + "上线了\r\n";
                }
                //if (data[0] == "OUTROOM")
                //{
                //    this.txt_person.Text += data[1] + "下线了\r\n";
                //}
                if (data[0] == "PUBLIC")
                {
                    int l = data.Count();
                    if ( l < 3)
                    {
                        continue;
                    }
                    this.txt_content.Text += data[2] + ":\r\n";
                    this.txt_content.Text += data[1] + "\r\n";
                    
                }
                
                
            }

            
        }

        private void SendMsg(string ipAll, string msgAll)
        {
            UdpClient uc = new UdpClient();
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ipAll), 9527);
            string inmsg = msgAll;
            byte[] binmsg = Encoding.Default.GetBytes(inmsg);
            uc.Send(binmsg, binmsg.Length, ipep);
            this.txt_chat.Text = "";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

            FormMain.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(new ThreadStart(listen));
            //线程休眠100ms
            Thread.Sleep(100);
            //让线程随主窗口关闭而关闭
            th.IsBackground = true;
            th.Start();
            SendMsg("255.255.255.255","INROOM|fy|0|hi");
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SendMsg("255.255.255.255", "OUTROOM|冯莹|192.168.1.123");
            Application.Exit();
            //flag = false;
            //th.Abort();
            
        }
    }
}
