using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatDemo
{
    public partial class FormChat : Form
    {
       
        public FormChat()
        {
            InitializeComponent();
        }
        string name;
        string shuoshuo;
        IPAddress ip;
        int imageIndex;
        bool isopen;

        public FormChat(Friend f)
            
        {
          
            name = f.nickName;
            shuoshuo = f.shuoshuo;
            ip = f.IP;
            imageIndex = f.imageIndex;
            isopen = f.isopen;
            InitializeComponent();
        }
        

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            
           
        }
        
        private void btn_send_Click(object sender, EventArgs e)
        {
            UdpClient uc = new UdpClient();
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(this.lab_IP.Text.ToString()),9527);
            byte[] bmsg = Encoding.Default.GetBytes(this.txt_msg.Text);
            uc.Send(bmsg,bmsg.Length,ipep);
            string timetoday = DateTime.Now.ToString() + "\r\n";
            string[] timenow = timetoday.Split(' ');
            this.txt_content.Text += "我" + ' ' + timenow[1];
            this.txt_content.Text += this.txt_msg.Text + "\r\n";
            this.txt_msg.Text = "";
        }
        
        private void FormChat_Load(object sender, EventArgs e)
        {
            //this.lab_name.Text = _friendInfo.nickName;
            //this.lab_shuoshuo.Text = _friendInfo.shuoshuo;
            //this.lab_IP.Text = _friendInfo.IP.ToString();
            //this.pic_image.Image = this.cImageList.Images[_friendInfo.imageIndex];
            //this.Name = "与" + _friendInfo.nickName + "聊天中";


            this.lab_name.Text = name;
            this.lab_shuoshuo.Text = shuoshuo;
            this.lab_IP.Text = ip.ToString();
            this.pic_image.Image = this.cImageList.Images[imageIndex];
            this.Name = "与" + name + "聊天中";
            
        }
    }
}
