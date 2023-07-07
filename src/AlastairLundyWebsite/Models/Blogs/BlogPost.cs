using System.Text;

namespace AlastairLundyWebsite.Models;

public class BlogPost : BlogPostComment
{
    public string ThumbnailImageUrl { get; set; }
    
    public string BlogPostUrl { get; set; }

}