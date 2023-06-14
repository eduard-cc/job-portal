using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalWeb.Pages.EmployerDashboard;

public class DownloadCvModel : PageModel
{
    private readonly ApplicationService _applicationService;

    public DownloadCvModel(ApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    public async Task<IActionResult> OnGetAsync(int cvId)
    {
        Cv cv = await _applicationService.GetCvByIdAsync(cvId);

        if (cv != null)
        {
            var stream = new MemoryStream(cv.Data);

            Response.Headers.Add("Content-Disposition", $"attachment; filename=\"{cv.Name}\"");
            Response.Headers.Add("Content-Type", cv.ContentType);

            return new FileStreamResult(stream, cv.ContentType);
        }

        // If the CV is not found, return a not found response
        return NotFound();
    }
}
