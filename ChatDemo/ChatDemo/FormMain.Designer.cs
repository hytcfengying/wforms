namespace ChatDemo
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.txt_chat = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_person = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(29, 12);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(376, 21);
            this.txt_ip.TabIndex = 0;
            this.txt_ip.Text = "255.255.255.255";
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(29, 39);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_content.Size = new System.Drawing.Size(376, 260);
            this.txt_content.TabIndex = 1;
            // 
            // txt_chat
            // 
            this.txt_chat.Location = new System.Drawing.Point(29, 315);
            this.txt_chat.Name = "txt_chat";
            this.txt_chat.Size = new System.Drawing.Size(376, 21);
            this.txt_chat.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(336, 355);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(69, 21);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_person
            // 
            this.txt_person.Location = new System.Drawing.Point(423, 11);
            this.txt_person.Multiline = true;
            this.txt_person.Name = "txt_person";
            this.txt_person.Size = new System.Drawing.Size(156, 364);
            this.txt_person.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 390);
            this.Controls.Add(this.txt_person);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_chat);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.txt_ip);
            this.Name = "FormMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.TextBox txt_chat;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_person;
    }
}

