using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Services;

public class JobService
{
    private readonly IJobRepository _jobRepository;

    public JobService(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<List<Job>> SearchJobsAsync(string jobTitleOrCompany, string location, int startIndex, int count)
    {
        return await _jobRepository.SearchJobsAsync(jobTitleOrCompany, location, startIndex, count);
    }

    public async Task<int> CountJobsAsync(string jobTitleOrCompany, string location)
    {
        return await _jobRepository.CountJobsAsync(jobTitleOrCompany, location);
    }

    public async Task<Job> GetJobByIdAsync(int jobId)
    {
        return await _jobRepository.GetJobByIdAsync(jobId);
    }

    public async Task<List<Job>> GetJobsByEmployerIdAsync(int employerId)
    {
        return await _jobRepository.GetJobsByEmployerIdAsync(employerId);
    }

    public async Task<bool> CheckIfJobPostedByEmployerAsync(int employerId, int jobId)
    {
        return await _jobRepository.CheckIfJobPostedByEmployerAsync(employerId, jobId);
    }

    public async Task AddJobAsync(Job job, int employerId)
    {
        await _jobRepository.AddJobAsync(job, employerId);
    }

    public async Task UpdateJobDetailsAsync(Job job)
    {
        await _jobRepository.UpdateJobDetailsAsync(job);
    }

    public async Task<int> GetTotalJobCountAsync()
    {
        return await _jobRepository.GetTotalJobCountAsync();
    }

    public async Task DeleteJobByIdAsync(int jobId)
    {
        await _jobRepository.DeleteJobByIdAsync(jobId);
    }
}