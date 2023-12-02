using System.Text.Json;
using models;

namespace Views;

public class CollectionViewer
{
    public static async Task ThingieAsync()
    {
        //Should be from http call. This is for early test only.
        string fileName = "D:\\Code\\SteamGridDownloader\\collection.json";
            using FileStream openStream = File.OpenRead(fileName);
            CollectionData? collectionData = 
                await JsonSerializer.DeserializeAsync<CollectionData>(openStream);
                Console.WriteLine(collectionData.ToString());
    }
}