using Layer4Stack.DataProcessors;
using Layer4Stack.DataProcessors.Interfaces;
using Layer4Stack.Models;
using Layer4Stack.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Stack4Demo
{

    /// <summary>
    /// Application form
    /// </summary>
    public partial class Form1 : Form
    {


        /// <summary>
        /// Init form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _instance = this;

            // set encodings to select boxes 
            IDictionary<int, string> encodings = new Dictionary<int, string>();
            int i = 0;
            int defaultIndex = 0;
            foreach (var encoding in Encoding.GetEncodings())
            {
                encodings.Add(encoding.CodePage, encoding.DisplayName);
                if(encoding.CodePage == Encoding.ASCII.CodePage)
                {
                    defaultIndex = i;
                }
                i++;
            }
            comboBoxServerEncoding.DataSource = new BindingSource(encodings, null);
            comboBoxServerEncoding.DisplayMember = "Value";
            comboBoxServerEncoding.ValueMember = "Key";
            comboBoxClientEncoding.DataSource = new BindingSource(encodings, null);
            comboBoxClientEncoding.DisplayMember = "Value";
            comboBoxClientEncoding.ValueMember = "Key";

            // select ascii as defautl
            comboBoxServerEncoding.SelectedIndex = defaultIndex;
            comboBoxClientEncoding.SelectedIndex = defaultIndex;

        }


        /// <summary>
        /// Form instance 
        /// </summary>
        private static Form1 _instance;


        /// <summary>
        /// Server instance
        /// </summary>
        private TcpServerService _server;

        
        /// <summary>
        /// Client instance
        /// </summary>
        private TcpClientService _client;


        /// <summary>
        /// Server encoding
        /// </summary>
        private Encoding _serverEncoding;


        /// <summary>
        /// Client encoding
        /// </summary>
        private Encoding _clientEncoding;


        /// <summary>
        /// Starts the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerStart_Click(object sender, EventArgs e)
        {

            // already running
            if(_server != null)
            {
                return;
            }

            // set encoding
            int codePage = ((KeyValuePair<int, string>)comboBoxServerEncoding.SelectedItem).Key;
            _serverEncoding = Encoding.GetEncoding(codePage);

            // set data processor provider
            IDataProcessorProvider dataProcessorProvider = new DataProcessorProvider<MessageDataProcessor, MessageDataProcessorConfig>(new MessageDataProcessorConfig() {
                MessageTerminator = _serverEncoding.GetBytes(System.Text.RegularExpressions.Regex.Unescape(textBoxServerTerminator.Text)),
                UseLengthHeader = false
            });

            // setup server 
            _server = new TcpServerService(new DataProcessorProvider<MessageDataProcessor, MessageDataProcessorConfig>(
                new MessageDataProcessorConfig()
                {
                    MessageTerminator = _serverEncoding.GetBytes(System.Text.RegularExpressions.Regex.Unescape(textBoxServerTerminator.Text)),
                    UseLengthHeader = checkBoxServerUseLengthHeader.Checked
                }
            ), new ServerEventHandler() {
                Form = this,
                Encoding = _serverEncoding
            }, new ServerConfig() {
                IpAddress = textBoxServerIp.Text,
                Port = int.Parse(textBoxServerPort.Text)
            });
            
            // start server
            _server.Start();

        }


        /// <summary>
        /// Stops server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerStop_Click(object sender, EventArgs e)
        {
            if (_server != null)
            {
                _server.Stop();
                _server = null;
            }
        }


        /// <summary>
        /// Sends a message to all clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerSendMessage_Click(object sender, EventArgs e)
        {
            if(_server != null)
            {
                string msg = textBoxServerMessage.Text;
                if(!string.IsNullOrWhiteSpace(msg))
                {
                    _server.SendToAll(_serverEncoding.GetBytes(msg));
                }
            }
        }


        /// <summary>
        /// Adds a server log item. 
        /// </summary>
        /// <param name="msg"></param>
        public void ServerLog(string msg)
        {
            try
            {
                // delegate is used as different thread is calling the form function
                listBoxServerLog.Invoke(new Action(delegate {
                    listBoxServerLog.Items.Add(msg);
                    listBoxServerLog.TopIndex = listBoxServerLog.Items.Count - 1;
                }));
            }
            catch (ObjectDisposedException) { }
            catch (InvalidOperationException) { }
        }


        /// <summary>
        /// Clears server log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerClearLog_Click(object sender, EventArgs e)
        {
            listBoxServerLog.Items.Clear();
        }


        /// <summary>
        /// Copies server log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerCopyLog_Click(object sender, EventArgs e)
        {
            string msg = (string)listBoxServerLog.SelectedItem;
            if (msg != null)
            {
                System.Windows.Forms.Clipboard.SetText(msg);
            }
        }


        /// <summary>
        /// Connects a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientConnect_Click(object sender, EventArgs e)
        {

            // already running
            if (_client != null)
            {
                return;
            }

            // set encoding
            int codePage = ((KeyValuePair<int, string>)comboBoxClientEncoding.SelectedItem).Key;
            _clientEncoding = Encoding.GetEncoding(codePage);

            // setup client  
            _client = new TcpClientService(new DataProcessorProvider<MessageDataProcessor, MessageDataProcessorConfig>(
                new MessageDataProcessorConfig()
                {
                    MessageTerminator = _clientEncoding.GetBytes(System.Text.RegularExpressions.Regex.Unescape(textBoxClientTerminator.Text)),
                    UseLengthHeader = checkBoxClientUseLengthHeader.Checked
                }
            ), new ClientEventHandler()
            {
                Form = this,
                Encoding = _clientEncoding
            }, new ClientConfig()
            {
                IpAddress = textBoxClientIp.Text,
                Port = int.Parse(textBoxServerPort.Text)
            });

            // connect
            _client.Connect();

        }


        /// <summary>
        /// Disconnects a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientDisconnect_Click(object sender, EventArgs e)
        {

            if(_client != null)
            {
                _client.Disconnect();
                _client = null;
            }

        }


        /// <summary>
        /// Sends a message to the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientSendMessage_Click(object sender, EventArgs e)
        {

            if (_client != null)
            {
                string msg = textBoxClientMessage.Text;
                if (!string.IsNullOrWhiteSpace(msg))
                {
                    _client.Send(_clientEncoding.GetBytes(msg));
                }
            }

        }


        /// <summary>
        /// Adds a client log item. 
        /// </summary>
        /// <param name="msg"></param>
        public void ClientLog(string msg)
        {
            try
            {
                // delegate is used as different thread is calling the form function
                listBoxClientLog.Invoke(new Action(delegate {
                    listBoxClientLog.Items.Add(msg);
                    listBoxClientLog.TopIndex = listBoxClientLog.Items.Count - 1;
                }));
            }
            catch (ObjectDisposedException) { }
            catch (InvalidOperationException) { }
        }


        /// <summary>
        /// Clears client log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientClearLog_Click(object sender, EventArgs e)
        {
            listBoxClientLog.Items.Clear();
        }


        /// <summary>
        /// Copy client log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientCopyLog_Click(object sender, EventArgs e)
        {
            string msg = (string)listBoxClientLog.SelectedItem;
            if (msg != null)
            {
                System.Windows.Forms.Clipboard.SetText(msg);
            }
        }
    }
}
