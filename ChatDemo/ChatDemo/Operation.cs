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

        public Operation(FormFriendList ffl)
        {
            _ffl = ffl;
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
            Listfriend.Add(friend);
            //双击事件
            fuc.DoubleClick += new EventHandler(_ffl.fuc_DoubleClick);
            fuc.Top = _ffl.pn_FriendList.Controls.Count * fuc.Height;

            //List<Friend> lf = new List<Friend>();
            //lf

            _ffl.pn_FriendList.Controls.Add(fuc);

        }
        public delegate void delucfclose(IPAddress ip);
        /// <summary>
        /// 代理移除好友
        /// </summary>
        /// <param name="ipAll"></param>
        /// <param name="msgAll"></param>
        public void ucfclose(IPAddress ip)
        {
            IPAddress ipa = ip;
            int slength = Listfriend.Count;
            for (int i = 0; i < slength; i++)
            {
                if (ip.ToString() == Listfriend[i].IP.ToString())
                {
                    Listfriend.RemoveAt(i);
                    _ffl.pn_FriendList.Controls.RemoveAt(i);
                }

            }
            _ffl.pn_FriendList.Controls.Clear();

            

        }


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
        /// <summary>
        /// list
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        //public List<Friend> lf;
        //public List<Friend> getFriendList(Friend f)
        //{
            
        //    lfriend.Add(f);
        //}

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



                        
                        




                        object[] paraLogin = new object[1];

                        paraLogin[0] = fLogin;

                        _ffl.Invoke(new delucfshow(this.ucfshow), paraLogin);

                        SendMsg(fLogin.IP.ToString(), "ALSOON|" + GetMyIP().ToString() + "|0|hi");

                        break;


                    //判断下线
                    case "LOGOUT":

                        
                        if (ip == GetMyIP().ToString())
                        {
                            continue;
                        }

                        Friend fLogout = new Friend();

                        fLogout.IP = IPAddress.Parse(ip);


 
                        object[] paraLogout = new object[1];
                        paraLogout[0] = fLogout.IP;
                        _ffl.Invoke(new delucfclose(this.ucfclose), paraLogout);


                        
                        
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
                        //MessageBox.Show(data[2]);
                        //判断传来的头像是不是存在
                        //if (Convert.ToInt32(data[2]) < 0 || Convert.ToInt32(data[2]) > this.fPicList.Images.Count)
                        //{
                        //    continue;
                        //}

                        fAlsoon.imageIndex = Convert.ToInt32(data[2]);

                        //object[] para = new Object[1];
                        object[] paraAlsoon = new object[1];
                        paraAlsoon[0] = fAlsoon;
                        _ffl.Invoke(new delucfshow(this.ucfshow), paraAlsoon);

                        break;

                    case "MSG":
                        if (data.Length < 2)
                        {
                            continue;
                        }


                        break;

                    default:
                        break;
                }
            }
        }
    }
}
