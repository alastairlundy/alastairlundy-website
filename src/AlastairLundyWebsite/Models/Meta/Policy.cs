using System.Text.Json;
using System.Text.Json.Serialization;
using AlastairLundyWebsite.Enums.Meta;

namespace AlastairLundyWebsite.Models.Meta;

public class Policy
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("created")]
    public DateTime CreationDate { get; set; }
    [JsonPropertyName("last_edited")]
    public DateTime LastEditedDate { get; set; }
    [JsonPropertyName("file_name")]
    public string FileName { get; set; }
    [JsonPropertyName("type")]
    public PolicyType Type { get; set; }
    
    public override string ToString() => JsonSerializer.Serialize<Policy>(this);

}