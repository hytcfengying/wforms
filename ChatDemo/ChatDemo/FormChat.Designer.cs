namespace ChatDemo
{
    partial class FormChat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.txt_content = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.lab_shuoshuo = new System.Windows.Forms.Label();
            this.lab_IP = new System.Windows.Forms.Label();
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.cImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(12, 69);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(378, 257);
            this.txt_content.TabIndex = 0;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(12, 356);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(378, 80);
            this.txt_msg.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(231, 442);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 20);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(315, 442);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 20);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lab_shuoshuo
            // 
            this.lab_shuoshuo.AutoSize = true;
            this.lab_shuoshuo.Location = new System.Drawing.Point(75, 40);
            this.lab_shuoshuo.Name = "lab_shuoshuo";
            this.lab_shuoshuo.Size = new System.Drawing.Size(53, 12);
            this.lab_shuoshuo.TabIndex = 2;
            this.lab_shuoshuo.Text = "Shuoshuo";
            // 
            // lab_IP
            // 
            this.lab_IP.AutoSize = true;
            this.lab_IP.Location = new System.Drawing.Point(177, 12);
            this.lab_IP.Name = "lab_IP";
            this.lab_IP.Size = new System.Drawing.Size(83, 12);
            this.lab_IP.TabIndex = 2;
            this.lab_IP.Text = "192.168.1.123";
            // 
            // pic_image
            // 
            this.pic_image.Location = new System.Drawing.Point(12, 12);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(40, 40);
            this.pic_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_image.TabIndex = 3;
            this.pic_image.TabStop = false;
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(75, 12);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(29, 12);
            this.lab_name.TabIndex = 4;
            this.lab_name.Text = "Name";
            // 
            // cImageList
            // 
            this.cImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cImageList.ImageStream")));
            this.cImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cImageList.Images.SetKeyName(0, "0.png");
            this.cImageList.Images.SetKeyName(1, "1.png");
            this.cImageList.Images.SetKeyName(2, "2.png");
            this.cImageList.Images.SetKeyName(3, "3.png");
            this.cImageList.Images.SetKeyName(4, "4.png");
            this.cImageList.Images.SetKeyName(5, "5.png");
            this.cImageList.Images.SetKeyName(6, "6.png");
            this.cImageList.Images.SetKeyName(7, "7.png");
            this.cImageList.Images.SetKeyName(8, "8.png");
            this.cImageList.Images.SetKeyName(9, "9.png");
            this.cImageList.Images.SetKeyName(10, "10.png");
            this.cImageList.Images.SetKeyName(11, "Chogath_Square_0.png");
            this.cImageList.Images.SetKeyName(12, "Corki_Square_0.png");
            this.cImageList.Images.SetKeyName(13, "Darius_Square_0.png");
            this.cImageList.Images.SetKeyName(14, "Diana_Square_0.png");
            this.cImageList.Images.SetKeyName(15, "Draven_Square_0.png");
            this.cImageList.Images.SetKeyName(16, "DrMundo_Square_0.png");
            this.cImageList.Images.SetKeyName(17, "Evelynn_Square_0.png");
            this.cImageList.Images.SetKeyName(18, "Ezreal_Square_0.png");
            this.cImageList.Images.SetKeyName(19, "Fiddlesticks_Square_0.png");
            this.cImageList.Images.SetKeyName(20, "Fiora_Square_0.png");
            this.cImageList.Images.SetKeyName(21, "Fizz_square_0.png");
            this.cImageList.Images.SetKeyName(22, "Galio_Square_0.png");
            this.cImageList.Images.SetKeyName(23, "Gangplank_Square_0.png");
            this.cImageList.Images.SetKeyName(24, "Garen_Square_0.png");
            this.cImageList.Images.SetKeyName(25, "Gragas_Square_0.png");
            this.cImageList.Images.SetKeyName(26, "Graves_Square_0.png");
            this.cImageList.Images.SetKeyName(27, "Hecarim_Square_0.png");
            this.cImageList.Images.SetKeyName(28, "Heimerdinger_Square_0.png");
            this.cImageList.Images.SetKeyName(29, "Irelia_Square_0.png");
            this.cImageList.Images.SetKeyName(30, "Janna_Square_0.png");
            this.cImageList.Images.SetKeyName(31, "JarvanIV_Square_0.png");
            this.cImageList.Images.SetKeyName(32, "Jax_Square_0.png");
            this.cImageList.Images.SetKeyName(33, "Jayce_Square_0.png");
            this.cImageList.Images.SetKeyName(34, "Karma_Square_0.png");
            this.cImageList.Images.SetKeyName(35, "Karthus_Square_0.png");
            this.cImageList.Images.SetKeyName(36, "Kassadin_Square_0.png");
            this.cImageList.Images.SetKeyName(37, "Katarina_Square_0.png");
            this.cImageList.Images.SetKeyName(38, "Kayle_Square_0.png");
            this.cImageList.Images.SetKeyName(39, "Kennen_Square_0.png");
            this.cImageList.Images.SetKeyName(40, "KogMaw_Square_0.png");
            this.cImageList.Images.SetKeyName(41, "Leblanc_Square_0.png");
            this.cImageList.Images.SetKeyName(42, "LeeSin_Square_0.png");
            this.cImageList.Images.SetKeyName(43, "Leona_Square_0.png");
            this.cImageList.Images.SetKeyName(44, "Lulu_Square_0.png");
            this.cImageList.Images.SetKeyName(45, "Lux_Square_0.png");
            this.cImageList.Images.SetKeyName(46, "Malphite_Square_0.png");
            this.cImageList.Images.SetKeyName(47, "Malzahar_Square_0.png");
            this.cImageList.Images.SetKeyName(48, "Maokai_Square_0.png");
            this.cImageList.Images.SetKeyName(49, "MasterYi_Square_0.png");
            this.cImageList.Images.SetKeyName(50, "MissFortune_Square_0.png");
            this.cImageList.Images.SetKeyName(51, "MonkeyKing_Square_0.png");
            this.cImageList.Images.SetKeyName(52, "Mordekaiser_Square_0.png");
            this.cImageList.Images.SetKeyName(53, "Morgana_Square_0.png");
            this.cImageList.Images.SetKeyName(54, "Nasus_Square_0.png");
            this.cImageList.Images.SetKeyName(55, "Nautilus_Square_0.png");
            this.cImageList.Images.SetKeyName(56, "Nidalee_Square_0.png");
            this.cImageList.Images.SetKeyName(57, "Nocturne_Square_0.png");
            this.cImageList.Images.SetKeyName(58, "Nunu_Square_0.png");
            this.cImageList.Images.SetKeyName(59, "Olaf_Square_0.png");
            this.cImageList.Images.SetKeyName(60, "Orianna_Square_0.png");
            this.cImageList.Images.SetKeyName(61, "Pantheon_Square_0.png");
            this.cImageList.Images.SetKeyName(62, "Poppy_Square_0.png");
            this.cImageList.Images.SetKeyName(63, "Rammus_Square_0.png");
            this.cImageList.Images.SetKeyName(64, "Renekton_Square_0.png");
            this.cImageList.Images.SetKeyName(65, "Rengar_Square_0.png");
            this.cImageList.Images.SetKeyName(66, "Riven_Square_0.png");
            this.cImageList.Images.SetKeyName(67, "Rumble_Square_0.png");
            this.cImageList.Images.SetKeyName(68, "Ryze_Square_0.png");
            this.cImageList.Images.SetKeyName(69, "Sejuani_Square_0.png");
            this.cImageList.Images.SetKeyName(70, "Shaco_Square_0.png");
            this.cImageList.Images.SetKeyName(71, "Shen_Square_0.png");
            this.cImageList.Images.SetKeyName(72, "Shyvana_Square_0.png");
            this.cImageList.Images.SetKeyName(73, "Singed_Square_0.png");
            this.cImageList.Images.SetKeyName(74, "Sion_Square_0.png");
            this.cImageList.Images.SetKeyName(75, "Sivir_Square_0.png");
            this.cImageList.Images.SetKeyName(76, "Skarner_Square_0.png");
            this.cImageList.Images.SetKeyName(77, "Sona_Square_0.png");
            this.cImageList.Images.SetKeyName(78, "Soraka_Square_0.png");
            this.cImageList.Images.SetKeyName(79, "Swain_Square_0.png");
            this.cImageList.Images.SetKeyName(80, "Syndra_Square_0.png");
            this.cImageList.Images.SetKeyName(81, "Talon_Square_0.png");
            this.cImageList.Images.SetKeyName(82, "Taric_Square_0.png");
            this.cImageList.Images.SetKeyName(83, "Teemo_Square_0.png");
            this.cImageList.Images.SetKeyName(84, "Tristana_Square_0.png");
            this.cImageList.Images.SetKeyName(85, "Trundle_Square_0.png");
            this.cImageList.Images.SetKeyName(86, "Tryndamere_Square_0.png");
            this.cImageList.Images.SetKeyName(87, "TwistedFate_Square_0.png");
            this.cImageList.Images.SetKeyName(88, "Twitch_Square_0.png");
            this.cImageList.Images.SetKeyName(89, "Udyr_Square_0.png");
            this.cImageList.Images.SetKeyName(90, "Urgot_Square_0.png");
            this.cImageList.Images.SetKeyName(91, "Varus_Square_0.png");
            this.cImageList.Images.SetKeyName(92, "Vayne_Square_0.png");
            this.cImageList.Images.SetKeyName(93, "Veigar_Square_0.png");
            this.cImageList.Images.SetKeyName(94, "Viktor_Square_0.png");
            this.cImageList.Images.SetKeyName(95, "Vladimir_Square_0.png");
            this.cImageList.Images.SetKeyName(96, "Volibear_Square_0.png");
            this.cImageList.Images.SetKeyName(97, "Warwick_Square_0.png");
            this.cImageList.Images.SetKeyName(98, "Xerath_Square_0.png");
            this.cImageList.Images.SetKeyName(99, "XinZhao_Square_0.png");
            this.cImageList.Images.SetKeyName(100, "Yorick_Square_0.png");
            this.cImageList.Images.SetKeyName(101, "Ziggs_Square_0.png");
            this.cImageList.Images.SetKeyName(102, "Zilean_Square_0.png");
            this.cImageList.Images.SetKeyName(103, "Zyra_Square_0.png");
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 471);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.pic_image);
            this.Controls.Add(this.lab_IP);
            this.Controls.Add(this.lab_shuoshuo);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_content);
            this.Name = "FormChat";
            this.Text = "FormChat";
            this.Load += new System.EventHandler(this.FormChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lab_shuoshuo;
        private System.Windows.Forms.Label lab_IP;
        private System.Windows.Forms.PictureBox pic_image;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.ImageList cImageList;
    }
}