namespace ChatDemo
{
    partial class UControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic_FHeader = new System.Windows.Forms.PictureBox();
            this.lab_FNicName = new System.Windows.Forms.Label();
            this.lab_FShuoshuo = new System.Windows.Forms.Label();
            this.lab_IP = new System.Windows.Forms.Label();
            this.lab_isopen = new System.Windows.Forms.Label();
            this.ti_ucfriend = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_FHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_FHeader
            // 
            this.pic_FHeader.Location = new System.Drawing.Point(11, 11);
            this.pic_FHeader.Name = "pic_FHeader";
            this.pic_FHeader.Size = new System.Drawing.Size(40, 40);
            this.pic_FHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FHeader.TabIndex = 0;
            this.pic_FHeader.TabStop = false;
            this.pic_FHeader.DoubleClick += new System.EventHandler(this.pic_FHeader_DoubleClick);
            // 
            // lab_FNicName
            // 
            this.lab_FNicName.AutoSize = true;
            this.lab_FNicName.Location = new System.Drawing.Point(73, 11);
            this.lab_FNicName.Name = "lab_FNicName";
            this.lab_FNicName.Size = new System.Drawing.Size(41, 12);
            this.lab_FNicName.TabIndex = 1;
            this.lab_FNicName.Text = "label1";
            // 
            // lab_FShuoshuo
            // 
            this.lab_FShuoshuo.AutoSize = true;
            this.lab_FShuoshuo.Location = new System.Drawing.Point(73, 39);
            this.lab_FShuoshuo.Name = "lab_FShuoshuo";
            this.lab_FShuoshuo.Size = new System.Drawing.Size(41, 12);
            this.lab_FShuoshuo.TabIndex = 1;
            this.lab_FShuoshuo.Text = "label1";
            // 
            // lab_IP
            // 
            this.lab_IP.AutoSize = true;
            this.lab_IP.Location = new System.Drawing.Point(160, 11);
            this.lab_IP.Name = "lab_IP";
            this.lab_IP.Size = new System.Drawing.Size(17, 12);
            this.lab_IP.TabIndex = 2;
            this.lab_IP.Text = "11";
            this.lab_IP.Visible = false;
            // 
            // lab_isopen
            // 
            this.lab_isopen.AutoSize = true;
            this.lab_isopen.Location = new System.Drawing.Point(160, 23);
            this.lab_isopen.Name = "lab_isopen";
            this.lab_isopen.Size = new System.Drawing.Size(41, 12);
            this.lab_isopen.TabIndex = 2;
            this.lab_isopen.Text = "isopen";
            this.lab_isopen.Visible = false;
            // 
            // ti_ucfriend
            // 
            this.ti_ucfriend.Interval = 200;
            this.ti_ucfriend.Tick += new System.EventHandler(this.ti_ucfriend_Tick);
            // 
            // UControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_isopen);
            this.Controls.Add(this.lab_IP);
            this.Controls.Add(this.lab_FShuoshuo);
            this.Controls.Add(this.lab_FNicName);
            this.Controls.Add(this.pic_FHeader);
            this.Name = "UControl";
            this.Size = new System.Drawing.Size(230, 66);
            this.Load += new System.EventHandler(this.UControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_FHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pic_FHeader;
        public System.Windows.Forms.Label lab_FNicName;
        public System.Windows.Forms.Label lab_FShuoshuo;
        public System.Windows.Forms.Label lab_IP;
        public System.Windows.Forms.Label lab_isopen;
        public System.Windows.Forms.Timer ti_ucfriend;
    }
}
