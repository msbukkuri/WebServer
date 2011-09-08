using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MyFirstWebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            server.ListenForClients();
            //TcpClient client = new TcpClient();

            //IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);

            //client.Connect(serverEndPoint);

            //NetworkStream clientStream = client.GetStream();

            //ASCIIEncoding encoder = new ASCIIEncoding();
            //byte[] buffer = encoder.GetBytes("Hello Server!");

            //clientStream.Write(buffer, 0, buffer.Length);
            //clientStream.Flush();

            //byte[] outBuffer = new byte[client.ReceiveBufferSize];
            //clientStream.Read(outBuffer, 0, buffer.Length);
            //Console.WriteLine("Received from Server: " + encoder.GetString(outBuffer));
            
            Console.ReadLine();
        }


        

    }
}
