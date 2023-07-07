using System.Text;

namespace AlastairLundyWebsite.Models;

public class BaseContent : Owner
{
    public string Title { get; set; }
    
    public string SubTitle { get; set; }
    
    public DateTime CreationDate { get; set; }
    
    public DateTime LastEditDate { get; set; }
    
    public StringBuilder Content { get; set; }

}