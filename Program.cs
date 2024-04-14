using System;
using System.Runtime.InteropServices;
using models;
using Views;

class Program
{
    static String id;
    static String saveDir;
    static CollectionData collectionData;
    public async static Task Main()
    {
        //  Invoke this sample with an arbitrary set of command line arguments.
        string[] arguments = Environment.GetCommandLineArgs();
        //Console.WriteLine("GetCommandLineArgs: {0}", string.Join(", ", arguments));
        foreach (string argument in arguments)
        {
            if (argument == "-help" | argument == "-h")
            {
                printHelp();
                System.Environment.Exit(0);
            }
        }
        for (var i = 0; i < arguments.Length; i++)
        {
            if (arguments[i] == "-c")
            {
                id = arguments[i + 1];
            }
            else if (arguments[i] == "-d")
            {
                saveDir = arguments[i + 1];
            }
        }
        if (id == null) setID();
        if (saveDir == null) setSaveDirectory();

        //await CollectionViewer.ThingieAsync();
        collectionData = await ApiConnector.GetCollection(id);
        //TODO: Get steam app id from steamgrid db url 
        foreach (Hero item in collectionData.collection.heroes)
        {
            FileDownloader.SaveImage(item.url, saveDir + item.game.id + "_hero." + item.url.Split(".").Last());
        }
        foreach (Logo item in collectionData.collection.logos)
        {
            Console.WriteLine("Saving to " + saveDir);
            FileDownloader.SaveImage(item.url, saveDir + item.game.id + "_logo." + item.url.Split(".").Last());
        }
        foreach (Grid item in collectionData.collection.grids)
        {
            FileDownloader.SaveImage(item.url, saveDir + item.game.id + "p." + item.url.Split(".").Last());
            Console.WriteLine("Saving " + item.game.id + "p." + item.url.Split(".").Last());
        }
        foreach (Logo item in collectionData.collection.icons)
        {
            Console.WriteLine("Saving " + item.game.id + "_icon." + item.url.Split(".").Last());
            FileDownloader.SaveImage(item.url, saveDir + item.game.id + "_icon." + item.url.Split(".").Last());
        }
    }


    static void setID()
    {
        Console.Write("Please enter the ID of the collection: ");
        id = Console.ReadLine();
        if (string.IsNullOrEmpty(id)) setID();
    }

    static void setSaveDirectory()
    {
        String baseDir;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (Directory.Exists("C:\\Program files (x86)\\Steam"))
            {
               baseDir =  "C:\\Program files (x86)\\Steam\\userdata";
               foreach(String dir in Directory.GetDirectories(baseDir))
               {
                   string id = dir.Split("\\").Last();
                   if(id != "0")
                   {
                       if(ConfirmYesNoConsole("Found a config folder for user id " + id +"."))
                       {
                           saveDir = baseDir + "\\"+ id+ "\\" + "config\\grid\\"; 
                       }

                   }
               }
            }
        }
        else 
        {
            Console.WriteLine("Default save directory not found. Please specify: ");
            saveDir = Console.ReadLine();
        }
    }
    static bool ConfirmYesNoConsole(String prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine().ToLower();
        if (input == "y" || input == "yes") return true;
        if (input == "n" || input == "no") return false;
        Console.WriteLine("Please type in \"yes\" or \"no\"");
        return ConfirmYesNoConsole(prompt);
    }
    static void printHelp()
    {
        Console.WriteLine("Usage: SteamGridDownloader [command] [command-options] [arguments]\n" +
            "\n" +
            "Downloads collections from SteamGridDB\n" +
            "\n" +
            "command:\n" +
            "collection <collection number>\t\t\t Automatically picks and downloads the desired collection number.\n" +
            "user <user steam64>\t\t\t\t Show a list of the user's collections.\n"
            );
    }
}
