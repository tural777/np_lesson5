using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace udp_broadcast_server
{
    class Program
    {
        static void Main()
        {
            UdpClient udpClient = new UdpClient(45678);
            udpClient.EnableBroadcast = true;

            var from = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                var recvBuffer = udpClient.Receive(ref from);
                Console.WriteLine(Encoding.Default.GetString(recvBuffer));
            }
        }
    }
}
