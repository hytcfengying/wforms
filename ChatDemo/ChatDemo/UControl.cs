using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ChatDemo
{
    public partial class UControl : UserControl
    {
        private FormFriendList ffl;

        public FormFriendList Ffl
        {
            get { return ffl; }
            set { ffl = value; }
        }




        //public Friend curFriend = new Friend();
        private Friend curFriend;

        public Friend CurFriend
        {
            get { return curFriend; }
            set 
            { 
                curFriend = value;
                this.lab_FNicName.Text = value.nickName;
                this.lab_FShuoshuo.Text = value.shuoshuo;
                this.lab_IP.Text = value.IP.ToString();
                //curFriend.imageIndex = ffl.fPicList.Images.
                this.pic_FHeader.Image = this.ffl.fPicList.Images[value.imageIndex];
                this.lab_isopen.Text = value.isopen.ToString();
                //this.pic_FHeader.Image = this.ffl.fPicList.Images[2];
            }
        }

        public UControl()
        {
            InitializeComponent();
        }

        private void UControl_Load(object sender, EventArgs e)
        {

        }

        //private void UControl_DoubleClick(object sender, EventArgs e)
        //{
        //    FormChat fc = new FormChat(this.lab_FNicName.Text, this.lab_FShuoshuo.Text, this.lab_IP.Text, curFriend.imageIndex.ToString());
        //    fc.Show();
        //}


    }
}
