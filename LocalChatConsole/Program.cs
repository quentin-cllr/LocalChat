using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    const int PORT = 5000;

    static void Main()
    {
        TcpListener server = null;

        try
        {
            server = new TcpListener(IPAddress.Any, PORT);
            server.Start();
            Console.WriteLine("Mode serveur");
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Client connecté");
            }
        }
        catch (SocketException)
        {
            Console.WriteLine("Mode client");
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", PORT);
            Console.WriteLine("Connecté au serveur");
        }

        Console.ReadLine();
    }
}
