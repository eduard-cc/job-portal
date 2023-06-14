using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace JobPortalWeb.Pages.EmployerDashboard;

public class EditJobModel : PageModel
{
    private readonly UserService _userService;
    private readonly JobService _jobService;

    [BindProperty]
    public Job Job { get; set; }

    public Employer Employer { get; set; }

    public EditJobModel(UserService userService, JobService jobService)
    {
        _userService = userService;
        _jobService = jobService;
    }

    public async Task<IActionResult> OnGetAsync(int jobId)
    {
        Job = await _jobService.GetJobByIdAsync(jobId);
        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        Employer = (Employer)await _userService.GetUserDetailsByIdAsync(userId, AccountType.Employer);

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int jobId)
    {
        ClearValidationErrors();

        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        Employer = (Employer)await _userService.GetUserDetailsByIdAsync(userId, AccountType.Employer);
        Job.Id = jobId;

        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _jobService.UpdateJobDetailsAsync(Job);

        TempData["JobEdited"] = "Job edited successfully!";
        return RedirectToPage("/JobListing", new { jobId });
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
