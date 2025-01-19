namespace csh_framework;
internal static class Program
{
    public static void Main(string[] args)
    {
        List<string?> history = new List<string?> { };
        
        while (true)
        {
            Console.Write("csh1> ");
            string? input = Console.ReadLine(); 
            int usedOrNot = 0;
            

            int reusi = ((input?.StartsWith("using")) == true) ? 0 : -1;
            int reech = ((input?.StartsWith("echo")) == true) ? 0 : -1;
            int reexi = ((input?.StartsWith("exit")) == true) ? 0 : -1;
            int requi = ((input?.StartsWith("quit")) == true) ? 0 : -1;
            int rehis = ((input?.StartsWith("history")) == true) ? 0 : -1;
            int reels = ((input?.StartsWith("ls")) == true) ? 0 : -1;
            int reecd = ((input?.StartsWith("cd")) == true) ? 0 : -1;
            int recle = ((input?.StartsWith("clear")) == true) ? 0 : -1;

            switch (reech)
            {
                case 0:
                    usedOrNot = 1;
                    Console.WriteLine(input?.Substring(5, input.Length - 5));
                    history.Add(input);
                    break;
            }

            switch (reexi)
            {
                case 0:
                    usedOrNot = 1;
                    history.Add(input);
                    Environment.Exit(0);
                    break;
            }

            switch (reels)
            {
                case 0:
                    usedOrNot = 1;

                    history.Add(input);
                    DirectoryInfo direct = new DirectoryInfo(".");
                    FileInfo[] files = direct.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        Console.WriteLine(file.FullName);
                    }

                    string[] dirs = Directory.GetDirectories(".", "*", SearchOption.TopDirectoryOnly);
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(dir);
                    }

                    break;
            }

            switch (reecd)
            {
                case 0:
                    usedOrNot = 1;

                    try
                    {
                        if (input != null) Directory.SetCurrentDirectory(input.Substring(3, input.Length - 3));
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        Console.WriteLine("Directory not found");
                    }
                    
                    break;
            }

            switch (requi)
            {
                case 0:
                    usedOrNot = 1;

                    history.Add(input);
                    Environment.Exit(0);
                    break;
            }

            switch (recle)
            {
                case 0:
                    usedOrNot = 1;
                    history.Add(input);
                    Console.Clear();
                    break;
            }

            switch (rehis)
            {
                case 0:
                    usedOrNot = 1;
                    foreach (var t in history)
                    {
                        Console.WriteLine(t);
                    }

                    break;
            }

            switch (usedOrNot)
            {
                case 0:
                    Console.WriteLine("unknown command");
                    break;
            }
        }
    }
}