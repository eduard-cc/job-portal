using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace JobPortalWeb.Pages.EmployerDashboard;

public class EmployerJobsModel : PageModel
{
    private readonly JobService _jobService;

    [BindProperty(SupportsGet = true)]
    public List<Job> Jobs { get; set; }

    public EmployerJobsModel(JobService jobService)
    {
        _jobService = jobService;
    }
    public async Task OnGet()
    {
        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        Jobs = await _jobService.GetJobsByEmployerIdAsync(userId);
    }
    public IActionResult OnPost()
    {
        return RedirectToPage("/EmployerDashboard/PostJob");
    }
}
