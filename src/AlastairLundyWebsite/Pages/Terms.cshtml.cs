using AlastairLundyWebsite.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlastairLundyWebsite.Pages;

public class TermsModel : PageModel
{
    public TermsModel(TextFileService policyService)
    {
        policyService.RegisterTextFileName("terms.txt", "policies");
    }
    
    public void OnGet()
    {
        
    }
}