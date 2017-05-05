namespace Stack4Demo
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
            this.textBoxServerIp = new System.Windows.Forms.TextBox();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.textBoxServerMessage = new System.Windows.Forms.TextBox();
            this.buttonServerStart = new System.Windows.Forms.Button();
            this.buttonServerSendMessage = new System.Windows.Forms.Button();
            this.listBoxServerLog = new System.Windows.Forms.ListBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.buttonServerStop = new System.Windows.Forms.Button();
            this.buttonClientDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxClientLog = new System.Windows.Forms.ListBox();
            this.buttonClientSendMessage = new System.Windows.Forms.Button();
            this.buttonClientConnect = new System.Windows.Forms.Button();
            this.textBoxClientMessage = new System.Windows.Forms.TextBox();
            this.textBoxClientPort = new System.Windows.Forms.TextBox();
            this.textBoxClientIp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxServerIp
            // 
            this.textBoxServerIp.Location = new System.Drawing.Point(12, 59);
            this.textBoxServerIp.Name = "textBoxServerIp";
            this.textBoxServerIp.Size = new System.Drawing.Size(137, 22);
            this.textBoxServerIp.TabIndex = 1;
            this.textBoxServerIp.Text = "127.0.0.1";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(155, 59);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(50, 22);
            this.textBoxServerPort.TabIndex = 2;
            this.textBoxServerPort.Text = "9999";
            // 
            // textBoxServerMessage
            // 
            this.textBoxServerMessage.Location = new System.Drawing.Point(12, 87);
            this.textBoxServerMessage.Name = "textBoxServerMessage";
            this.textBoxServerMessage.Size = new System.Drawing.Size(276, 22);
            this.textBoxServerMessage.TabIndex = 5;
            // 
            // buttonServerStart
            // 
            this.buttonServerStart.Location = new System.Drawing.Point(213, 58);
            this.buttonServerStart.Name = "buttonServerStart";
            this.buttonServerStart.Size = new System.Drawing.Size(75, 23);
            this.buttonServerStart.TabIndex = 3;
            this.buttonServerStart.Text = "Start";
            this.buttonServerStart.UseVisualStyleBackColor = true;
            this.buttonServerStart.Click += new System.EventHandler(this.buttonServerStart_Click);
            // 
            // buttonServerSendMessage
            // 
            this.buttonServerSendMessage.Location = new System.Drawing.Point(294, 86);
            this.buttonServerSendMessage.Name = "buttonServerSendMessage";
            this.buttonServerSendMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonServerSendMessage.TabIndex = 6;
            this.buttonServerSendMessage.Text = "Send";
            this.buttonServerSendMessage.UseVisualStyleBackColor = true;
            this.buttonServerSendMessage.Click += new System.EventHandler(this.buttonServerSendMessage_Click);
            // 
            // listBoxServerLog
            // 
            this.listBoxServerLog.FormattingEnabled = true;
            this.listBoxServerLog.ItemHeight = 16;
            this.listBoxServerLog.Location = new System.Drawing.Point(12, 128);
            this.listBoxServerLog.Name = "listBoxServerLog";
            this.listBoxServerLog.Size = new System.Drawing.Size(357, 212);
            this.listBoxServerLog.TabIndex = 7;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer.Location = new System.Drawing.Point(12, 9);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(70, 25);
            this.labelServer.TabIndex = 7;
            this.labelServer.Text = "Server";
            // 
            // buttonServerStop
            // 
            this.buttonServerStop.Location = new System.Drawing.Point(294, 59);
            this.buttonServerStop.Name = "buttonServerStop";
            this.buttonServerStop.Size = new System.Drawing.Size(75, 23);
            this.buttonServerStop.TabIndex = 4;
            this.buttonServerStop.Text = "Stop";
            this.buttonServerStop.UseVisualStyleBackColor = true;
            this.buttonServerStop.Click += new System.EventHandler(this.buttonServerStop_Click);
            // 
            // buttonClientDisconnect
            // 
            this.buttonClientDisconnect.Location = new System.Drawing.Point(669, 59);
            this.buttonClientDisconnect.Name = "buttonClientDisconnect";
            this.buttonClientDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDisconnect.TabIndex = 11;
            this.buttonClientDisconnect.Text = "Disconnect";
            this.buttonClientDisconnect.UseVisualStyleBackColor = true;
            this.buttonClientDisconnect.Click += new System.EventHandler(this.buttonClientDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Client";
            // 
            // listBoxClientLog
            // 
            this.listBoxClientLog.FormattingEnabled = true;
            this.listBoxClientLog.ItemHeight = 16;
            this.listBoxClientLog.Location = new System.Drawing.Point(387, 128);
            this.listBoxClientLog.Name = "listBoxClientLog";
            this.listBoxClientLog.Size = new System.Drawing.Size(357, 212);
            this.listBoxClientLog.TabIndex = 14;
            // 
            // buttonClientSendMessage
            // 
            this.buttonClientSendMessage.Location = new System.Drawing.Point(669, 86);
            this.buttonClientSendMessage.Name = "buttonClientSendMessage";
            this.buttonClientSendMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonClientSendMessage.TabIndex = 13;
            this.buttonClientSendMessage.Text = "Send";
            this.buttonClientSendMessage.UseVisualStyleBackColor = true;
            this.buttonClientSendMessage.Click += new System.EventHandler(this.buttonClientSendMessage_Click);
            // 
            // buttonClientConnect
            // 
            this.buttonClientConnect.Location = new System.Drawing.Point(588, 58);
            this.buttonClientConnect.Name = "buttonClientConnect";
            this.buttonClientConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonClientConnect.TabIndex = 10;
            this.buttonClientConnect.Text = "Connect";
            this.buttonClientConnect.UseVisualStyleBackColor = true;
            this.buttonClientConnect.Click += new System.EventHandler(this.buttonClientConnect_Click);
            // 
            // textBoxClientMessage
            // 
            this.textBoxClientMessage.Location = new System.Drawing.Point(387, 87);
            this.textBoxClientMessage.Name = "textBoxClientMessage";
            this.textBoxClientMessage.Size = new System.Drawing.Size(276, 22);
            this.textBoxClientMessage.TabIndex = 12;
            // 
            // textBoxClientPort
            // 
            this.textBoxClientPort.Location = new System.Drawing.Point(530, 59);
            this.textBoxClientPort.Name = "textBoxClientPort";
            this.textBoxClientPort.Size = new System.Drawing.Size(50, 22);
            this.textBoxClientPort.TabIndex = 9;
            this.textBoxClientPort.Text = "9999";
            // 
            // textBoxClientIp
            // 
            this.textBoxClientIp.Location = new System.Drawing.Point(387, 59);
            this.textBoxClientIp.Name = "textBoxClientIp";
            this.textBoxClientIp.Size = new System.Drawing.Size(137, 22);
            this.textBoxClientIp.TabIndex = 8;
            this.textBoxClientIp.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 355);
            this.Controls.Add(this.buttonClientDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxClientLog);
            this.Controls.Add(this.buttonClientSendMessage);
            this.Controls.Add(this.buttonClientConnect);
            this.Controls.Add(this.textBoxClientMessage);
            this.Controls.Add(this.textBoxClientPort);
            this.Controls.Add(this.textBoxClientIp);
            this.Controls.Add(this.buttonServerStop);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.listBoxServerLog);
            this.Controls.Add(this.buttonServerSendMessage);
            this.Controls.Add(this.buttonServerStart);
            this.Controls.Add(this.textBoxServerMessage);
            this.Controls.Add(this.textBoxServerPort);
            this.Controls.Add(this.textBoxServerIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tcp Client Server Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServerIp;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.TextBox textBoxServerMessage;
        private System.Windows.Forms.Button buttonServerStart;
        private System.Windows.Forms.Button buttonServerSendMessage;
        private System.Windows.Forms.ListBox listBoxServerLog;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Button buttonServerStop;
        private System.Windows.Forms.Button buttonClientDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxClientLog;
        private System.Windows.Forms.Button buttonClientSendMessage;
        private System.Windows.Forms.Button buttonClientConnect;
        private System.Windows.Forms.TextBox textBoxClientMessage;
        private System.Windows.Forms.TextBox textBoxClientPort;
        private System.Windows.Forms.TextBox textBoxClientIp;
    }
}

