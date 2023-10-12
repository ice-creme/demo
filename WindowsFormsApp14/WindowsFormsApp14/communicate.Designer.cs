
namespace WindowsFormsApp14
{
    partial class communicate
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
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSendmsg = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.btnclient = new System.Windows.Forms.Button();
            this.btnSaveSet = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textReceivemsg = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(88, 79);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(68, 15);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "客户端IP";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(88, 110);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(52, 15);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "端口号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "发送数据";
            // 
            // textSendmsg
            // 
            this.textSendmsg.Location = new System.Drawing.Point(164, 138);
            this.textSendmsg.Name = "textSendmsg";
            this.textSendmsg.Size = new System.Drawing.Size(511, 25);
            this.textSendmsg.TabIndex = 2;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(164, 107);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(511, 25);
            this.textPort.TabIndex = 4;
            this.textPort.Text = "2000";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(164, 76);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(511, 25);
            this.textIP.TabIndex = 5;
            this.textIP.Text = "127.0.0.1";
            // 
            // btnclient
            // 
            this.btnclient.Location = new System.Drawing.Point(164, 238);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(123, 64);
            this.btnclient.TabIndex = 6;
            this.btnclient.Text = "连接客户端";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.Location = new System.Drawing.Point(551, 238);
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.Size = new System.Drawing.Size(123, 64);
            this.btnSaveSet.TabIndex = 6;
            this.btnSaveSet.Text = "保存设置";
            this.btnSaveSet.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(293, 238);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(123, 64);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "发送数据";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "接收数据";
            // 
            // textReceivemsg
            // 
            this.textReceivemsg.Location = new System.Drawing.Point(164, 169);
            this.textReceivemsg.Name = "textReceivemsg";
            this.textReceivemsg.Size = new System.Drawing.Size(511, 25);
            this.textReceivemsg.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(422, 238);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(123, 64);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "清空数据";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // communicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.btnSaveSet);
            this.Controls.Add(this.btnclient);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textReceivemsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSendmsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIP);
            this.Name = "communicate";
            this.Text = "通讯";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textIP;
        public System.Windows.Forms.Button btnclient;
        public System.Windows.Forms.Button btnSaveSet;
        public System.Windows.Forms.Button buttonSend;
        public System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.TextBox textSendmsg;
        public System.Windows.Forms.TextBox textReceivemsg;
    }
}