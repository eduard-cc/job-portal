using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Services;

public class ApplicationService
{
    private readonly IApplicationRepository _applicationRepository;

    public ApplicationService(IApplicationRepository applicationRepository)
    {
        _applicationRepository = applicationRepository;
    }

    public async Task<Application?> GetApplicationByJobseekerAndJobIdAsync(int jobseekerId, int jobId)
    {
        return await _applicationRepository.GetApplicationByJobseekerAndJobIdAsync(jobseekerId, jobId);
    }

    public async Task AddApplicationAsync(Application application)
    {
        await _applicationRepository.AddApplicationAsync(application);
    }

    public async Task<List<Application>> GetAllApplicationsByJobIdAsync(int jobId)
    {
        return await _applicationRepository.GetAllApplicationsByJobIdAsync(jobId);
    }

    public async Task<List<Application>> GetAllApplicationsByJobseekerIdAsync(int jobseekerId)
    {
        return await _applicationRepository.GetAllApplicationsByJobseekerIdAsync(jobseekerId);
    }

    public async Task UpdateStatusOfApplicationAsync(int applicationId, ApplicationStatus applicationStatus)
    {
        await _applicationRepository.UpdateStatusOfApplicationAsync(applicationId, applicationStatus);
    }

    public async Task<Cv> GetCvByIdAsync(int cvId)
    {
        return await _applicationRepository.GetCvByIdAsync(cvId);
    }
}
