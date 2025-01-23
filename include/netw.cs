using System.Security.Cryptography;

namespace csh_framework.include;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Netw
{
    
    public static void Server(int port, string message)
    {
        TcpListener? server = null;
        
        try
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                NetworkStream stream = client.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(message+"\n");
                stream.Write(buffer, 0, buffer.Length);
                client.Close();
                
            }
        }
        catch (SocketException e)
        {
            Console.Write("port is already in use");
        }
        
    }

    public static void Client(string host, int port)
    {
        TcpClient? client = null;
        byte[] buffer = new byte[1024];
        bool onOrOff = false;

        try
        {
            client = new TcpClient();

            client.Connect(host, port);
            
            NetworkStream stream = client.GetStream();
            
            while (true)
            {
                
                Console.Write(">");
                string? input = Console.ReadLine();
                
                if(input == "quit") { break; }
                if(input == "exit") { break; }
                
                
                
                if (input != null) stream.Write(Encoding.UTF8.GetBytes(input + "\n"), 0, input.Length);
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("\n"+msg);
            }

        }

        catch (SocketException)
        {
            Console.WriteLine("unable to connect");
        }
    }

}