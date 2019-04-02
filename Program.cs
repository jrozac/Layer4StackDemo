using Layer4Stack.DataProcessors;
using Layer4Stack.Handlers;
using Layer4Stack.Handlers.Interfaces;
using Layer4Stack.Models;
using Layer4Stack.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace Stack4Demo
{

    /// <summary>
    /// Program
    /// </summary>
    public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // configure ioc
            IServiceCollection sc = new ServiceCollection();
            sc.AddLogging();
            sc.AddSingleton<Form1>();
            ConfigureServerAndClient(sc);

            // build services
            var provider = sc.BuildServiceProvider();

            // run app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(provider.GetService<Form1>());
        }

        /// <summary>
        /// Configure ioc services for server and client
        /// </summary>
        /// <param name="sc"></param>
        private static void ConfigureServerAndClient(IServiceCollection sc)
        {
            // set configurations
            sc.AddTransient(sp => new ServerConfig("0.0.0.0", sp.GetService<Form1>().ServerPort));
            sc.AddTransient(sp => new ClientConfig(sp.GetService<Form1>().ClientHost, sp.GetService<Form1>().ClientPort));

            // configure server event handler
            sc.AddTransient<IServerEventHandler, ServerEventHandler>();
            sc.AddTransient<IClientEventHandler, ClientEventHandler>();

            // configure data processor for client and server
            sc.AddTransient(sp =>
                new Func<string, IDataProcessor>((key) => {
                    switch(key)
                    {
                        case "server":
                            return new MessageDataProcessor(new MessageDataProcessorConfig(5000,
                            sp.GetService<Form1>().ServerMsgTerminator,
                            sp.GetService<Form1>().ServerUseLengthHeader),
                            sp.GetService<ILogger<MessageDataProcessor>>());
                        case "client":
                            return new MessageDataProcessor(new MessageDataProcessorConfig(5000,
                            sp.GetService<Form1>().ClientMsgTerminator,
                            sp.GetService<Form1>().ClientUseLengthHeader),
                            sp.GetService<ILogger<MessageDataProcessor>>());
                    }
                    throw new ArgumentException();
                }));
            
            // configure server
            sc.AddTransient((sp) => new TcpServerService(
                sp.GetService<IServerEventHandler>(),
                sp.GetService<ServerConfig>(),
                sp.GetService<ILoggerFactory>(),
                () => sp.GetService<Func<string, IDataProcessor>>()("server")));

            // configure client
            sc.AddTransient((sp) => new TcpClientService(
                sp.GetService<IClientEventHandler>(),
                sp.GetService<ClientConfig>(),
                sp.GetService<ILoggerFactory>(),
                () => sp.GetService<Func<string, IDataProcessor>>()("client")));

        }

    }
}
