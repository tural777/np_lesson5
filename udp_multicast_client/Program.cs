using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace udp_multicast_client
{
    class Program
    {
        static void Main()
        {
            UdpClient udpClient = new UdpClient();

            var remoteEP = new IPEndPoint(IPAddress.Parse("224.5.6.7"), 45678);
            while (true)
            {
                var str = Console.ReadLine();
                var bytes = Encoding.Default.GetBytes(str);
                udpClient.Send(bytes, bytes.Length, remoteEP);
            }
        }
    }
}
