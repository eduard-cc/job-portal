using JobPortalDomain.Models;
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
public class ApplicationServiceTests
{
    public readonly FakeApplicationRepository _fakeApplicationRepository;
    public readonly ApplicationService _applicationService;
    public ApplicationServiceTests()
    {
        _fakeApplicationRepository = new FakeApplicationRepository();
        _applicationService = new ApplicationService(_fakeApplicationRepository);
    }

    [TestMethod]
    public async Task GetApplicationByJobseekerAndJobIdAsync_ExistingApplication_ReturnsApplication()
    {
        // Arrange
        int jobseekerId = 1;
        int jobId = 2;
        var application = new Application
        {
            Id = 1,
            Applicant = new Jobseeker { Id = jobseekerId },
            Job = new Job { Id = jobId }
        };
        await _fakeApplicationRepository.AddApplicationAsync(application);

        // Act
        Application? result = await _applicationService.GetApplicationByJobseekerAndJobIdAsync(jobseekerId, jobId);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(application.Id, result.Id);
    }

    [TestMethod]
    public async Task GetApplicationByJobseekerAndJobIdAsync_NonExistingApplication_ReturnsNull()
    {
        // Arrange
        int jobseekerId = 1;
        int jobId = 2;

        // Act
        Application? result = await _applicationService.GetApplicationByJobseekerAndJobIdAsync(jobseekerId, jobId);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task AddApplicationAsync_ValidApplication_ApplicationAddedSuccessfully()
    {
        // Arrange
        var application = new Application
        {
            // Set the properties of the application as needed
            Applicant = new Jobseeker { Id = 1 },
            Job = new Job { Id = 2 },
            Status = ApplicationStatus.Pending,
            DateApplied = DateTime.Now
        };

        // Act
        await _applicationService.AddApplicationAsync(application);

        // Assert
        List<Application> applications = _fakeApplicationRepository.GetAllApplications();
        Assert.AreEqual(1, applications.Count);
        Assert.AreEqual(application, applications[0]);
    }

    [TestMethod]
    public async Task GetAllApplicationsByJobIdAsync_ValidJobId_ReturnsApplications()
    {
        // Arrange
        int jobId = 1;

        var application1 = new Application { Id = 1, Job = new Job { Id = jobId } };
        var application2 = new Application { Id = 2, Job = new Job { Id = jobId } };
        var application3 = new Application { Id = 3, Job = new Job { Id = 2 } }; // Application with a different job ID

        await _fakeApplicationRepository.AddApplicationAsync(application1);
        await _fakeApplicationRepository.AddApplicationAsync(application2);
        await _fakeApplicationRepository.AddApplicationAsync(application3);

        // Act
        List<Application> result = await _applicationService.GetAllApplicationsByJobIdAsync(jobId);

        // Assert
        Assert.AreEqual(2, result.Count);
        CollectionAssert.Contains(result, application1);
        CollectionAssert.Contains(result, application2);
    }

    [TestMethod]
    public async Task GetAllApplicationsByJobIdAsync_InvalidJobId_ReturnsEmptyList()
    {
        // Arrange
        int jobId = 1;

        var application1 = new Application { Id = 1, Job = new Job { Id = 2 } };
        var application2 = new Application { Id = 2, Job = new Job { Id = 3 } };

        await _fakeApplicationRepository.AddApplicationAsync(application1);
        await _fakeApplicationRepository.AddApplicationAsync(application2);

        // Act
        List<Application> result = await _applicationService.GetAllApplicationsByJobIdAsync(jobId);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task GetAllApplicationsByJobseekerIdAsync_ValidJobseekerId_ReturnsApplications()
    {
        // Arrange
        int jobseekerId = 1;

        var application1 = new Application { Id = 1, Applicant = new Jobseeker { Id = jobseekerId } };
        var application2 = new Application { Id = 2, Applicant = new Jobseeker { Id = jobseekerId } };
        var application3 = new Application { Id = 3, Applicant = new Jobseeker { Id = 2 } }; // Application with a different jobseeker ID

        await _fakeApplicationRepository.AddApplicationAsync(application1);
        await _fakeApplicationRepository.AddApplicationAsync(application2);
        await _fakeApplicationRepository.AddApplicationAsync(application3);

        // Act
        List<Application> result = await _applicationService.GetAllApplicationsByJobseekerIdAsync(jobseekerId);

        // Assert
        Assert.AreEqual(2, result.Count);
        CollectionAssert.Contains(result, application1);
        CollectionAssert.Contains(result, application2);
    }

    [TestMethod]
    public async Task GetAllApplicationsByJobseekerIdAsync_InvalidJobseekerId_ReturnsEmptyList()
    {
        // Arrange
        int jobseekerId = 1;

        var application1 = new Application { Id = 1, Applicant = new Jobseeker { Id = 2 } };
        var application2 = new Application { Id = 2, Applicant = new Jobseeker { Id = 3 } };

        await _fakeApplicationRepository.AddApplicationAsync(application1);
        await _fakeApplicationRepository.AddApplicationAsync(application2);

        // Act
        List<Application> result = await _applicationService.GetAllApplicationsByJobseekerIdAsync(jobseekerId);

        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task UpdateStatusOfApplicationAsync_ValidApplicationId_UpdatesStatus()
    {
        // Arrange
        int applicationId = 1;

        var application = new Application { Id = applicationId, Status = ApplicationStatus.Pending };

        await _fakeApplicationRepository.AddApplicationAsync(application);

        // Act
        await _applicationService.UpdateStatusOfApplicationAsync(applicationId, ApplicationStatus.Accepted);

        // Assert
        Assert.AreEqual(ApplicationStatus.Accepted, application.Status);
    }

    [TestMethod]
    public async Task UpdateStatusOfApplicationAsync_InvalidApplicationId_ThrowsException()
    {
        // Arrange
        int applicationId = 1;
        var fakeRepository = new FakeApplicationRepository();
        var service = new ApplicationService(fakeRepository);

        // Act and Assert
        await Assert.ThrowsExceptionAsync<Exception>(
            async () => await service.UpdateStatusOfApplicationAsync(applicationId, ApplicationStatus.Accepted)
        );
    }

    [TestMethod]
    public async Task GetCvByIdAsync_ExistingCvId_ReturnsCv()
    {
        // Arrange
        int cvId = 1;

        var cv = new Cv { Id = cvId, ContentType = "application/pdf", Name = "cv.pdf", Data = new byte[0] };

        await _fakeApplicationRepository.AddApplicationAsync(new Application { Cv = cv });

        // Act
        var result = await _applicationService.GetCvByIdAsync(cvId);

        // Assert
        Assert.AreEqual(cv, result);
    }

    [TestMethod]
    public async Task GetCvByIdAsync_NonExistingCvId_ThrowsException()
    {
        // Arrange
        int cvId = 1;

        // Act and Assert
        await Assert.ThrowsExceptionAsync<Exception>(
            async () => await _applicationService.GetCvByIdAsync(cvId)
        );
    }
}
