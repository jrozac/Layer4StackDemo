using Layer4Stack.Handlers;
using Layer4Stack.Models;
using System.Text;

namespace Stack4Demo
{
    /// <summary>
    /// Client event handler
    /// </summary>
    public class ClientEventHandler : IClientEventHandler
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
        public ClientEventHandler(Form1 form)
        {
            _form = form;
            _encoding = form.ClientEncoding;
        }

        /// <summary>
        /// Client connected to server
        /// </summary>
        /// <param name="info"></param>
        public void HandleClientConnected(ClientInfo info)
        {
            _form.ClientLog(string.Format("Client connected to server {0} on port {1}.", info.IpAddress, info.Port));
        }

        /// <summary>
        /// Client failed to connect to server
        /// </summary>
        /// <param name="info"></param>
        public void HandleClientConnectionFailure(ClientInfo info)
        {
            _form.ClientLog(string.Format("Client failed to connect to server {0} on port {1}.", info.IpAddress, info.Port));
        }

        /// <summary>
        /// Client disconnected from server.
        /// </summary>
        /// <param name="info"></param>
        public void HandleClientDisconnected(ClientInfo info)
        {
            _form.ClientLog(string.Format("Client disconnected from server {0} on port {1}.", info.IpAddress, info.Port));
        }

        /// <summary>
        /// Data received handler. Fired after processed by DataProcessor.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public byte[] HandleReceivedData(DataContainer data, bool rpcResponse = false)
        {
            string msg = _encoding.GetString(data.Payload);
            _form.ClientLog(string.Format("A message received from server is '{0}'.", msg));
            return null;
        }

        /// <summary>
        /// Data sent handler.Fired after processed by DataProcessor.
        /// </summary>
        /// <param name="data"></param>
        public void HandleSentData(DataContainer data)
        {
            string msg = _encoding.GetString(data.Payload);
            _form.ClientLog(string.Format("A message sent to server is '{0}'.", msg));
        }

    }
}
