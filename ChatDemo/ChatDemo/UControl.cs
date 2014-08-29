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
                this.pic_FHeader.Image = this.ffl.fPicList.Images[value.imageIndex];
                this.lab_isopen.Text = value.isopen.ToString();
                //this.ti_ucfriend.Enabled = true;
                //CurFriend.formchat = new FormChat(value);
                CurFriend.formchat = new FormChat(value);
                CurFriend.formchat.lab_name.Text = value.nickName;
                CurFriend.formchat.lab_IP.Text = value.IP.ToString();
                CurFriend.formchat.lab_shuoshuo.Text = value.shuoshuo;
                CurFriend.formchat.pic_image.Image = this.ffl.fPicList.Images[value.imageIndex];
                CurFriend.formchat.lab_name.Text = value.nickName;

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

        private void ti_ucfriend_Tick(object sender, EventArgs e)
        {
            //this.ti_ucfriend.Enabled = true;
            
            if (this.pic_FHeader.Top == 11 && this.pic_FHeader.Left == 11)
            {
                this.pic_FHeader.Top = 58;
                this.pic_FHeader.Left = 58;
                
            }
            if (this.pic_FHeader.Top == 58 && this.pic_FHeader.Left == 58)
            {
                this.pic_FHeader.Top = 10;
                this.pic_FHeader.Left = 10;
            }
            if (this.pic_FHeader.Top == 10 && this.pic_FHeader.Left == 10)
            {
                this.pic_FHeader.Top = 19;
                this.pic_FHeader.Left = 19;
            }
            if (this.pic_FHeader.Top == 19 && this.pic_FHeader.Left == 19)
            {
                this.pic_FHeader.Top = 11;
                this.pic_FHeader.Left = 11;
            }
        }

        //private void UControl_DoubleClick(object sender, EventArgs e)
        //{
        //    FormChat fc = new FormChat(this.lab_FNicName.Text, this.lab_FShuoshuo.Text, this.lab_IP.Text, curFriend.imageIndex.ToString());
        //    fc.Show();
        //}


    }
}
