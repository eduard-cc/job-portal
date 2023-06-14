using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalWeb.Pages.EmployerDashboard;

public class DeleteJobModel : PageModel
{
    private readonly JobService _jobService;

    public Job Job { get; set; }

    public DeleteJobModel(JobService jobService)
    {
        _jobService = jobService;
    }

    public async Task OnGetAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);
    }

    public async Task<IActionResult> OnPostAsync(int jobId)
    {
        await _jobService.DeleteJobByIdAsync(jobId);

        TempData["JobDeleted"] = "Job deleted successfully!";
        return RedirectToPage("/EmployerDashboard/EmployerJobs");
    }
}
