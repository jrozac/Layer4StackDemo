using Layer4Stack.Handlers;
using Layer4Stack.Models;
using Layer4Stack.Services;
using System.Text;

namespace Stack4Demo
{
    /// <summary>
    /// Client event handler
    /// </summary>
    class ClientEventHandler : IClientEventHandler
    {


        /// <summary>
        /// Form 
        /// </summary>
        public Form1 Form { get; set; }


        /// <summary>
        /// Client connected to server
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="info"></param>
        public void HandleClientConnected(IClientService senderObj, ClientInfoModel info)
        {
            Form.ClientLog(string.Format("Client connected to server {0} on port {1}.", info.IpAddress, info.Port));
        }


        /// <summary>
        /// Client failed to connect to server
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="info"></param>
        public void HandleClientConnectionFailure(IClientService senderObj, ClientInfoModel info)
        {
            Form.ClientLog(string.Format("Client failed to connect to server {0} on port {1}.", info.IpAddress, info.Port));
        }


        /// <summary>
        /// Client disconnected from server.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="info"></param>
        public void HandleClientDisconnected(IClientService senderObj, ClientInfoModel info)
        {
            Form.ClientLog(string.Format("Client disconnected from server {0} on port {1}.", info.IpAddress, info.Port));
        }


        /// <summary>
        /// Data received handler. Fired after processed by DataProcessor.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="data"></param>
        public void HandleReceivedData(IClientService senderObj, DataModel data)
        {
            string msg = Encoding.UTF8.GetString(data.Payload);
            Form.ClientLog(string.Format("A message received from server is '{0}'.", msg));
        }


        /// <summary>
        /// Data sent handler.Fired after processed by DataProcessor.
        /// </summary>
        /// <param name="senderObj"></param>
        /// <param name="data"></param>
        public void HandleSentData(IClientService senderObj, DataModel data)
        {
            string msg = Encoding.UTF8.GetString(data.Payload);
            Form.ClientLog(string.Format("A message sent to server is '{0}'.", msg));
        }

    }
}
