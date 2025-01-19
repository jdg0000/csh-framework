// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("csh1> ");
            string? input = Console.ReadLine();

            int usedOrNot = 0;

            int reusi = ((input?.StartsWith("using")) == true) ? 0 : -1;
            int reech = ((input?.StartsWith("echo")) == true) ? 0 : -1;
            int reexi = ((input?.StartsWith("exit")) == true) ? 0 : -1;
            int reels = ((input?.StartsWith("ls")) == true) ? 0 : -1;
            int reecd = ((input?.StartsWith("cd")) == true) ? 0 : -1;

            switch (reech)
            {
                case 0:
                    usedOrNot = 1;
                    Console.WriteLine(input?.Substring(5, input.Length - 5));   
                    break;
            }

            switch (reexi)
            {
                case 0:
                    usedOrNot = 1;
                    System.Environment.Exit(0);
                    break;
            }

            switch (reels)
            {
                case 0:
                    usedOrNot = 1;
                    
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

                    if (input != null) Directory.SetCurrentDirectory(input.Substring(3, input.Length - 3));
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