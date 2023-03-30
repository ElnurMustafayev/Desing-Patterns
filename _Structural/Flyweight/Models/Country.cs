using System.Text.Json.Serialization;

namespace Flyweight.Models;

public class Country {
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
    

    public override string ToString() => $"{this.Code}: '{this.Name}'";
}