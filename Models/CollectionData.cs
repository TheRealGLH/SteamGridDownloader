using System.Text.Json.Serialization;
using models;

public class CollectionData
    {
    public CollectionData(bool success, Collection collection)
    {
        this.success = success;
        this.collection = collection;
    }

    public bool success { get; set; }
    [JsonPropertyName("data")]
    public Collection collection { get; set; }
    }