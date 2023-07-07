using System.Text.Json;
using AlastairLundyWebsite.Enums;
using AlastairLundyWebsite.Models;

namespace AlastairLundyWebsite.Services;

public class JsonFileService<T>
{
    public IWebHostEnvironment WebHostEnvironment { get;  }
    
    public JsonFileService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    protected string JsonFileName;

    public void RegisterJsonFileName(string jsonFileName)
    {
        if (!jsonFileName.ToLower().EndsWith(".json"))
        {
            jsonFileName += ".json";
        }
        
        JsonFileName = Path.Combine(WebHostEnvironment.WebRootPath, "data", jsonFileName);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertyNameCaseInsensitivity"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public IEnumerable<T> Get(bool propertyNameCaseInsensitivity)
    {
        using var jsonFileReader = File.OpenText(JsonFileName);
        return JsonSerializer.Deserialize<T[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = propertyNameCaseInsensitivity
            }) ?? throw new InvalidOperationException();
    }
}