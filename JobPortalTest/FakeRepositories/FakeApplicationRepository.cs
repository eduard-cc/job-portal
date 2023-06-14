using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace JobPortalTest.FakeRepositories;

public class FakeApplicationRepository : IApplicationRepository
{
    private readonly List<Application> _applications;
    public FakeApplicationRepository()
    {
        _applications = new List<Application>();
    }

    public List<Application> GetAllApplications()
    {
        return _applications;
    }

    public Task AddApplicationAsync(Application application)
    {
        // Assign a new ID for the job
        int applicationId = _applications.Count > 0 ? _applications.Max(j => j.Id) + 1 : 1;
        application.Id = applicationId;

        // Add the job to the list
        _applications.Add(application);
        return Task.CompletedTask;
    }

    public Task<List<Application>> GetAllApplicationsByJobIdAsync(int jobId)
    {
        List<Application> applications = _applications.Where(a => a.Job.Id == jobId).ToList();

        return Task.FromResult(applications);
    }

    public Task<List<Application>> GetAllApplicationsByJobseekerIdAsync(int jobseekerId)
    {
        List<Application> applications = _applications.Where(a => a.Applicant.Id == jobseekerId).ToList();

        return Task.FromResult(applications);
    }

    public Task<Application?> GetApplicationByJobseekerAndJobIdAsync(int jobseekerId, int jobId)
    {
        Application? application = _applications.FirstOrDefault(a => a.Applicant.Id == jobseekerId && a.Job.Id == jobId);

        return Task.FromResult(application);
    }

    public Task<Cv> GetCvByIdAsync(int cvId)
    {
        Cv? cv = _applications.Where(a => a.Cv != null && a.Cv.Id == cvId).Select(a => a.Cv).FirstOrDefault();

        if (cv == null)
        {
            throw new Exception("CV not found.");
        }

        return Task.FromResult(cv);
    }

    public Task UpdateStatusOfApplicationAsync(int applicationId, ApplicationStatus applicationStatus)
    {
        Application application = _applications.FirstOrDefault(a => a.Id == applicationId);

        if (application != null)
        {
            application.Status = applicationStatus;
        }
        else
        {
            throw new Exception("Application not found.");
        }

        return Task.CompletedTask;
    }
}