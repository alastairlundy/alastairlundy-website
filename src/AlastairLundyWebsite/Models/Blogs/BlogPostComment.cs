namespace AlastairLundyWebsite.Models;

public class BlogPostComment : BaseContent
{
     public long NumberOfUpvotes { get; set; }
     
     public long NumberOfDownvotes { get; set; }
     
     public BlogPostComment Replies { get; set; }
}