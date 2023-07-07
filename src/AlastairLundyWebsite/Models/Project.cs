using System.Text.Json;
using System.Text.Json.Serialization;
using AlastairLundyWebsite.Enums;
using AlastairLundyWebsite.Models.Meta;

namespace AlastairLundyWebsite.Models;

public class Project
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("project_url")]
    public string? ProjectWebsiteUrl { get; set; }
    [JsonPropertyName("repo_url")]
    public string? ProjectRepoUrl { get; set; }
    [JsonPropertyName("image")]
    public ImageModel? Image { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("tech_used")]
    public string[] Technologies { get; set; }
    [JsonPropertyName("license")]
    public string License { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() => JsonSerializer.Serialize<Project>(this);
}
