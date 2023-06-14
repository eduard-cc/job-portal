using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace JobPortalWeb.Pages.JobseekerDashboard;

public class JobseekerAppliedJobsModel : PageModel
{
    private readonly ApplicationService _applicationService;

    public List<Application> Applications { get; set; }

    public JobseekerAppliedJobsModel(ApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    public async Task OnGetAsync()
    {
        int jobseekerId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        Applications = await _applicationService.GetAllApplicationsByJobseekerIdAsync(jobseekerId);
    }
}