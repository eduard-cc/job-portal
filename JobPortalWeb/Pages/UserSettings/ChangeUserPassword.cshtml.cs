using JobPortalDomain.Models;
using JobPortalLogic.Exceptions;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Xml.Linq;

namespace JobPortalWeb.Pages.UserSettings;

public class ChangeUserPasswordModel : PageModel
{
    private readonly UserService _userService;

    [BindProperty]
    [Display(Name = "New Password")]
    [Required(ErrorMessage = "This field is required.")]
    [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
    [StringLength(128, ErrorMessage = "Must not exceed 128 characters.")]
    public string NewPassword { get; set; }

    [BindProperty]
    [Display(Name = "Confirm New Password")]
    [Required(ErrorMessage = "This field is required.")]
    [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
    [StringLength(128, ErrorMessage = "Must not exceed 128 characters.")]
    public string ConfirmNewPassword { get; set; }

    [BindProperty]
    [Display(Name = "Current Password")]
    [Required(ErrorMessage = "This field is required.")]
    [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
    [StringLength(128, ErrorMessage = "Must not exceed 128 characters.")]
    public string CurrentPassword { get; set; }

    public ChangeUserPasswordModel(UserService userService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (NewPassword != ConfirmNewPassword)
        {
            ModelState.AddModelError("PasswordsDontMatch", "These fields do not match.");
            return Page();
        }

        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        try
        {
            await _userService.ChangeUserPasswordAsync(userId, NewPassword, CurrentPassword);
        }
        catch (IncorrectPasswordException ex)
        {
            ModelState.AddModelError("IncorrectPassword", ex.Message);
            return Page();
        }

        // Log out user after password change
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToPage("/UserSettings/UserAccountSettings");
    }
}