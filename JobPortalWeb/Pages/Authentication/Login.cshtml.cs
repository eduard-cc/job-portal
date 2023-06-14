using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using JobPortalLogic.Exceptions;

namespace JobPortalWeb.Pages.Authentication;

public class LoginModel : PageModel
{
    private readonly UserService _userService;
    private readonly PasswordService _passwordService;

    [BindProperty]
    public User User { get; set; }

    [BindProperty]
    public AccountType AccountType { get; set; }

    public LoginModel(UserService userService, PasswordService passwordService)
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
        ModelState.Remove("User.Location");
        if (!ModelState.IsValid)
        {
            return Page();
        }

        User user;
        try
        {
            user = await _userService.AuthenticateUser(User.Email, User.Password, AccountType);
        }
        catch (IncorrectCredentialsException ex)
        {
            ModelState.AddModelError("IncorrectEmailOrPassword", ex.Message);
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
}
