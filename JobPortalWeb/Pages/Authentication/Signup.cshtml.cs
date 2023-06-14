using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalInfrastructure.Repositories;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks.Dataflow;
using JobPortalLogic.Exceptions;

namespace JobPortalWeb.Pages.Authentication;

public class SignupModel : PageModel
{
    private readonly UserService _userService;
    private readonly PasswordService _passwordService;

    [BindProperty]
    public User User { get; set; }

    [BindProperty]
    public Jobseeker Jobseeker { get; set; }

    [BindProperty]
    public Employer Employer { get; set; }

    [BindProperty]
    public AccountType AccountType { get; set; }

    public SignupModel(UserService userService, PasswordService passwordService)
    {
        _userService = userService;
        _passwordService = passwordService;
    }

    public IActionResult OnGet()
    {
        if (base.User.Identity.IsAuthenticated)
        {
            return RedirectToPage("/Index");
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string? returnUrl)
    {
        User user;
        if (AccountType == AccountType.Jobseeker)
        {
            user = SetJobseekerCredentials();
            ClearValidationErrorsForAccountType(AccountType.Employer);
        }
        else
        {
            user = SetEmployerCredentials();
            ClearValidationErrorsForAccountType(AccountType.Jobseeker);
        }

        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            // Handle account creation and return the Id to be used by ClaimTypes.NameIdentifier
            user.Id = await _userService.CreateUserAccountAsync(user, AccountType);
        }
        catch (EmailInUseException ex)
        {
            ModelState.AddModelError("EmailInUseError", ex.Message);
            return Page();
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Email),
            new Claim(ClaimTypes.Role, AccountType.ToString())
        };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var properties = new AuthenticationProperties
        {
            IsPersistent = true,
            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
        };

        // Sign in user
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), properties);

        if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }
        else
        {
            return RedirectToPage("/Index");
        }
    }

    // Assign common properties User.Email and User.Password to the appropriate object

    public Jobseeker SetJobseekerCredentials()
    {
        Jobseeker.Email = User.Email;
        Jobseeker.Password = User.Password;
        return Jobseeker;
    }

    public Employer SetEmployerCredentials()
    {
        Employer.Email = User.Email;
        Employer.Password = User.Password;
        return Employer;
    }

    public void ClearValidationErrorsForAccountType(AccountType accountType)
    {
        foreach (var key in ModelState.Keys.ToList())
        {
            // Remove ModelState keys that start with the accountType
            if (key.StartsWith(accountType.ToString()))
            {
                ModelState.Remove(key);
            }
        }

        // Remove any errors for common properties since [User.Email] and [User.Password] are used for validation
        // And remove any other unnecessary errors
        switch (accountType)
        {
            case AccountType.Jobseeker:
                ModelState.Remove("Employer.Email");
                ModelState.Remove("Employer.Password");
                ModelState.Remove("Employer.Jobs");
                break;

            case AccountType.Employer:
                ModelState.Remove("Jobseeker.Email");
                ModelState.Remove("Jobseeker.Password");
                ModelState.Remove("Jobseeker.Applications");
                ModelState.Remove("Jobseeker.SavedJobs");
                break;
        }

        // [Jobseeker.Location] or [Employer.Location] are used for validation
        ModelState.Remove("User.Location");
    }
}
