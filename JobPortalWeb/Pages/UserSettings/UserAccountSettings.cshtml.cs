using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace JobPortalWeb.Pages.UserSettings;

public class UserAccountSettingsModel : PageModel
{
    private readonly UserService _userService;

    [BindProperty]
    public Jobseeker Jobseeker { get; set; }

    [BindProperty]
    public Employer Employer { get; set; }

    public UserAccountSettingsModel(UserService userService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        AccountType accountType = (AccountType)Enum.Parse(typeof(AccountType), User.FindFirst(ClaimTypes.Role).Value);

        if (accountType == AccountType.Jobseeker)
        {
            Jobseeker = (Jobseeker)await _userService.GetUserDetailsByIdAsync(userId, AccountType.Jobseeker);
        }
        else
        {
            Employer = (Employer)await _userService.GetUserDetailsByIdAsync(userId, AccountType.Employer);
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        AccountType accountType = (AccountType)Enum.Parse(typeof(AccountType), User.FindFirst(ClaimTypes.Role).Value);

        ClearValidationErrors(accountType);

        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (accountType == AccountType.Jobseeker)
        {
            Jobseeker.Id = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            await _userService.UpdateUserDetailsAsync(Jobseeker, accountType);
        }
        else
        {
            Employer.Id = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            await _userService.UpdateUserDetailsAsync(Employer, accountType);
        }
        TempData["ProfileUpdatedSuccessfully"] = "Profile updated successfully!";
        return Page();
    }

    public void ClearValidationErrors(AccountType accountType)
    {
        if (accountType == AccountType.Jobseeker)
        {
            ModelState.Remove("Jobseeker.Email");
            ModelState.Remove("Jobseeker.Password");
            ModelState.Remove("Jobseeker.Applications");
            ModelState.Remove("Jobseeker.SavedJobs");
            ModelState.Remove("CompanyName");
        }
        else
        {
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            ModelState.Remove("PhoneNumber");
            ModelState.Remove("Employer.Email");
            ModelState.Remove("Employer.Password");
            ModelState.Remove("Employer.Jobs");
        }
        ModelState.Remove("Email");
        ModelState.Remove("Location");
        ModelState.Remove("Password");
    }
}