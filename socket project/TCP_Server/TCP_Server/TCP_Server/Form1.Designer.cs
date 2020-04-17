﻿namespace TCP_Server
{
    partial class Form1
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
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_open = new System.Windows.Forms.Button();
            this.tb_receive = new System.Windows.Forms.TextBox();
            this.tb_writeline = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(39, 9);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(95, 21);
            this.tb_ip.TabIndex = 0;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(187, 9);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(73, 21);
            this.tb_port.TabIndex = 0;
            this.tb_port.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(140, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(266, 9);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(86, 23);
            this.bt_open.TabIndex = 2;
            this.bt_open.Text = "서버접속";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // tb_receive
            // 
            this.tb_receive.Location = new System.Drawing.Point(13, 36);
            this.tb_receive.Multiline = true;
            this.tb_receive.Name = "tb_receive";
            this.tb_receive.ReadOnly = true;
            this.tb_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_receive.Size = new System.Drawing.Size(339, 268);
            this.tb_receive.TabIndex = 3;
            this.tb_receive.TextChanged += new System.EventHandler(this.tb_receive_TextChanged);
            // 
            // tb_writeline
            // 
            this.tb_writeline.Location = new System.Drawing.Point(13, 310);
            this.tb_writeline.Name = "tb_writeline";
            this.tb_writeline.Size = new System.Drawing.Size(247, 21);
            this.tb_writeline.TabIndex = 4;
            this.tb_writeline.TextChanged += new System.EventHandler(this.tb_writeline_TextChanged);
            // 
            // bt_send
            // 
            this.bt_send.Enabled = false;
            this.bt_send.Location = new System.Drawing.Point(266, 310);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(86, 23);
            this.bt_send.TabIndex = 5;
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
            this.Controls.Add(this.tb_writeline);
            this.Controls.Add(this.tb_receive);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Name = "Form1";
            this.Text = "Server";
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
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.TextBox tb_receive;
        private System.Windows.Forms.TextBox tb_writeline;
        private System.Windows.Forms.Button bt_send;
    }
}

