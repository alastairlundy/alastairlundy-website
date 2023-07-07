using AlastairLundyWebsite.Models;
using AlastairLundyWebsite.Models.Meta;
using AlastairLundyWebsite.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlastairLundyWebsite.Pages;

public class ProjectsModel : PageModel
{
    public JsonFileService<Project> ProjectService;

    public IEnumerable<Project> Projects { get; private set; }

    public ProjectsModel(JsonFileService<Project> projectService)
    {
        projectService.RegisterJsonFileName("projects.json");

        this.ProjectService = projectService;
    }
    
    public void OnGet()
    {
        Projects = ProjectService.Get(true);
    }
}