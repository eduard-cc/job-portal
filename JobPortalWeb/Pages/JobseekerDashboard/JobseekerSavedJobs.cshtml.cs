using JobPortalDomain.Models;
using JobPortalInfrastructure.Repositories;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace JobPortalWeb.Pages.JobseekerDashboard;

public class JobseekerSavedJobsModel : PageModel
{
    private readonly SavedJobService _savedJobService;

    public List<Job> SavedJobs { get; set; }

    public JobseekerSavedJobsModel(SavedJobService savedJobService)
    {
        _savedJobService = savedJobService;
    }
    public async Task OnGetAsync()
    {
        int jobseekerId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        SavedJobs = await _savedJobService.GetAllSavedJobsAsync(jobseekerId);
    }
}
