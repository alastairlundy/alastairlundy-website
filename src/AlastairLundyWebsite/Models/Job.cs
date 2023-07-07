using System.Text.Json;
using System.Text.Json.Serialization;
using AlastairLundyWebsite.Enums;

namespace AlastairLundyWebsite.Models;

public class Job
{
    [JsonPropertyName("position")]
    public string PositionName { get; set; }
    [JsonPropertyName("employer")]
    public string EmployerName { get; set; }
    [JsonPropertyName("type")]
    public JobType Type { get; set; }
    [JsonPropertyName("start")]
    public MonthYear StartDate { get; set; }
    [JsonPropertyName("end")]
    public MonthYear EndDate { get; set; }
    
    public override string ToString() => JsonSerializer.Serialize<Job>(this);

}