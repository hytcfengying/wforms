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

        //private FormChat fc;

        //public FormChat Fc
        //{
        //    get { return fc; }
        //    set {
        //        fc = CurFriend;
                
        //    }
        //}




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
                //FormChat fc = value.formchat;
                CurFriend.formchat = new FormChat(value);
                //cfc.lab_name.Text = "";
                //cfc.lab_IP.Text = "192.168.1.35";
                //cfc.lab_shuoshuo.Text = "";
                //cfc.pic_image.Image = this.ffl.fPicList.Images[3];
                CurFriend.formchat.lab_name.Text = value.nickName;
                CurFriend.formchat.lab_IP.Text = value.IP.ToString();
                CurFriend.formchat.lab_shuoshuo.Text = value.shuoshuo;
                //cfc.pic_image = value.imageIndex;
                CurFriend.formchat.pic_image.Image = this.ffl.fPicList.Images[value.imageIndex];
                CurFriend.formchat.lab_name.Text = value.nickName;
                
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

        private void pic_FHeader_DoubleClick(object sender, EventArgs e)
        {

        }

        //private void UControl_DoubleClick(object sender, EventArgs e)
        //{
        //    FormChat fc = new FormChat(this.lab_FNicName.Text, this.lab_FShuoshuo.Text, this.lab_IP.Text, curFriend.imageIndex.ToString());
        //    fc.Show();
        //}


    }
}
