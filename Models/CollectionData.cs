using System.Text.Json.Serialization;
using models;

public class CollectionData
    {
    
    public CollectionData()
    {
        
    }
    public bool success { get; set; }
    [JsonPropertyName("data")]
    public Collection collection { get; set; }
    }