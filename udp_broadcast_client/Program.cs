using System;
using System.Net.Sockets;
using System.Text;

namespace udp_broadcast_client
{
    class Program
    {
        static void Main()
        {
            UdpClient udpClient = new UdpClient();

            while (true)
            {
                var data = Encoding.Default.GetBytes(Console.ReadLine());
                udpClient.Send(data, data.Length, "255.255.255.255", 45678);
            }
        }
    }
}
