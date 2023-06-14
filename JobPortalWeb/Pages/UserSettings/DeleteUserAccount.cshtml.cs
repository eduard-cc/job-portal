using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace JobPortalWeb.Pages.UserSettings;

public class DeleteUserAccountModel : PageModel
{
    private readonly UserService _userService;

    public DeleteUserAccountModel(UserService userService)
    {
        _userService = userService;
    }
    public async Task<IActionResult> OnPostAsync()
    {
        int userId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        AccountType accountType = (AccountType)Enum.Parse(typeof(AccountType), User.FindFirst(ClaimTypes.Role).Value);

        await _userService.DeleteUserByIdAsync(userId, accountType);

        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToPage("/Index");
    }
}
