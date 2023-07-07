using System.Text;

namespace AlastairLundyWebsite.Services;

public class TextFileService
{
    public IWebHostEnvironment WebHostEnvironment { get;  }

    public TextFileService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    protected string TextFileName;
    
    public void RegisterTextFileName(string textFileName, string folderName)
    {
        if (!textFileName.ToLower().EndsWith(".json"))
        {
            textFileName += ".json";
        }
        
        TextFileName = Path.Combine(WebHostEnvironment.WebRootPath, folderName, textFileName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IEnumerable<string> Get() => File.ReadLines(TextFileName, Encoding.Unicode);
}