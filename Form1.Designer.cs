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
            this.textBoxServerTerminator = new System.Windows.Forms.TextBox();
            this.comboBoxServerEncoding = new System.Windows.Forms.ComboBox();
            this.labelServerTerminator = new System.Windows.Forms.Label();
            this.labelServerEncoding = new System.Windows.Forms.Label();
            this.labelClientEncoding = new System.Windows.Forms.Label();
            this.labelClientTerminator = new System.Windows.Forms.Label();
            this.comboBoxClientEncoding = new System.Windows.Forms.ComboBox();
            this.textBoxClientTerminator = new System.Windows.Forms.TextBox();
            this.buttonServerClearLog = new System.Windows.Forms.Button();
            this.buttonClientClearLog = new System.Windows.Forms.Button();
            this.buttonServerCopyLog = new System.Windows.Forms.Button();
            this.buttonClientCopyLog = new System.Windows.Forms.Button();
            this.checkBoxServerUseLengthHeader = new System.Windows.Forms.CheckBox();
            this.checkBoxClientUseLengthHeader = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxServerIp
            // 
            this.textBoxServerIp.Location = new System.Drawing.Point(12, 135);
            this.textBoxServerIp.Name = "textBoxServerIp";
            this.textBoxServerIp.Size = new System.Drawing.Size(137, 22);
            this.textBoxServerIp.TabIndex = 1;
            this.textBoxServerIp.Text = "127.0.0.1";
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.Location = new System.Drawing.Point(155, 135);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(50, 22);
            this.textBoxServerPort.TabIndex = 2;
            this.textBoxServerPort.Text = "9999";
            // 
            // textBoxServerMessage
            // 
            this.textBoxServerMessage.Location = new System.Drawing.Point(12, 163);
            this.textBoxServerMessage.Name = "textBoxServerMessage";
            this.textBoxServerMessage.Size = new System.Drawing.Size(276, 22);
            this.textBoxServerMessage.TabIndex = 5;
            // 
            // buttonServerStart
            // 
            this.buttonServerStart.Location = new System.Drawing.Point(213, 134);
            this.buttonServerStart.Name = "buttonServerStart";
            this.buttonServerStart.Size = new System.Drawing.Size(75, 23);
            this.buttonServerStart.TabIndex = 3;
            this.buttonServerStart.Text = "Start";
            this.buttonServerStart.UseVisualStyleBackColor = true;
            this.buttonServerStart.Click += new System.EventHandler(this.buttonServerStart_Click);
            // 
            // buttonServerSendMessage
            // 
            this.buttonServerSendMessage.Location = new System.Drawing.Point(294, 162);
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
            this.listBoxServerLog.Location = new System.Drawing.Point(12, 204);
            this.listBoxServerLog.Name = "listBoxServerLog";
            this.listBoxServerLog.Size = new System.Drawing.Size(357, 276);
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
            this.buttonServerStop.Location = new System.Drawing.Point(294, 135);
            this.buttonServerStop.Name = "buttonServerStop";
            this.buttonServerStop.Size = new System.Drawing.Size(75, 23);
            this.buttonServerStop.TabIndex = 4;
            this.buttonServerStop.Text = "Stop";
            this.buttonServerStop.UseVisualStyleBackColor = true;
            this.buttonServerStop.Click += new System.EventHandler(this.buttonServerStop_Click);
            // 
            // buttonClientDisconnect
            // 
            this.buttonClientDisconnect.Location = new System.Drawing.Point(669, 135);
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
            this.listBoxClientLog.Location = new System.Drawing.Point(387, 204);
            this.listBoxClientLog.Name = "listBoxClientLog";
            this.listBoxClientLog.Size = new System.Drawing.Size(357, 276);
            this.listBoxClientLog.TabIndex = 14;
            // 
            // buttonClientSendMessage
            // 
            this.buttonClientSendMessage.Location = new System.Drawing.Point(669, 162);
            this.buttonClientSendMessage.Name = "buttonClientSendMessage";
            this.buttonClientSendMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonClientSendMessage.TabIndex = 13;
            this.buttonClientSendMessage.Text = "Send";
            this.buttonClientSendMessage.UseVisualStyleBackColor = true;
            this.buttonClientSendMessage.Click += new System.EventHandler(this.buttonClientSendMessage_Click);
            // 
            // buttonClientConnect
            // 
            this.buttonClientConnect.Location = new System.Drawing.Point(588, 134);
            this.buttonClientConnect.Name = "buttonClientConnect";
            this.buttonClientConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonClientConnect.TabIndex = 10;
            this.buttonClientConnect.Text = "Connect";
            this.buttonClientConnect.UseVisualStyleBackColor = true;
            this.buttonClientConnect.Click += new System.EventHandler(this.buttonClientConnect_Click);
            // 
            // textBoxClientMessage
            // 
            this.textBoxClientMessage.Location = new System.Drawing.Point(387, 163);
            this.textBoxClientMessage.Name = "textBoxClientMessage";
            this.textBoxClientMessage.Size = new System.Drawing.Size(276, 22);
            this.textBoxClientMessage.TabIndex = 12;
            // 
            // textBoxClientPort
            // 
            this.textBoxClientPort.Location = new System.Drawing.Point(530, 135);
            this.textBoxClientPort.Name = "textBoxClientPort";
            this.textBoxClientPort.Size = new System.Drawing.Size(50, 22);
            this.textBoxClientPort.TabIndex = 9;
            this.textBoxClientPort.Text = "9999";
            // 
            // textBoxClientIp
            // 
            this.textBoxClientIp.Location = new System.Drawing.Point(387, 135);
            this.textBoxClientIp.Name = "textBoxClientIp";
            this.textBoxClientIp.Size = new System.Drawing.Size(137, 22);
            this.textBoxClientIp.TabIndex = 8;
            this.textBoxClientIp.Text = "127.0.0.1";
            // 
            // textBoxServerTerminator
            // 
            this.textBoxServerTerminator.Location = new System.Drawing.Point(12, 73);
            this.textBoxServerTerminator.Name = "textBoxServerTerminator";
            this.textBoxServerTerminator.Size = new System.Drawing.Size(137, 22);
            this.textBoxServerTerminator.TabIndex = 16;
            this.textBoxServerTerminator.Text = "\\x03";
            // 
            // comboBoxServerEncoding
            // 
            this.comboBoxServerEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServerEncoding.FormattingEnabled = true;
            this.comboBoxServerEncoding.Location = new System.Drawing.Point(155, 73);
            this.comboBoxServerEncoding.Name = "comboBoxServerEncoding";
            this.comboBoxServerEncoding.Size = new System.Drawing.Size(214, 24);
            this.comboBoxServerEncoding.TabIndex = 17;
            // 
            // labelServerTerminator
            // 
            this.labelServerTerminator.AutoSize = true;
            this.labelServerTerminator.Location = new System.Drawing.Point(9, 53);
            this.labelServerTerminator.Name = "labelServerTerminator";
            this.labelServerTerminator.Size = new System.Drawing.Size(77, 17);
            this.labelServerTerminator.TabIndex = 18;
            this.labelServerTerminator.Text = "Terminator";
            // 
            // labelServerEncoding
            // 
            this.labelServerEncoding.AutoSize = true;
            this.labelServerEncoding.Location = new System.Drawing.Point(152, 53);
            this.labelServerEncoding.Name = "labelServerEncoding";
            this.labelServerEncoding.Size = new System.Drawing.Size(67, 17);
            this.labelServerEncoding.TabIndex = 19;
            this.labelServerEncoding.Text = "Encoding";
            // 
            // labelClientEncoding
            // 
            this.labelClientEncoding.AutoSize = true;
            this.labelClientEncoding.Location = new System.Drawing.Point(527, 53);
            this.labelClientEncoding.Name = "labelClientEncoding";
            this.labelClientEncoding.Size = new System.Drawing.Size(67, 17);
            this.labelClientEncoding.TabIndex = 23;
            this.labelClientEncoding.Text = "Encoding";
            // 
            // labelClientTerminator
            // 
            this.labelClientTerminator.AutoSize = true;
            this.labelClientTerminator.Location = new System.Drawing.Point(384, 53);
            this.labelClientTerminator.Name = "labelClientTerminator";
            this.labelClientTerminator.Size = new System.Drawing.Size(77, 17);
            this.labelClientTerminator.TabIndex = 22;
            this.labelClientTerminator.Text = "Terminator";
            // 
            // comboBoxClientEncoding
            // 
            this.comboBoxClientEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientEncoding.FormattingEnabled = true;
            this.comboBoxClientEncoding.Location = new System.Drawing.Point(530, 73);
            this.comboBoxClientEncoding.Name = "comboBoxClientEncoding";
            this.comboBoxClientEncoding.Size = new System.Drawing.Size(214, 24);
            this.comboBoxClientEncoding.TabIndex = 21;
            // 
            // textBoxClientTerminator
            // 
            this.textBoxClientTerminator.Location = new System.Drawing.Point(387, 73);
            this.textBoxClientTerminator.Name = "textBoxClientTerminator";
            this.textBoxClientTerminator.Size = new System.Drawing.Size(137, 22);
            this.textBoxClientTerminator.TabIndex = 20;
            this.textBoxClientTerminator.Text = "\\x03";
            // 
            // buttonServerClearLog
            // 
            this.buttonServerClearLog.Location = new System.Drawing.Point(213, 486);
            this.buttonServerClearLog.Name = "buttonServerClearLog";
            this.buttonServerClearLog.Size = new System.Drawing.Size(75, 23);
            this.buttonServerClearLog.TabIndex = 24;
            this.buttonServerClearLog.Text = "Clear";
            this.buttonServerClearLog.UseVisualStyleBackColor = true;
            this.buttonServerClearLog.Click += new System.EventHandler(this.buttonServerClearLog_Click);
            // 
            // buttonClientClearLog
            // 
            this.buttonClientClearLog.Location = new System.Drawing.Point(588, 486);
            this.buttonClientClearLog.Name = "buttonClientClearLog";
            this.buttonClientClearLog.Size = new System.Drawing.Size(75, 23);
            this.buttonClientClearLog.TabIndex = 25;
            this.buttonClientClearLog.Text = "Clear";
            this.buttonClientClearLog.UseVisualStyleBackColor = true;
            this.buttonClientClearLog.Click += new System.EventHandler(this.buttonClientClearLog_Click);
            // 
            // buttonServerCopyLog
            // 
            this.buttonServerCopyLog.Location = new System.Drawing.Point(294, 486);
            this.buttonServerCopyLog.Name = "buttonServerCopyLog";
            this.buttonServerCopyLog.Size = new System.Drawing.Size(75, 23);
            this.buttonServerCopyLog.TabIndex = 26;
            this.buttonServerCopyLog.Text = "Copy";
            this.buttonServerCopyLog.UseVisualStyleBackColor = true;
            this.buttonServerCopyLog.Click += new System.EventHandler(this.buttonServerCopyLog_Click);
            // 
            // buttonClientCopyLog
            // 
            this.buttonClientCopyLog.Location = new System.Drawing.Point(669, 486);
            this.buttonClientCopyLog.Name = "buttonClientCopyLog";
            this.buttonClientCopyLog.Size = new System.Drawing.Size(75, 23);
            this.buttonClientCopyLog.TabIndex = 27;
            this.buttonClientCopyLog.Text = "Copy";
            this.buttonClientCopyLog.UseVisualStyleBackColor = true;
            this.buttonClientCopyLog.Click += new System.EventHandler(this.buttonClientCopyLog_Click);
            // 
            // checkBoxServerUseLengthHeader
            // 
            this.checkBoxServerUseLengthHeader.AutoSize = true;
            this.checkBoxServerUseLengthHeader.Checked = true;
            this.checkBoxServerUseLengthHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxServerUseLengthHeader.Location = new System.Drawing.Point(12, 102);
            this.checkBoxServerUseLengthHeader.Name = "checkBoxServerUseLengthHeader";
            this.checkBoxServerUseLengthHeader.Size = new System.Drawing.Size(147, 21);
            this.checkBoxServerUseLengthHeader.TabIndex = 28;
            this.checkBoxServerUseLengthHeader.Text = "Use length header";
            this.checkBoxServerUseLengthHeader.UseVisualStyleBackColor = true;
            // 
            // checkBoxClientUseLengthHeader
            // 
            this.checkBoxClientUseLengthHeader.AutoSize = true;
            this.checkBoxClientUseLengthHeader.Checked = true;
            this.checkBoxClientUseLengthHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClientUseLengthHeader.Location = new System.Drawing.Point(387, 102);
            this.checkBoxClientUseLengthHeader.Name = "checkBoxClientUseLengthHeader";
            this.checkBoxClientUseLengthHeader.Size = new System.Drawing.Size(147, 21);
            this.checkBoxClientUseLengthHeader.TabIndex = 29;
            this.checkBoxClientUseLengthHeader.Text = "Use length header";
            this.checkBoxClientUseLengthHeader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 516);
            this.Controls.Add(this.checkBoxClientUseLengthHeader);
            this.Controls.Add(this.checkBoxServerUseLengthHeader);
            this.Controls.Add(this.buttonClientCopyLog);
            this.Controls.Add(this.buttonServerCopyLog);
            this.Controls.Add(this.buttonClientClearLog);
            this.Controls.Add(this.buttonServerClearLog);
            this.Controls.Add(this.labelClientEncoding);
            this.Controls.Add(this.labelClientTerminator);
            this.Controls.Add(this.comboBoxClientEncoding);
            this.Controls.Add(this.textBoxClientTerminator);
            this.Controls.Add(this.labelServerEncoding);
            this.Controls.Add(this.labelServerTerminator);
            this.Controls.Add(this.comboBoxServerEncoding);
            this.Controls.Add(this.textBoxServerTerminator);
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
        private System.Windows.Forms.TextBox textBoxServerTerminator;
        private System.Windows.Forms.ComboBox comboBoxServerEncoding;
        private System.Windows.Forms.Label labelServerTerminator;
        private System.Windows.Forms.Label labelServerEncoding;
        private System.Windows.Forms.Label labelClientEncoding;
        private System.Windows.Forms.Label labelClientTerminator;
        private System.Windows.Forms.ComboBox comboBoxClientEncoding;
        private System.Windows.Forms.TextBox textBoxClientTerminator;
        private System.Windows.Forms.Button buttonServerClearLog;
        private System.Windows.Forms.Button buttonClientClearLog;
        private System.Windows.Forms.Button buttonServerCopyLog;
        private System.Windows.Forms.Button buttonClientCopyLog;
        private System.Windows.Forms.CheckBox checkBoxServerUseLengthHeader;
        private System.Windows.Forms.CheckBox checkBoxClientUseLengthHeader;
    }
}

