using Layer4Stack.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
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
        /// Service provider
        /// </summary>
        private readonly IServiceProvider _provider;

        /// <summary>
        /// Server instance
        /// </summary>
        public TcpServerService Server { get; private set; }

        /// <summary>
        /// Client instance
        /// </summary>
        private TcpClientService _client;

        /// <summary>
        /// Client encoding
        /// </summary>
        public Encoding ClientEncoding { get; private set; }

        /// <summary>
        /// Server port
        /// </summary>
        public int ServerPort  => int.Parse(textBoxServerPort.Text);

        /// <summary>
        /// Server use length header
        /// </summary>
        public bool ServerUseLengthHeader => checkBoxServerUseLengthHeader.Checked;

        /// <summary>
        /// Server message terminator
        /// </summary>
        public byte[] ServerMsgTerminator =>ServerEncoding.GetBytes(System.Text.RegularExpressions.Regex.Unescape(textBoxServerTerminator.Text));

        /// <summary>
        /// Client host 
        /// </summary>
        public string ClientHost => textBoxClientIp.Text;

        /// <summary>
        /// Client posrt 
        /// </summary>
        public int ClientPort => int.Parse(textBoxClientPort.Text);

        /// <summary>
        /// Client use length header
        /// </summary>
        public bool ClientUseLengthHeader => checkBoxClientUseLengthHeader.Checked;

        /// <summary>
        /// Client message terminator
        /// </summary>
        public byte[] ClientMsgTerminator => ClientEncoding.GetBytes(System.Text.RegularExpressions.Regex.Unescape(textBoxClientTerminator.Text));

        /// <summary>
        /// Server encoding
        /// </summary>
        public Encoding ServerEncoding { get; private set; }

        /// <summary>
        /// Constructor with provider
        /// </summary>
        /// <param name="provider"></param>
        public Form1(IServiceProvider provider)
        {
            _provider = provider;
            InitializeComponent();

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
        /// Starts the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerStart_Click(object sender, EventArgs e)
        {

            // already running
            if(Server != null)
            {
                return;
            }

            // check port numeric
            int port;
            if(!int.TryParse(textBoxServerPort.Text, out port))
            {
                MessageBox.Show("Port must be numeric.", "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // set encoding
            int codePage = ((KeyValuePair<int, string>)comboBoxServerEncoding.SelectedItem).Key;
            ServerEncoding = Encoding.GetEncoding(codePage);

            // create server 
            Server = _provider.GetService<TcpServerService>();
            
            // start server
            Server.StartAsync();

        }

        /// <summary>
        /// Stops server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerStop_Click(object sender, EventArgs e)
        {
            if (Server != null)
            {
                Server.Stop();
                Server = null;
            }
        }

        /// <summary>
        /// Sends a message to all clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonServerSendMessage_Click(object sender, EventArgs e)
        {
            if(Server != null)
            {
                string msg = textBoxServerMessage.Text;
                if(!string.IsNullOrWhiteSpace(msg))
                {
                    Server.SendToAllAsync(ServerEncoding.GetBytes(msg));
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

            // check port numeric
            int port;
            if (!int.TryParse(textBoxClientPort.Text, out port))
            {
                MessageBox.Show("Port must be numeric.", "Configuration error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // set encoding
            int codePage = ((KeyValuePair<int, string>)comboBoxClientEncoding.SelectedItem).Key;
            ClientEncoding = Encoding.GetEncoding(codePage);

            // setup client  
            _client = _provider.GetService<TcpClientService>();

            // connect
            _client.ConnectAsync();

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
                    _client.SendAsync(ClientEncoding.GetBytes(msg));
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
