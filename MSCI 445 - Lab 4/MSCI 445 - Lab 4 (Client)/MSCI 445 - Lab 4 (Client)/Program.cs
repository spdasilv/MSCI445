using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Diagnostics;

namespace MSCI_445___Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required arguments: port");
                return;
            }
            int port = Convert.ToInt32(args[0]);
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            IPEndPoint localpt = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            // Create a datagram socket for receiving and sending UDP packets
            // through the port specified on the command line.
            UdpClient socket = new UdpClient();
            socket.Client.SetSocketOption(SocketOptionLevel.Socket,
            SocketOptionName.ReuseAddress, true);
            socket.Client.Bind(localpt);
            // Set timeout to 1 second or 1000 millisecond
            socket.Client.ReceiveTimeout = 1000; //milliseconds
            System.Net.IPEndPoint ep = null;
            // Limit number of sent packages to 10
            for (int i = 0; i < 10; ++i)
            {
                byte[] msg = Encoding.UTF8.GetBytes("PING #" + (i+1) + "; Timestamp: " + DateTime.Now);
                socket.Send(msg, msg.Length, serverEndPoint);
                Console.WriteLine("Socket Connected: 127.0.0.1:8888");

                double rtt = 0;
                // Stopwatch to track Round Trip Time (rtt)
                Stopwatch sw = new Stopwatch();
                byte[] rdata = null;
                sw.Start();
                // Trying to send a package
                try
                {
                    rdata = socket.Receive(ref ep);
                    rtt = sw.ElapsedMilliseconds;
                    sw.Stop();
                    Console.WriteLine("Server: PING " + (i + 1) + " " + DateTime.Now);
                }
                // Catching an exception of ReceivedTimeout reached
                catch
                {
                    Console.WriteLine("Timeout");
                    Console.WriteLine("Last Response: PING "+ (i+1) + " " + DateTime.Now + " \n" + " \r");
                    sw.Stop();
                    continue;
                }
                // Informing user the RTT
                Console.WriteLine("Round Trip Time (RTT):" + rtt + " milliseconds" + " \n" + " \r");
            }
        }
    }
}