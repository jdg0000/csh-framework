namespace csh_framework.include;

using System.Threading;
public abstract class Shell
{
    public static int Sshell()
    {
        int port = 0;
        string message = "";
        while (true)
        {
            Console.Write("csf(server)> ");
            string? input = Console.ReadLine();
            
            int usedOrNot = 0;
            
            int reset = ((input?.StartsWith("set")) == true) ? 0 : -1;
            int rerun = ((input?.StartsWith("run")) == true) ? 0 : -1;
            int reopt = ((input?.StartsWith("options")) == true) ? 0 : -1;
            int recle = ((input?.StartsWith("clear")) == true) ? 0 : -1;
            int reexi = ((input?.StartsWith("exit")) == true) ? 0 : -1;
            int requi = ((input?.StartsWith("quit")) == true) ? 0 : -1;
            

            switch (reset)
            {
                case 0:
                    usedOrNot = 1;
                    int usedOrNotSet = 0;

                    if (input?.Substring(4, 4) == "PORT")
                    {
                        try
                        {
                            port = Convert.ToInt32(input.Substring(8, input.Length - 8));
                            Console.WriteLine($"Port: {port}");
                        }
                        
                        catch (OverflowException) { Console.WriteLine("Port is out of range"); }
                        catch (FormatException) { Console.WriteLine("Port is the wrong format"); }
                        catch (ArgumentOutOfRangeException) { Console.WriteLine("Substring operation failed due to input being too short."); }
                        
                        usedOrNotSet = 1;
                    }

                    if (input?.Substring(4, 7) == "MESSAGE")
                    {
                        message = input.Substring(12, input.Length - 12);
                        Console.WriteLine($"Message: {message}");
                        usedOrNotSet = 1;
                    }

                    if (usedOrNotSet != 1) { Console.WriteLine("Unknown variable"); }
                    break;
            }

            switch (recle)
            { 
                case 0:
                    usedOrNot = 1;
                    Console.Clear();
                    break;
            }
            
            int portp = port;
            string messagem = message;
            Thread server = new Thread(() => Netw.Server(portp, messagem));

            switch (rerun)
            {
                case 0:
                    usedOrNot = 1;
                    int ableToRun = 0;
                    
                    if(port == 0) { Console.WriteLine("set the port with \"set PORT\""); ableToRun = -1; }
                    if (message == "") { Console.WriteLine("set the message with \"set Message\""); ableToRun = -1; }

                    if (ableToRun == 0)
                    {
                        
                        server.Start();
                    }

                    break;
            }

            switch (reopt)
            {
                case 0:
                    usedOrNot = 1;
                    Console.WriteLine("NAME\tREQUIRED");
                    Console.WriteLine("PORT\tYES");
                    Console.WriteLine("MESSAGE\tYES");
                    Console.WriteLine("EXIT\tNO");
                    Console.WriteLine("QUIT\tNO");
                    
                    break;
            }

            switch (reexi)
            {
                case 0:
                    usedOrNot = 1;
                    Environment.Exit(0);
                    break;
            }

            switch (requi)
            {
                case 0:
                    usedOrNot = 1;
                    Environment.Exit(0);
                    break;
            }

            if (input == "") { usedOrNot = 1; }

            if (usedOrNot != 1) Console.WriteLine("unknown command");
        }
    }

    public static int Cshell()
    {
        int port = 0;
        string ip = "";
        
        while (true)
        {
            int usedOrNot = 0;
            Console.Write("csf(client)> ");
            string? input = Console.ReadLine();
            
            int requi = ((input?.StartsWith("quit")) == true) ? 0 : -1;
            int reexi = ((input?.StartsWith("exit")) == true) ? 0 : -1;
            int reopt = ((input?.StartsWith("options")) == true) ? 0 : -1;
            int reinf = ((input?.StartsWith("info")) == true) ? 0 : -1; 
            int recle = ((input?.StartsWith("clear")) == true) ? 0 : -1;
            int reset = ((input?.StartsWith("set")) == true) ? 0 : -1;
            int rerun = ((input?.StartsWith("run")) == true) ? 0 : -1;

            switch (requi)
            {
                case 0:
                    usedOrNot = 1;
                    Environment.Exit(0);
                    break;
            }

            switch (reexi)
            {
                case 0:
                    usedOrNot = 1;
                    Environment.Exit(0);
                    break;
            }

            switch (recle)
            {
                case 0:
                    usedOrNot = 1;
                    Console.Clear();
                    break;
            }

            switch (reopt)
            {
                case 0:
                    Console.WriteLine("VAR\tREQ\nIP\tYES\nPORT\tYES\n\nCOMMANDS:\nset\ninfo"); 
                    usedOrNot = 1;
                    break;
            }

            switch (reinf)
            {
                case 0:
                    Console.WriteLine("CREATED ON JANUARY THE 23. 2025\nQUALITY: EXCELLENT\nCREATED BY: Yosif Aboulaban\nFOR: Connecting to a remote tcp server"); 
                    usedOrNot = 1;
                    break;
            }

            switch (reset)
            {
                case 0:
                    usedOrNot = 1;
                    int varIsReal = 0;
                
                    if (input != null && input[4..6].Equals("IP"))
                    {
                        varIsReal = 1;
                        if (input.Length == 6)
                        {
                            Console.WriteLine("enter an actual ip");
                        }

                        else
                        {
                            ip = input[7..];
                            Console.WriteLine($"IP: {ip}");
                        }
                    }

                    if (input.Length >= 9 && input[4..8] == "PORT")
                    {
                        varIsReal = 1;
                        try
                        {
                            port = Convert.ToInt32(input[9..]);
                            Console.WriteLine($"Port: {port}");
                        }
                    
                        catch (OverflowException) { Console.WriteLine("Port is out of range"); }
                        catch (FormatException) { Console.WriteLine("Port is the wrong format"); }
                        catch (ArgumentOutOfRangeException) { Console.WriteLine("Substring operation failed due to input too short."); }
                    } else if (input.Length == 8 && input[4..8] == "PORT") {
                        varIsReal = 1;
                        Console.WriteLine("enter an actual port");
                    }

                    if (input != null && input[4..] == "")
                    {
                        Console.WriteLine("enter a real variable you can find the variables with \"options\"");
                        varIsReal = 1;
                    }

                    if (varIsReal != 1)
                    {
                        Console.WriteLine("unknown variable");
                    }

                    break;

            }

            switch (rerun)
            {
                case 0:
                    usedOrNot = 1;
                    int ableTorun = 0;

                    if (ip == "0")
                    {
                        ableTorun = -1;
                        Console.WriteLine("enter an ip with \"set IP **.**.**.**\"");
                    }

                    if (port == 0)
                    {
                        ableTorun = -1;
                        Console.WriteLine("enter a PORT with \"set PORT ****\"");
                    }

                    if (ableTorun == 0)
                    {
                        Netw.Client(ip, port);
                    }

                    break;
            }

            if (input == "") { usedOrNot = 1; }
            
            if (usedOrNot != 1) Console.WriteLine("unknown command");
        }
    }
}