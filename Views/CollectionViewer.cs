using System.Text.Json;
using models;

namespace Views;

public class CollectionViewer
{
    public static async Task ThingieAsync()
    {
        string fileName = "collection.json";
            using FileStream openStream = File.OpenRead(fileName);
            Collection? weatherForecast = 
                await JsonSerializer.DeserializeAsync<Collection>(openStream);

            
    }
}