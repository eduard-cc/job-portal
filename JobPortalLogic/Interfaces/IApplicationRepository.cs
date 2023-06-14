using JobPortalDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Interfaces;

public interface IApplicationRepository
{
    Task AddApplicationAsync(Application application);

    Task<List<Application>> GetAllApplicationsByJobseekerIdAsync(int jobseekerId);

    Task<List<Application>> GetAllApplicationsByJobIdAsync(int jobId);

    Task<Application?> GetApplicationByJobseekerAndJobIdAsync(int jobseekerId, int jobId);

    Task UpdateStatusOfApplicationAsync(int applicationId, ApplicationStatus applicationStatus);

    Task<Cv> GetCvByIdAsync(int cvId);
}