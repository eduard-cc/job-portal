using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Services;

public class SavedJobService
{
    private readonly ISavedJobRepository _savedJobRepository;

    public SavedJobService(ISavedJobRepository savedJobRepository)
    {
        _savedJobRepository = savedJobRepository;
    }

    public async Task<List<Job>> GetAllSavedJobsAsync(int jobseekerId)
    {
        return await _savedJobRepository.GetAllSavedJobsAsync(jobseekerId);
    }

    public async Task SaveOrUnsaveJobAsync(int jobseekerId, int jobId)
    {
        bool result = await _savedJobRepository.CheckIfJobSavedAsync(jobseekerId, jobId);

        if (result)
        {
            await _savedJobRepository.UnsaveJobAsync(jobseekerId, jobId);
        }
        else
        {
            await _savedJobRepository.SaveJobAsync(jobseekerId, jobId);
        }
    }

    public async Task<bool> CheckIfJobSavedAsync(int jobseekerId, int jobId)
    {
        bool saved = await _savedJobRepository.CheckIfJobSavedAsync(jobseekerId, jobId);
        return saved;
    }
}
