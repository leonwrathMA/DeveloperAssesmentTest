using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;      //required
using System.Net.Sockets;    //required

namespace Developer_Assesment_1._2_server
{
    public class SynchronousSocketListener
    {

        // Incoming data from the client.  
        private static string data = null;

        public static void StartListening()
        {
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[3];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                // Bind the socket to the local endpoint and
                listener.Bind(localEndPoint);

                // Start listening for connections.  
                listener.Listen(10);
                Console.WriteLine("Waiting for a connection...");
                Socket handler = listener.Accept();

                //again, this just listens until the program is closed, could have terminated through other means, such as recieving a special packet number.
                while (true)
                {
                    data = null;

                    // An incoming connection needs to be processed.  
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.Length > 0)
                        {
                            break;
                        }
                    }

                    // Show the data on the console.  
                    Console.WriteLine("Text received : {0}", data);

                    //to shut down the connection simply call the 2 following methods, though for this project, we want it to run until the console is closed.
                    //handler.Shutdown(SocketShutdown.Both);
                    //handler.Close();
                }

            }
            //Generic error catching
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}
