using Layer4Stack.DataProcessors;
using Layer4Stack.Services;
using System;
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

            // setup server 
            _server = new TcpServerService
            {
                ServerConfig = new Layer4Stack.Models.ServerConfigModel
                {
                    IpAddress = textBoxServerIp.Text,
                    Port = int.Parse(textBoxServerPort.Text)
                },

                DataProcessorConfig = new MessageDataProcessorConfig
                {
                    // todo: get message terminator
                    MessageTerminator = new byte[] { 13 }
                },

                EventHandler = new ServerEventHandler
                {
                    Form = this
                }

            };

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
                string msg = textBoxServerMessage.Text.Trim();
                if(!string.IsNullOrWhiteSpace(msg))
                {
                    _server.SendToAll(Encoding.UTF8.GetBytes(msg));
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

            // setup client
            _client = new TcpClientService
            {
                ClientConfig = new Layer4Stack.Models.ClientConfigModel
                {
                    IpAddress = textBoxClientIp.Text,
                    Port = int.Parse(textBoxClientPort.Text)
                },

                DataProcessorConfig = new MessageDataProcessorConfig
                {
                    // todo: get message terminator
                    MessageTerminator = new byte[] { 13 }
                },

                EventHandler = new ClientEventHandler
                {
                    Form = this
                }

            };

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
                string msg = textBoxClientMessage.Text.Trim();
                if (!string.IsNullOrWhiteSpace(msg))
                {
                    _client.Send(Encoding.UTF8.GetBytes(msg));
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


    }
}
