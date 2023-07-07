using AlastairLundyWebsite.Models.Meta;
using AlastairLundyWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlastairLundyWebsite.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger, JsonFileService<Policy> policyService, TextFileService textFileService)
    {
        _logger = logger;
        
        policyService.RegisterJsonFileName("policies.json");
        
        textFileService.RegisterTextFileName("privacy.txt", "policies");
    }

    public void OnGet()
    {
        
    }
}