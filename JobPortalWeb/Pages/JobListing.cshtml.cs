using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;
using System.IO.Pipes;
using System.Net.Mime;
using System.Security.Claims;
using System.Xml.Linq;

namespace JobPortalWeb.Pages;

public class JobListingModel : PageModel
{
    private readonly JobService _jobService;
    private readonly UserService _userService;
    private readonly ApplicationService _applicationService;
    private readonly SavedJobService _savedJobService;
    private readonly StatisticsService _statisticsService;

    public Job Job { get; set; }

    public Jobseeker Jobseeker { get; set; }

    [BindProperty]
    public int JobId { get; set; }

    [BindProperty]
    public IFormFile Upload { get; set; }

    [BindProperty]
    public bool Saved { get; set; }

    public Application? ApplicationAlreadyMade { get; set; }

    public bool AllowEditAndDelete { get; set; }

    public JobListingModel(JobService jobService, UserService userService, 
        ApplicationService applicationService, SavedJobService savedJobService, 
        StatisticsService statisticsService)
    {
        _jobService = jobService;
        _userService = userService;
        _applicationService = applicationService;
        _savedJobService = savedJobService;
        _statisticsService = statisticsService;
    }

    public async Task OnGetAsync(int jobId)
    {
        JobId = jobId;

        Job = await _jobService.GetJobByIdAsync(JobId);

        if (User.Identity.IsAuthenticated)
        {
            string accountTypeString = User.FindFirst(ClaimTypes.Role).Value;

            AccountType accountType = (AccountType)Enum.Parse(typeof(AccountType), accountTypeString);

            int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            if (accountType == AccountType.Jobseeker)
            {
                await _statisticsService.IncrementClicksByJobIdAsync(jobId);

                // Check if job is saved by jobseeker or not
                Saved = await _savedJobService.CheckIfJobSavedAsync(userId, JobId);

                Jobseeker = (Jobseeker)await _userService.GetUserDetailsByIdAsync(userId, AccountType.Jobseeker);

                // Check if jobseeker already applied to this job
                ApplicationAlreadyMade = await _applicationService.GetApplicationByJobseekerAndJobIdAsync(userId, JobId);
            }
            else
            {
                AllowEditAndDelete = await _jobService.CheckIfJobPostedByEmployerAsync(userId, JobId);
            }
        }
    }

    private bool IsFileValid(string fileName)
    {
        string extension = Path.GetExtension(fileName).ToLower();
        return extension == ".doc" || extension == ".docx" || extension == ".pdf";
    }

    public async Task<IActionResult> OnPostApplyAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        int jobseekerId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        Jobseeker = (Jobseeker)await _userService.GetUserDetailsByIdAsync(jobseekerId, AccountType.Jobseeker);
        Jobseeker.Id = jobseekerId;

        Application application;

        Cv cv = null;

        if (Upload != null)
        {
            // Validate file type
            if (!IsFileValid(Upload.FileName))
            {
                ModelState.AddModelError("Upload", "Only doc, docx, or pdf files are allowed.");
                return Page();
            }

            // Validate file size
            const int maxFileSize = 2 * 1024 * 1024; // 2MB
            if (Upload.Length > maxFileSize)
            {
                ModelState.AddModelError("Upload", "The file size should not exceed 5MB.");
                return Page();
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                await Upload.CopyToAsync(memoryStream);

                cv = new Cv(Upload.FileName, Upload.ContentType, memoryStream.ToArray());
            }
        }

        application = new Application(Jobseeker, Job, ApplicationStatus.Pending, DateTime.Now, cv);

        await _applicationService.AddApplicationAsync(application);

        return RedirectToPage("JobListing", new { jobId });
    }

    public async Task<IActionResult> OnPostSaveAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        int jobseekerId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        await _savedJobService.SaveOrUnsaveJobAsync(jobseekerId, jobId);

        return RedirectToPage("JobListing", new { jobId });
    }

    public async Task<IActionResult> OnPostEditAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        return RedirectToPage("/EmployerDashboard/EditJob", new { JobId });
    }

    public async Task<IActionResult> OnPostDeleteAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);

        return RedirectToPage("/EmployerDashboard/DeleteJob", new { JobId });
    }
}