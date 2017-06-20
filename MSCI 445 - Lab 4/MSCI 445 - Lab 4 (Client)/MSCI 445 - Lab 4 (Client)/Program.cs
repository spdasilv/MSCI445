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
        private const double LOSS_RATE = 0.3;
        private const double AVG_DELAY = 100; //milliseconds

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
            UdpClient socket = new UdpClient();
            socket.Client.SetSocketOption(SocketOptionLevel.Socket,
            SocketOptionName.ReuseAddress, true);
            socket.Client.Bind(localpt);
            socket.Client.ReceiveTimeout = 1000;
            System.Net.IPEndPoint ep = null;
            for (int i = 0; i < 10; ++i)
            {
                byte[] msg = Encoding.UTF8.GetBytes("PING #" + (i+1) + "; Timestamp: " + DateTime.Now);
                socket.Send(msg, msg.Length, serverEndPoint);
                Console.WriteLine("Sent Message -> PING #" + (i + 1) + "; Timestamp: " + DateTime.Now);

                double rtt = 0;
                Stopwatch sw = new Stopwatch();
                byte[] rdata = null;
                sw.Start();
                try
                {
                    sw.Start();
                    rdata = socket.Receive(ref ep);
                    rtt = sw.ElapsedMilliseconds;
                    sw.Stop();
                }
                catch
                {
                    Console.WriteLine("Failure");
                    sw.Stop();
                    continue;
                }
                Console.WriteLine("Success, RTT:" + rtt);
            }
        }
    }
}