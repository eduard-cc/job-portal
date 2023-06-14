using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Interfaces;

public interface IJobRepository
{
    Task<List<Job>> SearchJobsAsync(string jobTitleOrCompany, string location, int startIndex, int count);

    Task<int> CountJobsAsync(string jobTitleOrCompany, string location);

    Task<List<Job>> GetAllJobsAsync();

    Task<Job> GetJobByIdAsync(int jobId);

    Task<bool> CheckIfJobPostedByEmployerAsync(int employerId, int jobId);

    Task<List<Job>> GetJobsByEmployerIdAsync(int employerId);

    Task AddJobAsync(Job job, int employerId);

    Task DeleteJobsByEmployerIdAsync(int employerId);

    Task DeleteApplicationsAndSavedJobsByJobseekerIdAsync(int jobseekerId);

    Task UpdateJobDetailsAsync(Job job);

    Task<int> GetTotalJobCountAsync();

    Task DeleteJobByIdAsync(int jobId);
}
