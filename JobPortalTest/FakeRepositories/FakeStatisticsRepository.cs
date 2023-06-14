using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Application = JobPortalDomain.Models.Application;

namespace JobPortalTest.FakeRepositories;

public class FakeStatisticsRepository : IStatisticsRepository
{
    private readonly List<Job> _jobs;
    private readonly List<Job> _savedJobs;
    private readonly List<Application> _applications;

    public FakeStatisticsRepository()
    {
        _jobs = new List<Job>();
        _savedJobs = new List<Job>();
        _applications = new List<Application>();
    }

    public async Task<(int applicationsWithoutCv, int applicationsWithCv)> GetApplicationCountByJobIdAsync(int jobId)
    {
        int applicationsWithoutCv = _applications.Count(app => app.Job.Id == jobId && app.Cv?.Id == null);
        int applicationsWithCv = _applications.Count(app => app.Job.Id == jobId && app.Cv?.Id != null);

        // Simulating a delay to mimic asynchronous behavior
        await Task.Delay(100);

        return (applicationsWithoutCv, applicationsWithCv);
    }

    public async Task<int> GetClickCountByJobIdAsync(int jobId)
    {
        Job job = _jobs.FirstOrDefault(j => j.Id == jobId);
        if (job != null)
        {
            return job.Clicks;
        }
        else
        {
            throw new Exception("Job not found.");
        }
    }

    public async Task<int> GetSavedCountByJobIdAsync(int jobId)
    {
        int savedCount = _savedJobs.Count(job => job.Id == jobId);

        return savedCount;
    }

    public async Task IncrementClicksByJobIdAsync(int jobId)
    {
        Job jobToUpdate = _jobs.FirstOrDefault(job => job.Id == jobId);

        if (jobToUpdate != null)
        {
            jobToUpdate.Clicks++;
        }
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void AddSavedJob(Job job)
    {
        _savedJobs.Add(job);
    }

    public void AddApplication(Application application)
    {
        _applications.Add(application);
    }

    public Job GetJobById(int jobId)
    {
        return _jobs.FirstOrDefault(job => job.Id == jobId);
    }
}
