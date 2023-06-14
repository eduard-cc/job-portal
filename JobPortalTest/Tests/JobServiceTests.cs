using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using JobPortalLogic.Services;
using JobPortalTest.FakeRepositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalTest.Tests;

[TestClass]
public class JobServiceTests
{
    private readonly FakeJobRepository _fakeJobRepository;
    private readonly JobService _jobService;

    public JobServiceTests()
    {
        _fakeJobRepository = new FakeJobRepository();
        _jobService = new JobService(_fakeJobRepository);
    }

    [TestMethod]
    public async Task GetJobByIdAsync_ValidId_ReturnsJob()
    {
        // Arrange
        int jobId = 1;
        Job expectedJob = new Job
        {
            Id = jobId,
            Title = "Software Developer",
            Description = "Job description",
            Salary = new Salary(),
            DatePosted = DateTime.Now,
            ContractType = ContractType.FullTime,
            WorkArrangement = WorkArrangement.Remote,
        };
        _fakeJobRepository.AddJob(expectedJob);

        // Act
        Job actualJob = await _jobService.GetJobByIdAsync(jobId);

        // Assert
        Assert.IsNotNull(actualJob);
        Assert.AreEqual(expectedJob.Id, actualJob.Id);
        Assert.AreEqual(expectedJob.Title, actualJob.Title);
        Assert.AreEqual(expectedJob.Description, actualJob.Description);
    }

    [TestMethod]
    public async Task GetJobByIdAsync_NonExistingId_ReturnsNull()
    {
        // Arrange
        Job expectedJob = new Job
        {
            Id = 1, // Set a different ID to simulate non-existing job
            Title = "Software Developer",
            Description = "Job description",
            Salary = new Salary(),
            DatePosted = DateTime.Now,
            ContractType = ContractType.FullTime,
            WorkArrangement = WorkArrangement.Remote,
        };
        _fakeJobRepository.AddJob(expectedJob);

        // Act
        Job actualJob = await _jobService.GetJobByIdAsync(2);

        // Assert
        Assert.IsNull(actualJob);
    }

    [TestMethod]
    public async Task GetJobsByEmployerId_ValidEmployerId_ReturnsMatchingJobs()
    {
        // Arrange
        // Create fake jobs for testing
        List<Job> fakeJobs = new List<Job>
        {
            new Job
            {
                Id = 1,
                Employer = new Employer { Id = 1, CompanyName = "Employer 1" },
                Title = "Job 1",
                Description = "Job 1 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.FullTime,
                WorkArrangement = WorkArrangement.Remote,
            },
            new Job
            {
                Id = 2,
                Employer = new Employer { Id = 1, CompanyName = "Employer 1" },
                Title = "Job 2",
                Description = "Job 2 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.PartTime,
                WorkArrangement = WorkArrangement.OnSite,
            },
            new Job
            {
                Id = 3,
                Employer = new Employer { Id = 2, CompanyName = "Employer 2" },
                Title = "Job 3",
                Description = "Job 3 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.FullTime,
                WorkArrangement = WorkArrangement.OnSite,
            }
        };

        foreach (Job fakeJob in fakeJobs)
        {
            _fakeJobRepository.AddJob(fakeJob);
        }

        int employerId = 1;

        // Act
        List<Job> result = await _jobService.GetJobsByEmployerIdAsync(employerId);

        // Assert
        Assert.IsNotNull(result);
        CollectionAssert.AllItemsAreNotNull(result);
        CollectionAssert.AllItemsAreInstancesOfType(result, typeof(Job));
        Assert.AreEqual(2, result.Count);
        Assert.IsTrue(result.All(j => j.Employer.Id == employerId));
    }

    [TestMethod]
    public async Task GetJobsByEmployerIdAsync_NoMatchingJobs_ReturnsEmptyList()
    {
        // Arrange
        // Create fake jobs for testing
        List<Job> fakeJobs = new List<Job>
        {
            new Job
            {
                Id = 1,
                Employer = new Employer { Id = 1, CompanyName = "Employer 1" },
                Title = "Job 1",
                Description = "Job 1 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.FullTime,
                WorkArrangement = WorkArrangement.Remote,
            },
            new Job
            {
                Id = 2,
                Employer = new Employer { Id = 1, CompanyName = "Employer 1" },
                Title = "Job 2",
                Description = "Job 2 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.PartTime,
                WorkArrangement = WorkArrangement.OnSite,
            },
            new Job
            {
                Id = 3,
                Employer = new Employer { Id = 2, CompanyName = "Employer 2" },
                Title = "Job 3",
                Description = "Job 3 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.FullTime,
                WorkArrangement = WorkArrangement.OnSite,
            }
        };

        foreach (Job fakeJob in fakeJobs)
        {
            _fakeJobRepository.AddJob(fakeJob);
        }

        int employerId = 3; // Set an employer ID that has no matching jobs

        // Act
        List<Job> result = await _fakeJobRepository.GetJobsByEmployerIdAsync(employerId);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task CheckIfJobPostedByEmployer_JobPostedByEmployer_ReturnsTrue()
    {
        // Arrange
        int employerId = 1;
        int jobId = 1;
        bool expected = true;

        Job job = new Job
        {
            Id = jobId,
            Employer = new Employer { Id = employerId },
            Title = "Software Developer",
            Description = "Job description",
            Salary = new Salary(),
            DatePosted = DateTime.Now,
            ContractType = ContractType.FullTime,
            WorkArrangement = WorkArrangement.Remote,
            Applications = new List<Application>()
        };

        _fakeJobRepository.AddJob(job);

        // Act
        bool actual = await _fakeJobRepository.CheckIfJobPostedByEmployerAsync(employerId, jobId);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public async Task CheckIfJobPostedByEmployer_JobNotPostedByEmployer_ReturnsFalse()
    {
        // Arrange
        int employerId = 1;
        int jobId = 2;
        bool expected = false;

        // Act
        bool actual = await _jobService.CheckIfJobPostedByEmployerAsync(employerId, jobId);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public async Task AddJobAsync_ValidJob_AddsJobToRepository()
    {
        // Arrange
        int employerId = 1;
        Job job = new Job
        {
            Employer = new Employer(),
            Title = "Software Developer",
            Description = "Job description",
            Salary = new Salary(),
            DatePosted = DateTime.Now,
            ContractType = ContractType.FullTime,
            WorkArrangement = WorkArrangement.Remote,
            Applications = new List<Application>()
        };

        int initialJobCount = _fakeJobRepository.GetJobs().Count;

        // Act
        await _jobService.AddJobAsync(job, employerId);

        // Assert
        int finalJobCount = _fakeJobRepository.GetJobs().Count;
        Assert.AreEqual(initialJobCount + 1, finalJobCount);

        Job addedJob = _fakeJobRepository.GetJobs().LastOrDefault();
        Assert.IsNotNull(addedJob);
        Assert.AreEqual(job.Title, addedJob.Title);
        Assert.AreEqual(job.Description, addedJob.Description);
        Assert.AreEqual(employerId, addedJob.Employer.Id);
    }

    [TestMethod]
    public async Task UpdateJobDetailsAsync_ValidJob_UpdatesJobDetails()
    {
        // Arrange
        int jobId = 1;
        Job job = new Job
        {
            Id = jobId,
            Title = "Software Developer",
            Description = "Job description",
            Salary = new Salary(),
            ContractType = ContractType.FullTime,
            WorkArrangement = WorkArrangement.Remote
        };

        // Add the job to the repository
        _fakeJobRepository.AddJob(job);

        // Create the updated job details
        Job updatedJob = new Job
        {
            Id = jobId,
            Title = "Updated Job Title",
            Description = "Updated Job Description",
            Salary = new Salary(),
            ContractType = ContractType.PartTime,
            WorkArrangement = WorkArrangement.OnSite
        };

        // Act
        await _jobService.UpdateJobDetailsAsync(updatedJob);

        // Assert
        Job modifiedJob = await _fakeJobRepository.GetJobByIdAsync(jobId);
        Assert.IsNotNull(modifiedJob);
        Assert.AreEqual(updatedJob.Title, modifiedJob.Title);
        Assert.AreEqual(updatedJob.Description, modifiedJob.Description);
        Assert.AreEqual(updatedJob.Salary, modifiedJob.Salary);
        Assert.AreEqual(updatedJob.ContractType, modifiedJob.ContractType);
        Assert.AreEqual(updatedJob.WorkArrangement, modifiedJob.WorkArrangement);
    }

    [TestMethod]
    public async Task DeleteJobByIdAsync_ValidId_JobRemoved()
    {
        // Arrange
        int jobId = 1;
        Job job = new Job { Id = jobId, Title = "Software Developer" };
        _fakeJobRepository.AddJob(job);

        // Act
        await _fakeJobRepository.DeleteJobByIdAsync(jobId);

        // Assert
        Job deletedJob = await _fakeJobRepository.GetJobByIdAsync(jobId);
        Assert.IsNull(deletedJob);
    }

    [TestMethod]
    public async Task GetTotalJobCountAsync_JobsExist_ReturnsTotalCount()
    {
        List<Job> fakeJobs = new List<Job>
        {
            new Job
            {
                Id = 1,
                Employer = new Employer { Id = 1, CompanyName = "Employer 1" },
                Title = "Job 1",
                Description = "Job 1 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.FullTime,
                WorkArrangement = WorkArrangement.Remote,
            },
            new Job
            {
                Id = 2,
                Employer = new Employer { Id = 1, CompanyName = "Employer 1" },
                Title = "Job 2",
                Description = "Job 2 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.PartTime,
                WorkArrangement = WorkArrangement.OnSite,
            },
            new Job
            {
                Id = 3,
                Employer = new Employer { Id = 2, CompanyName = "Employer 2" },
                Title = "Job 3",
                Description = "Job 3 Description",
                Salary = new Salary(),
                DatePosted = DateTime.Now,
                ContractType = ContractType.FullTime,
                WorkArrangement = WorkArrangement.OnSite,
            }
        };
        foreach (Job job in fakeJobs)
        {
            _fakeJobRepository.AddJob(job);
        }

        // Act
        int totalCount = await _jobService.GetTotalJobCountAsync();

        // Assert
        Assert.AreEqual(3, totalCount);
    }
}