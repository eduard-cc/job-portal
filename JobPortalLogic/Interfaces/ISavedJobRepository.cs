using JobPortalDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Interfaces;

public interface ISavedJobRepository
{
    Task<List<Job>> GetAllSavedJobsAsync(int jobseekerId);

    Task SaveJobAsync(int jobseekerId, int jobId);

    Task UnsaveJobAsync(int jobseekerId, int jobId);

    Task<bool> CheckIfJobSavedAsync(int jobseekerId, int jobId);
}