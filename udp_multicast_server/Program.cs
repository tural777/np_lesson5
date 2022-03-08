using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace udp_multicast_server
{
    class Program
    {
        static void Main()
        {
            UdpClient udp = new UdpClient(45678);
            udp.JoinMulticastGroup(IPAddress.Parse("224.5.6.7"));

            var from = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                var bytes = udp.Receive(ref from);
                Console.WriteLine(Encoding.Default.GetString(bytes));
            }
        }
    }
}
