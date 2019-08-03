using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
namespace PokerClient
{
    public class SynchronousSocketClient
    {
        static Socket Server;
        public static void StartClient(string userID,string userPW)
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

                // Create a TCP/IP  socket.  
                Server = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    Server.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        Server.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes("logmein:" + userID+"<EOF>");

                    // Send the data through the socket.  
                    int bytesSent = Server.Send(msg);
                    Thread th = new Thread(() =>
                    {
                        while (Server.Connected)
                        {
                            //Thread.Sleep(100);//Alow to work faster and have time to recieve shits

                            // Receive the response from the remote device.  
                            int bytesRec = Server.Receive(bytes);
                            var datarec = string.Format("{0}",
                                Encoding.ASCII.GetString(bytes, 0, bytesRec));
                            string[] cmd = datarec.Split(':');
                            switch (cmd[0])
                            {
                                case "update":
                                    {
                                        Table.Refresh(datarec);
                                        break;
                                    }                                   
                                case "updateSelf":
                                    {//updateSelf:0::0:0:False:True:True:0:0.2:0.2:Cosmin:0:
                                        Client.Instance.UpdatePlayer(datarec);
                                        break;
                                    }
                            }


                        }
                    });
                    th.Start();
                    // Release the socket.  
                    //sender.Shutdown(SocketShutdown.Both);
                   // sender.Close();

                }
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

        public static void SendResponse(string v)
        {
            byte[] msg = Encoding.ASCII.GetBytes(v);

            // Send the data through the socket.  
            int bytesSent = Server.Send(msg);
        }
    }


}