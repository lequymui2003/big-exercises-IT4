using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServerApp
{
    class Server
    {
        private static TcpListener listener;
        private static bool isRunning;
        private static readonly object locker = new object();
        private static List<ConnectedClient> connectedClients = new List<ConnectedClient>();

        static void Main(string[] args)
        {
            StartServer();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        }

        private static void StartServer()
        {
            Console.WriteLine("Starting server...");

            listener = new TcpListener(IPAddress.Any, 8888);
            isRunning = true;
            listener.Start();
            Console.WriteLine("Server started on port 8888");

            while (isRunning)
            {
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Client connected from {0}", ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());

                ConnectedClient newClient = new ConnectedClient(client);
                connectedClients.Add(newClient);

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                clientThread.Start(newClient);
            }
        }

        private static void HandleClient(object clientObject)
        {
            ConnectedClient client = (ConnectedClient)clientObject;
            TcpClient tcpClient = client.TcpClient;

            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = tcpClient.GetStream().Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        // client disconnected
                        connectedClients.Remove(client);
                        tcpClient.Close();
                        Console.WriteLine("Client {0} disconnected.", client.Username);
                        break;
                    }

                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("[{0}] {1} {2}", DateTime.Now.ToString("HH:mm:ss"), client.Username, message);

                    // send message to all other clients
                    lock (locker)
                    {
                        foreach (ConnectedClient otherClient in connectedClients)
                        {
                            if (otherClient != client)
                            {
                                byte[] messageBuffer = Encoding.ASCII.GetBytes(string.Format("[{0}] {1} {2}", DateTime.Now.ToString("HH:mm:ss"), client.Username, message));
                                otherClient.TcpClient.GetStream().Write(messageBuffer, 0, messageBuffer.Length);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                    break;
                }
            }
        }

        class ConnectedClient
        {
            public TcpClient TcpClient { get; set; }
            public string Username { get; set; }

            public ConnectedClient(TcpClient tcpClient)
            {
                TcpClient = tcpClient;
                Username = string.Format("Client", Guid.NewGuid().ToString().Substring(0, 4));
            }
        }
    }
}
