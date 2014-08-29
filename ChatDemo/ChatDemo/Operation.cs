using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatDemo
{
    public class Operation
    {
        private FormFriendList _ffl;

        private FormChat _fc;

        public Operation(FormFriendList ffl,FormChat fc)
        {
            _ffl = ffl;

            _fc = fc;
        }
        public Operation()
        {
           
        }
        static List<Friend> Listfriend = new List<Friend>();
        //定义委托
        public delegate void delucfshow(Friend friend);
        /// <summary>
        /// 代理添加好友
        /// </summary>
        /// <param name="ipAll"></param>
        /// <param name="msgAll"></param>
        public void ucfshow(Friend friend)
        {
            
            //FormFriendList ffl = this;
            UControl fuc = new UControl();

            fuc.Ffl = _ffl;

            fuc.CurFriend = friend;
            //fuc.for = _fc;

            Listfriend.Add(friend);
            
            
            //双击事件
            fuc.DoubleClick += new EventHandler(_ffl.fuc_DoubleClick);

            fuc.Top = _ffl.pn_FriendList.Controls.Count * fuc.Height;
            fuc.ti_ucfriend.Enabled = true;
            _ffl.pn_FriendList.Controls.Add(fuc);
            
        }
        //public delegate void delucfclose(IPAddress ip);
        ///// <summary>
        ///// 代理移除好友
        ///// </summary>
        ///// <param name="ipAll"></param>
        ///// <param name="msgAll"></param>
        //public void ucfclose(IPAddress ip)
        //{
        //    IPAddress ipa = ip;
        //    //int slength = Listfriend.Count;
        //    for (int i = 0; i < Listfriend.Count; i++)
        //    {
        //        if (ip.ToString() == Listfriend[i].IP.ToString())
        //        {
        //            Listfriend.RemoveAt(i);
        //            _ffl.pn_FriendList.Controls.RemoveAt(i);
        //        }

        //    }
        //    _ffl.pn_FriendList.Controls.Clear();

        //    UControl fuc = new UControl();
        //    for (int i = 0; i < Listfriend.Count; i++) 
        //    {
        //        fuc.CurFriend = Listfriend[i].friend;
        //        _ffl.pn_FriendList.Controls.Add(fuc);

        //    }

        //}


        //获得本机IPv4
        
        public IPAddress GetMyIP()
        {
            //ipa = Dns.GetHostAddresses(Dns.GetHostName()).Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First();
            //return ipa;
            IPAddress myIP=null;

            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());

            foreach ( IPAddress ip in ips )
            {
                if (ip.AddressFamily==AddressFamily.InterNetwork)
                {
                    myIP=ip;
                }
            }
            return myIP;
        }

        //发送消息
        public void SendMsg(string ipAll, string msgAll)
        {
            UdpClient uc = new UdpClient();

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ipAll), 9527);

            string inmsg = msgAll;

            byte[] binmsg = Encoding.Default.GetBytes(inmsg);

            uc.Send(binmsg, binmsg.Length, ipep);

        }

        //监听程序
        public void listen()
        {
            
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);

                byte[] bmsg = uc.Receive(ref ipep);

                string ip = ipep.Address.ToString();

                string scontent = Encoding.Default.GetString(bmsg);

                string[] data = scontent.Split('|');

                string msgStr = data[0];

                switch (msgStr)
                {
                    //判断是不是登录
                    case "LOGIN":

                        if (data.Length < 4)
                        {
                            continue;
                        }

                        //if (ip[0] == GetMyIP().ToString())
                        if (ip == GetMyIP().ToString())
                        {
                            continue;
                        }

                        Friend fLogin = new Friend();

                        fLogin.nickName = data[1];

                        fLogin.shuoshuo = data[3];

                        fLogin.IP = IPAddress.Parse(ip);

                        if (Convert.ToInt32(data[2]) < 0 || Convert.ToInt32(data[2]) > _ffl.fPicList.Images.Count)
                        {
                            continue;
                        }

                        fLogin.imageIndex = Convert.ToInt32(data[2]);

                        //fLogin.formchat = new FormChat(fLogin);

                        object[] paraLogin = new object[1];

                        paraLogin[0] = fLogin;

                        _ffl.Invoke(new delucfshow(this.ucfshow), paraLogin);

                        SendMsg(fLogin.IP.ToString(), "ALSOON|" + GetMyIP().ToString() + "|0|hi");

                        break;


                    //判断下线
                    case "LOGOUT":
                        //删除下线好友的控件
                        int lofucIndex = 0;
                        foreach (UControl lofuc in _ffl.pn_FriendList.Controls)
                        {
                            for (int i = 0; i < _ffl.pn_FriendList.Controls.Count; i++)
                            {
                                _ffl.pn_FriendList.Controls.Remove(lofuc);
                                break;
                            }
                            lofucIndex++;
                        }
                        //foreach (UControl lofuc in _ffl.pn_FriendList.Controls)
                        //{
                            for (int i = lofucIndex; i < _ffl.pn_FriendList.Controls.Count; i++)
                            {
                                _ffl.pn_FriendList.Controls[i].Top = _ffl.pn_FriendList.Controls[0].Height * i;
                                
                            }
                        //}

                            //if (ip == GetMyIP().ToString())
                            //{
                            //    continue;
                            //}

                            //Friend fLogout = new Friend();

                            //fLogout.IP = IPAddress.Parse(ip);

                            //object[] paraLogout = new object[1];

                            //paraLogout[0] = fLogout.IP;

                            //_ffl.Invoke(new delucfclose(this.ucfclose), paraLogout);

                        break;

                    //判断是不是已经登录
                    case "ALSOON":
                        if (data.Length < 4)
                        {
                            continue;
                        }

                        Friend fAlsoon = new Friend();

                        fAlsoon.nickName = data[1];

                        fAlsoon.shuoshuo = data[3];

                        fAlsoon.IP = IPAddress.Parse(ip);
                        
                        fAlsoon.imageIndex = Convert.ToInt32(data[2]);

                        object[] paraAlsoon = new object[1];

                        paraAlsoon[0] = fAlsoon;

                        _ffl.Invoke(new delucfshow(this.ucfshow), paraAlsoon);

                        break;

                    case "MSG":
                        if (data.Length < 2)
                        {
                            continue;
                        }
                        //foreach (UControl msgfuc in _ffl.pn_FriendList.Controls)
                        //{
                        //    for (int i = 0; i < _ffl.pn_FriendList.Controls.Count; i++)
                        //    {
                        //        //_fc = msgfuc;
                        //        //_ffl.pn_FriendList.Controls[i].
                        //        msgfuc.CurFriend.formchat.txt_content.Text += msgfuc.CurFriend.formchat.lab_name.Text + ":\r\n";
                        //        msgfuc.CurFriend.formchat.txt_content.Text += data[1] + "\r\n";
                        //        break;
                        //        //_fc.txt_content.Text += data[1] + "\r\n";
                        //    }
                        //}
                        foreach (UControl msgfuc in _ffl.pn_FriendList.Controls)
                        {
                            if (msgfuc.CurFriend.IP.ToString() == ip)
                            {
                                msgfuc.ti_ucfriend.Enabled = true;
                                msgfuc.CurFriend.formchat.txt_content.Text += msgfuc.CurFriend.formchat.lab_name.Text + ":\r\n";
                                msgfuc.CurFriend.formchat.txt_content.Text += data[1] + "\r\n";
                                break;
                            }
                        }

                        break;

                    default:

                        break;
                }
            }
        }
    }
}
