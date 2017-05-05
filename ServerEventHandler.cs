using Layer4Stack.Handlers;
using Layer4Stack.Models;
using Layer4Stack.Services;
using System;
using System.Text;

namespace Stack4Demo
{
    /// <summary>
    /// Server event handler
    /// </summary>
    class ServerEventHandler : IServerEventHandler
    {


        /// <summary>
        /// Encoding
        /// </summary>
        public Encoding Encoding { get; set; }


        /// <summary>
        /// Form 
        /// </summary>
        public Form1 Form { get; set; }


        /// <summary>
        /// It displays a new client connected message.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="info"></param>
        public void HandleClientConnected(IServerService senderObj, ClientInfoModel info)
        {
            Form.ServerLog(string.Format("Client {0} with IP {1} connected on port {2}.", info.Id.Substring(0,5), info.IpAddress, info.Port));
        }


        /// <summary>
        /// It displays a client disconnected message.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="info"></param>
        public void HandleClientDisconnected(IServerService senderObj, ClientInfoModel info)
        {
            Form.ServerLog(string.Format("Client {0} with IP {1} disconnected on port {2}.", info.Id.Substring(0, 5), info.IpAddress, info.Port));
        }


        /// <summary>
        /// Handles received data.
        /// It disconnects a client if "exit" received.
        /// It stops the server if "stop" recieved.
        /// In all other cases it reverses the string and sends it back to client.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="data"></param>
        public void HandleReceivedData(IServerService senderObj, DataModel data)
        {
            // log received message 
            string msg = Encoding.GetString(data.Payload);
            Form.ServerLog(string.Format("A message '{0}' was received from client {1}.", msg, data.ClientId.Substring(0,5)));

            // disconnect client if exit received 
            if (msg.Trim().ToLowerInvariant() == "exit")
            {
                senderObj.DisconnectClient(data.ClientId);
                return;
            }

            // stop server if stop received
            if (msg.Trim().ToLowerInvariant() == "stop")
            {
                senderObj.Stop();
                return;
            }

            // reverse message 
            char[] charArray = msg.ToCharArray();
            Array.Reverse(charArray);
            msg = new string(charArray);

            // send reversed
            senderObj.SendToClient(data.ClientId, Encoding.GetBytes(msg));
        }


        /// <summary>
        /// Displays received data.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="data"></param>
        public void HandleSentData(IServerService senderObj, DataModel data)
        {
            string msg = Encoding.GetString(data.Payload);
            Form.ServerLog(string.Format("A message '{0}' was sent to client {1}.", msg, data.ClientId.Substring(0,5)));
        }


        /// <summary>
        /// Displays a message server started.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="config"></param>
        public void HandleServerStarted(IServerService senderObj, ServerConfigModel config)
        {
            Form.ServerLog("Server started.");
        }


        /// <summary>
        /// Displays a message server failed to start
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="config"></param>
        public void HandleServerStartFailure(IServerService senderObj, ServerConfigModel config)
        {
            Form.ServerLog("Server failed to start.");
        }


        /// <summary>
        /// Displays a message stopped
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="config"></param>
        public void HandleServerStopped(IServerService senderObj, ServerConfigModel config)
        {
            Form.ServerLog("Server stopped.");
        }

    }
}
