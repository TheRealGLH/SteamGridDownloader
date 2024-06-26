using System.Net.Http.Json;
using System.Text.Json;

public class ApiConnector
{
    public static async Task<CollectionData> GetCollection(String id)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://www.steamgriddb.com/api/public/collection/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(id+"/home");
                var collection = await response.Content.ReadFromJsonAsync<CollectionData>();
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.Read();
                return collection;
       }
    }
}

