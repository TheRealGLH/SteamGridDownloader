using System;
using Views;

class Sample
{
    public static void Main()
    {
        //  Invoke this sample with an arbitrary set of command line arguments.
        string[] arguments = Environment.GetCommandLineArgs();
        //Console.WriteLine("GetCommandLineArgs: {0}", string.Join(", ", arguments));
        foreach (string argument in arguments)
        {
            if(argument == "-help" | argument == "-h")
            {
                Console.WriteLine("Usage: SteamGridDownloader [command] [command-options] [arguments]\n"+
                "\n"+
                "Downloads collections from SteamGridDB\n"+
                "\n"+
                "command:\n"+
                "collection <collection number>\t\t\t Automatically picks and downloads the desired collection number.\n"+ 
                "user <user steam64>\t\t\t\t Show a list of the user's collections.\n"
                
                );
                System.Environment.Exit(0);
            }
        }

        CollectionViewer.ThingieAsync();
    }
}