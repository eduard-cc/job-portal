using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Xml.Linq;
using System.Security.Principal;
using JobPortalLogic.Exceptions;

namespace JobPortalWeb.Pages.UserSettings;

public class ChangeUserEmailModel : PageModel
{
    private readonly UserService _userService;

    [BindProperty]
    [Display(Name = "New Email")]
    [Required(ErrorMessage = "This field is required.")]
    [StringLength(254, ErrorMessage = "Must not exceed 254 characters.")]
    [EmailAddress(ErrorMessage = "Format is invalid.")]
    public string NewEmail { get; set; }

    [BindProperty]
    [Display(Name = "Current Password")]
    [Required(ErrorMessage = "This field is required.")]
    [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
    [StringLength(128, ErrorMessage = "Must not exceed 128 characters.")]
    public string CurrentPassword { get; set; }

    public ChangeUserEmailModel(UserService userService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        try
        {
            await _userService.ChangeUserEmailAsync(userId, NewEmail, CurrentPassword);
        }
        catch (EmailInUseException ex)
        {
            ModelState.AddModelError("EmailInUseError", ex.Message);
            return Page();
        }
        catch (IncorrectPasswordException ex)
        {
            ModelState.AddModelError("IncorrectPassword", ex.Message);
            return Page();
        }

        // Update claim

        var oldClaim = User.FindFirst(ClaimTypes.Name);
        ((ClaimsIdentity)User.Identity).RemoveClaim(oldClaim);

        var newClaim = new Claim(ClaimTypes.Name, NewEmail);
        ((ClaimsIdentity)User.Identity).AddClaim(newClaim);

        // Handle Sign out and in for claims to reflect the change

        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        var properties = new AuthenticationProperties
        {
            IsPersistent = true,
        };

        var claims = ((ClaimsIdentity)User.Identity).Claims.ToList();
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), properties);

        TempData["EmailUpdatedSuccessfully"] = "Email updated successfully!";
        return RedirectToPage("/UserSettings/UserAccountSettings");
    }
}
