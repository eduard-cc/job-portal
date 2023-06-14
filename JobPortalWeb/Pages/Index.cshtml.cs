using JobPortalDomain.Models;
using JobPortalLogic.Extensions;
using JobPortalLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalWeb.Pages;

public class IndexModel : PageModel
{
    private readonly JobService _jobService;

    [BindProperty(SupportsGet = true)]
    public string? JobTitleOrCompany { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Location { get; set; }

    [BindProperty]
    public PaginatedList<Job> Jobs { get; set; }

    public int TotalCount { get; set; }

    public IndexModel(JobService jobService)
    {
        _jobService = jobService;
    }

    public async Task OnGetAsync(int? pageIndex)
    {
        var jobTitleOrCompany = HttpContext.Request.Query["jobTitleOrCompany"].ToString();
        var location = HttpContext.Request.Query["location"].ToString();

        int pageSize = 10; // Number of jobs to fetch per page

        if (String.IsNullOrWhiteSpace(jobTitleOrCompany) && String.IsNullOrWhiteSpace(location))
        {
            TotalCount = await _jobService.GetTotalJobCountAsync();
        }
        else
        {
            TotalCount = await _jobService.CountJobsAsync(jobTitleOrCompany, location);
        }

        // Calculate the start index and the number of items to fetch based on the page index
        int startIndex = ((pageIndex.HasValue ? pageIndex.Value : 1) - 1) * pageSize;

        List<Job> jobs = await _jobService.SearchJobsAsync(jobTitleOrCompany, location, startIndex, pageSize);

        Jobs = new PaginatedList<Job>(jobs, pageIndex.HasValue ? pageIndex.Value : 1, pageSize, TotalCount);

        JobTitleOrCompany = jobTitleOrCompany;
        Location = location;
    }
}