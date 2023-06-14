using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using JobPortalWeb.Pages.Authentication;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.Xml;

namespace JobPortalWeb.Pages.EmployerDashboard;

public class PostJobModel : PageModel
{
    private readonly UserService _userService;
    private readonly JobService _jobService;

    [BindProperty]
    public Job Job { get; set; }

    public Employer Employer { get; set; }

    public PostJobModel(UserService userService, JobService jobService)
    {
        _userService = userService;
        _jobService = jobService;
        Employer = new Employer();
    }

    public async Task<IActionResult> OnGetAsync()
    {
        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        Employer = (Employer)await _userService.GetUserDetailsByIdAsync(userId, AccountType.Employer);

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        ClearValidationErrors();
        if (!ModelState.IsValid)
        {
            return Page();
        }

        int employerId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        Job.DatePosted = DateTime.Now;
        Job.Clicks = 1;

        await _jobService.AddJobAsync(Job, employerId);

        TempData["JobPosted"] = "Job posted successfully!";
        return RedirectToPage("/EmployerDashboard/EmployerJobs");
    }

    public void ClearValidationErrors()
    {
        ModelState.Remove("Job.Applications");
        ModelState.Remove("Job.Employer");

        if (Job.Salary.Type == SalaryType.ExactAmount)
        {
            ModelState.Remove("Job.Salary.MinAmount");
            ModelState.Remove("Job.Salary.MaxAmount");
        }
        else
        {
            ModelState.Remove("Job.Salary.Amount");
        }
    }
}
