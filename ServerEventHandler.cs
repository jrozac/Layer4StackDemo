using Layer4Stack.Handlers.Interfaces;
using Layer4Stack.Models;
using System;
using System.Text;

namespace Stack4Demo
{
    /// <summary>
    /// Server event handler
    /// </summary>
    public class ServerEventHandler : IServerEventHandler
    {

        /// <summary>
        /// Encoding
        /// </summary>
        private readonly Encoding _encoding;

        /// <summary>
        /// Form 
        /// </summary>
        private readonly Form1 _form;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="form"></param>
        public ServerEventHandler(Form1 form)
        {
            _form = form;
            _encoding = form.ServerEncoding;
        }

        /// <summary>
        /// It displays a new client connected message.
        /// </summary>
        /// <param name="info"></param>
        public void HandleClientConnected(ClientInfo info)
        {
            _form.ServerLog(string.Format("Client {0} with IP {1} connected on port {2}.", info.Id.Substring(0,5), info.IpAddress, info.Port));
        }

        /// <summary>
        /// It displays a client disconnected message.
        /// </summary>
        /// <param name="info"></param>
        public void HandleClientDisconnected(ClientInfo info)
        {
            _form.ServerLog(string.Format("Client {0} with IP {1} disconnected on port {2}.", info.Id.Substring(0, 5), info.IpAddress, info.Port));
        }

        /// <summary>
        /// Handles received data.
        /// It disconnects a client if "exit" received.
        /// It stops the server if "stop" recieved.
        /// In all other cases it reverses the string and sends it back to client.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public byte[] HandleReceivedData(DataContainer data)
        {
            // log received message 
            string msg = _encoding.GetString(data.Payload);
            _form.ServerLog(string.Format("A message '{0}' was received from client {1}.", msg, data.ClientId.Substring(0,5)));

            // disconnect client if exit received 
            if (msg.Trim().ToLowerInvariant() == "exit")
            {
                _form.Server?.DisconnectClient(data.ClientId);
                return null;
            }

            // stop server if stop received
            if (msg.Trim().ToLowerInvariant() == "stop")
            {
                _form.Server?.Stop();
                return null;
            }

            // reverse message 
            char[] charArray = msg.ToCharArray();
            Array.Reverse(charArray);
            msg = new string(charArray);

            // send reversed
            _form.Server?.SendToClient(data.ClientId, _encoding.GetBytes(msg));
            return null;
        }

        /// <summary>
        /// Displays received data.
        /// </summary>
        /// <param name="data"></param>
        public void HandleSentData(DataContainer data)
        {
            string msg = _encoding.GetString(data.Payload);
            _form.ServerLog(string.Format("A message '{0}' was sent to client {1}.", msg, data.ClientId.Substring(0,5)));
        }

        /// <summary>
        /// Displays a message server started.
        /// </summary>
        /// <param name="config"></param>
        public void HandleServerStarted(ServerConfig config)
        {
            _form.ServerLog("Server started.");
        }


        /// <summary>
        /// Displays a message server failed to start
        /// </summary>
        /// <param name="config"></param>
        public void HandleServerStartFailure(ServerConfig config)
        {
            _form.ServerLog("Server failed to start.");
        }


        /// <summary>
        /// Displays a message stopped
        /// </summary>
        /// <param name="config"></param>
        public void HandleServerStopped(ServerConfig config)
        {
            _form.ServerLog("Server stopped.");
        }

    }
}
