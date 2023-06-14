using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.PortableExecutable;

namespace JobPortalWeb.Pages.EmployerDashboard;

public class JobDashboardModel : PageModel
{
    private readonly JobService _jobService;
    private readonly ApplicationService _applicationService;
    private readonly StatisticsService _statisticsService;

    public Job Job { get; set; }

    public List<Application> Applications { get; set; }

    public Statistics Statistics { get; set; }

    public JobDashboardModel(JobService jobService, ApplicationService applicationService,
        StatisticsService statisticsService)
    {
        _jobService = jobService;
        _applicationService = applicationService;
        _statisticsService = statisticsService;
    }

    public async Task OnGetAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        Statistics = await _statisticsService.GetJobStatisticsAsync(jobId);

        Applications = await _applicationService.GetAllApplicationsByJobIdAsync(jobId);
    }

    public async Task<IActionResult> OnPostEditAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        return RedirectToPage("/EmployerDashboard/EditJob", new { jobId });
    }

    public async Task<IActionResult> OnPostUpdateStatusAsync(int jobId, int applicationId, ApplicationStatus applicationStatus)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        await _applicationService.UpdateStatusOfApplicationAsync(applicationId, applicationStatus);

        return RedirectToPage("/EmployerDashboard/JobDashboard", new { jobId });
    }

    public async Task<IActionResult> OnPostDeleteAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        return RedirectToPage("/EmployerDashboard/DeleteJob", new { jobId });
    }
}
