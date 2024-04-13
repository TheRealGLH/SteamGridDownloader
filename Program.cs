using System;
using models;
using Views;

class Program
{
    static String id;
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
        }
        if (id == null) setID();
        //await CollectionViewer.ThingieAsync();
        collectionData = await ApiConnector.GetCollection(id);
        //TODO: Make this save from the urls with the paths we listed.
        foreach (Hero item in collectionData.collection.heroes)
        {
            Console.WriteLine("Saving " + item.game.id + "_hero." + item.url.Split(".").Last());
        }
        foreach (Logo item in collectionData.collection.logos)
        {
            Console.WriteLine("Saving " + item.game.id + "_logo." + item.url.Split(".").Last());
        }
        foreach (Grid item in collectionData.collection.grids)
        {
            Console.WriteLine("Saving " + item.game.id + "p." + item.url.Split(".").Last());
        }
        foreach (Logo item in collectionData.collection.icons)
        {
            Console.WriteLine("Saving " + item.game.id + "_icon." + item.url.Split(".").Last());
        }
    }


    static void setID()
    {
        Console.Write("Please enter the ID of the collection: ");
        id = Console.ReadLine();
        if(string.IsNullOrEmpty(id)) setID();
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