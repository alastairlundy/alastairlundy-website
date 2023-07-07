using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlastairLundyWebsite.Models.Meta;

public class ImageModel
{
    [JsonPropertyName("image_url")]
    public string Url { get; set; }
    [JsonPropertyName("image_alt_text")]
    public string AltText { get; set; }
    
    public override string ToString() => JsonSerializer.Serialize<ImageModel>(this);

}