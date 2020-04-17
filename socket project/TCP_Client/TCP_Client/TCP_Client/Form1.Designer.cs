namespace TCP_Client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_receive = new System.Windows.Forms.TextBox();
            this.tb_writeline = new System.Windows.Forms.TextBox();
            this.tb_connect = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(39, 9);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(94, 21);
            this.tb_ip.TabIndex = 0;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(186, 9);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(73, 21);
            this.tb_port.TabIndex = 0;
            this.tb_port.Text = "5000";
            this.tb_port.TextChanged += new System.EventHandler(this.tb_port_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(139, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_receive
            // 
            this.tb_receive.Location = new System.Drawing.Point(12, 36);
            this.tb_receive.Multiline = true;
            this.tb_receive.Name = "tb_receive";
            this.tb_receive.ReadOnly = true;
            this.tb_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_receive.Size = new System.Drawing.Size(339, 268);
            this.tb_receive.TabIndex = 2;
            this.tb_receive.TextChanged += new System.EventHandler(this.tb_receive_TextChanged);
            // 
            // tb_writeline
            // 
            this.tb_writeline.Location = new System.Drawing.Point(12, 310);
            this.tb_writeline.Name = "tb_writeline";
            this.tb_writeline.Size = new System.Drawing.Size(247, 21);
            this.tb_writeline.TabIndex = 0;
            // 
            // tb_connect
            // 
            this.tb_connect.Location = new System.Drawing.Point(265, 9);
            this.tb_connect.Name = "tb_connect";
            this.tb_connect.Size = new System.Drawing.Size(86, 23);
            this.tb_connect.TabIndex = 3;
            this.tb_connect.Text = "서버접속";
            this.tb_connect.UseVisualStyleBackColor = true;
            this.tb_connect.Click += new System.EventHandler(this.tb_connect_Click);
            // 
            // bt_send
            // 
            this.bt_send.Enabled = false;
            this.bt_send.Location = new System.Drawing.Point(265, 310);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(86, 23);
            this.bt_send.TabIndex = 3;
            this.bt_send.Text = "전송";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bt_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 341);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_connect);
            this.Controls.Add(this.tb_receive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_writeline);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_receive;
        private System.Windows.Forms.TextBox tb_writeline;
        private System.Windows.Forms.Button tb_connect;
        private System.Windows.Forms.Button bt_send;
    }
}

