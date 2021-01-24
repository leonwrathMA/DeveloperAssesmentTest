using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Developer_Assesment_1._2_client
{
    public class SynchronousSocketClient
    {

        public static void StartClient()
        {
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[3]; //this is set to 3 as i tested this on a local PC, if you wanted to test on a none local pc, you would need another adress from the list
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint.  
                try
                {
                    //simple int to count packets.
                    int packetCounter = 0;

                    //connection to the endpoint
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    //running until the console window is closed, so no statement to close the while loop, this could be terminated at a certain amount of packets sent, or other conditions. 
                    while (true)
                    {
                        packetCounter++;
                        //writing it out in the console so the user can see what it is sending
                        Console.WriteLine("Sending packet " + packetCounter);
                        byte[] msg = Encoding.ASCII.GetBytes("Hello! This is packet " + packetCounter);

                        // Send the data to the endpoint.  
                        int bytesSent = sender.Send(msg);

                        //sleep for 5 seconds and then repeat, as stated in the assignment.
                        System.Threading.Thread.Sleep(5000);
                    }

                    //to shut down the connection simply call the 2 following methods, though for this project, we want it to run until the console is closed.
                    //sender.Shutdown(SocketShutdown.Both);
                    //sender.Close();

                }
                //here are some generic exception
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static int Main(String[] args)
        {
            StartClient();
            return 0;
        }
    }
}
