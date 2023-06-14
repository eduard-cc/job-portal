using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JobPortalTest.FakeRepositories;

public class FakeJobRepository : IJobRepository
{
    private readonly List<Job> _jobs;
    public FakeJobRepository()
    {
        _jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        // Assign a new ID for the job
        int jobId = _jobs.Count > 0 ? _jobs.Max(j => j.Id) + 1 : 1;
        job.Id = jobId;

        // Add the job to the list
        _jobs.Add(job);
    }

    public List<Job> GetJobs()
    {
        return _jobs;
    }

    public async Task AddJobAsync(Job job, int employerId)
    {
        int jobId;
        if (_jobs.Count > 0)
        {
            // Get the max ID and increment by 1
            int maxId = _jobs.Max(j => j.Id);
            jobId = maxId + 1;
        }
        else
        {
            jobId = 1;
        }

        job.Employer.Id = employerId;
        job.Id = jobId;

        _jobs.Add(job);
    }

    public async Task<bool> CheckIfJobPostedByEmployerAsync(int employerId, int jobId)
    {
        return await Task.FromResult(_jobs.Any(j => j.Employer.Id == employerId && j.Id == jobId));
    }

    public async Task DeleteApplicationsAndSavedJobsByJobseekerIdAsync(int jobseekerId)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteJobsByEmployerIdAsync(int employerId)
    {
        // Delete jobs from the fake repository
        _jobs.RemoveAll(j => j.Employer.Id == employerId);
    }

    public async Task<List<Job>> GetAllJobsAsync()
    {
        return await Task.FromResult(_jobs);
    }

    public async Task<Job> GetJobByIdAsync(int jobId)
    {
        return await Task.FromResult(_jobs.FirstOrDefault(j => j.Id == jobId));
    }

    public async Task<List<Job>> GetJobsByEmployerIdAsync(int employerId)
    {
        return await Task.FromResult(_jobs.Where(j => j.Employer.Id == employerId).ToList());
    }

    public Task<List<Job>> SearchJobsAsync(string jobTitleOrCompany, string location)
    {
        List<Job> jobs = new List<Job>();

        if (!string.IsNullOrWhiteSpace(jobTitleOrCompany))
        {
            jobs = _jobs.Where(j => j.Title.Contains(jobTitleOrCompany) || j.Employer.CompanyName.Contains(jobTitleOrCompany)).ToList();
        }

        if (!string.IsNullOrWhiteSpace(location))
        {
            jobs = _jobs.Where(j => j.Employer.Location.Contains(location)).ToList();
        }

        return Task.FromResult(jobs);
    }

    public async Task UpdateJobDetailsAsync(Job job)
    {
        // Simulate asynchronous operation
        await Task.Delay(100);

        Job existingJob = _jobs.FirstOrDefault(j => j.Id == job.Id);
        existingJob.Title = job.Title;
        existingJob.Description = job.Description;
        existingJob.Salary = job.Salary;
        existingJob.ContractType = job.ContractType;
        existingJob.WorkArrangement = job.WorkArrangement;
    }

    public async Task<List<Job>> SearchJobsAsync(string jobTitleOrCompany, string location, int startIndex, int count)
    {
        throw new NotImplementedException();
    }

    public async Task<int> CountJobsAsync(string jobTitleOrCompany, string location)
    {
        try
        {
            IEnumerable<Job> filteredJobs = _jobs;

            if (!string.IsNullOrWhiteSpace(jobTitleOrCompany))
            {
                string searchTerm = jobTitleOrCompany.ToLowerInvariant();
                filteredJobs = filteredJobs.Where(job =>
                    job.Title.ToLowerInvariant().Contains(searchTerm) ||
                    job.Employer.CompanyName.ToLowerInvariant().Contains(searchTerm));
            }

            if (!string.IsNullOrWhiteSpace(location))
            {
                string searchLocation = location.ToLowerInvariant();
                filteredJobs = filteredJobs.Where(job =>
                    job.Employer.Location.ToLowerInvariant().Contains(searchLocation));
            }

            int totalCount = filteredJobs.Count();

            // Simulating a delay to mimic asynchronous behavior
            await Task.Delay(100);

            return totalCount;
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while counting the job data.", ex);
        }
    }

    public async Task<int> GetTotalJobCountAsync()
    {
        try
        {
            int totalCount = _jobs.Count();

            // Simulating a delay to mimic asynchronous behavior
            await Task.Delay(100);

            return totalCount;
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while retrieving the job data.", ex);
        }
    }

    public async Task DeleteJobByIdAsync(int jobId)
    {
        try
        {
            Job jobToRemove = _jobs.FirstOrDefault(j => j.Id == jobId);
            if (jobToRemove != null)
            {
                _jobs.Remove(jobToRemove);
            }

            // Simulating a delay to mimic asynchronous behavior
            await Task.Delay(100);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while deleting the job.", ex);
        }
    }
}
