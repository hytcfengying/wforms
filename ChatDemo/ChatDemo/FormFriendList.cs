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
    public partial class FormFriendList : Form
    {
        public FormFriendList()
        {
            InitializeComponent();
        }

        public void fuc_DoubleClick(object sender, EventArgs e)
        {
            UControl fuc = (UControl)sender;
            if (fuc.CurFriend.isopen == true)
            {
                return;
            }
            FormChat fc = new FormChat(fuc.CurFriend);
            
            //Operation oper = new Operation();
            //oper.getFriendList(fuc.CurFriend)
            fuc.CurFriend.isopen = true;
            fc.Show();
        }
        //private Thread th;
        private void FormFriendList_Load(object sender, EventArgs e)
        {
            
            Operation oper = new Operation(this);
            
            FormMain.CheckForIllegalCrossThreadCalls = false;

            Thread th = new Thread(new ThreadStart(oper.listen));

            //线程休眠100ms
            Thread.Sleep(100);

            //让线程随主窗口关闭而关闭
            th.IsBackground = true;

            th.Start();

            oper.SendMsg("255.255.255.255", "LOGIN|"+ oper.GetMyIP() +"|0|hi");

           

            
        }

        
        private void FormFriendList_FormClosing(object sender, FormClosingEventArgs e)
        {
            

            Operation oper = new Operation(this);
            oper.SendMsg("255.255.255.255", "LOGOUT");

        }

    }
}
