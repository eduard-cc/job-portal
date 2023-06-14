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
public class StatisticsServiceTests
{
    private readonly FakeStatisticsRepository _fakeStatisticsRepository;
    private readonly StatisticsService _statisticsService;

    public StatisticsServiceTests()
    {
        _fakeStatisticsRepository = new FakeStatisticsRepository();
        _statisticsService = new StatisticsService(_fakeStatisticsRepository);
    }

    [TestMethod]
    public async Task IncrementClicksByJobIdAsync_WithValidJobId_IncrementsClicks()
    {
        // Arrange
        var jobId = 1;
        var initialClicks = 5;
        var jobToUpdate = new Job { Id = jobId, Clicks = initialClicks };
        _fakeStatisticsRepository.AddJob(jobToUpdate);

        // Act
        await _statisticsService.IncrementClicksByJobIdAsync(jobId);

        // Assert
        var updatedJob = _fakeStatisticsRepository.GetJobById(jobId);
        Assert.AreEqual(initialClicks + 1, updatedJob.Clicks, "Clicks count should be incremented by 1.");
    }

    [TestMethod]
    public async Task IncrementClicksByJobIdAsync_WithInvalidJobId_DoesNotIncrementClicks()
    {
        // Arrange
        var jobId = 1;
        var initialClicks = 5;
        var jobToUpdate = new Job { Id = jobId, Clicks = initialClicks };
        _fakeStatisticsRepository.AddJob(jobToUpdate);

        // Act
        await _fakeStatisticsRepository.IncrementClicksByJobIdAsync(jobId + 1);

        // Assert
        var updatedJob = _fakeStatisticsRepository.GetJobById(jobId);
        Assert.AreEqual(initialClicks, updatedJob.Clicks, "Clicks count should remain unchanged.");
    }

    [TestMethod]
    public async Task GetJobStatisticsAsync_WithValidJobId_ReturnsStatistics()
    {
        // Arrange
        int jobId = 1;

        // Add a sample job to the repository
        Job job = new Job { Id = jobId };
        _fakeStatisticsRepository.AddJob(job);

        // Add some sample data for statistics
        job.Clicks = 100;
        _fakeStatisticsRepository.IncrementClicksByJobIdAsync(jobId).Wait();
        _fakeStatisticsRepository.IncrementClicksByJobIdAsync(jobId).Wait();

        _fakeStatisticsRepository.AddSavedJob(job);
        _fakeStatisticsRepository.AddSavedJob(job);

        _fakeStatisticsRepository.AddApplication(new Application { Job = job, Cv = null });
        _fakeStatisticsRepository.AddApplication(new Application { Job = job, Cv = new Cv() });
        _fakeStatisticsRepository.AddApplication(new Application { Job = job, Cv = new Cv() });
        _fakeStatisticsRepository.AddApplication(new Application { Job = job, Cv = new Cv() });

        // Act
        Statistics statistics = await _statisticsService.GetJobStatisticsAsync(jobId);

        // Assert
        Assert.AreEqual(102, statistics.ClicksCount);
        Assert.AreEqual(2, statistics.SavedCount);
        Assert.AreEqual(3, statistics.ApplicationsWithCv);
        Assert.AreEqual(1, statistics.ApplicationsWithoutCv);
        Assert.AreEqual("75%", statistics.SubmittedCvRate);
    }

    [TestMethod]
    public async Task GetJobStatisticsAsync_WithZeroTotalApplications_ReturnsStatisticsWithNAConversionRateAndNASubmittedCvRate()
    {
        // Arrange
        int jobId = 1;

        // Add a sample job to the repository
        Job job = new Job { Id = jobId };
        _fakeStatisticsRepository.AddJob(job);

        // Add some sample data for statistics
        job.Clicks = 50;
        _fakeStatisticsRepository.IncrementClicksByJobIdAsync(jobId).Wait();
        _fakeStatisticsRepository.IncrementClicksByJobIdAsync(jobId).Wait();

        _fakeStatisticsRepository.AddSavedJob(job);
        _fakeStatisticsRepository.AddSavedJob(job);

        // Act
        Statistics statistics = await _statisticsService.GetJobStatisticsAsync(jobId);

        // Assert
        Assert.AreEqual(52, statistics.ClicksCount);
        Assert.AreEqual(2, statistics.SavedCount);
        Assert.AreEqual(0, statistics.ApplicationsWithCv);
        Assert.AreEqual(0, statistics.ApplicationsWithoutCv);
        Assert.AreEqual("N/A", statistics.ConversionRate);
        Assert.AreEqual("N/A", statistics.SubmittedCvRate);
    }

    [TestMethod]
    public async Task GetJobStatisticsAsync_TotalApplicationsIsZero_ReturnsStatisticsWithNARates()
    {
        // Arrange
        int jobId = 1;
        var job = new Job { Id = jobId };
        _fakeStatisticsRepository.AddJob(job);

        // Act
        Statistics statistics = await _statisticsService.GetJobStatisticsAsync(jobId);

        // Assert
        Assert.AreEqual(0, statistics.TotalApplications);
        Assert.AreEqual("N/A", statistics.ConversionRate);
        Assert.AreEqual("N/A", statistics.SubmittedCvRate);
    }

    [TestMethod]
    public async Task GetJobStatisticsAsync_TotalApplicationsNonZeroButClicksCountIsZero_ReturnsStatisticsWithNARateForConversionRate()
    {
        // Arrange
        int jobId = 1;
        var job = new Job { Id = jobId };
        _fakeStatisticsRepository.AddJob(job);
        _fakeStatisticsRepository.AddApplication(new Application { Job = job, Cv = null });

        // Act
        Statistics statistics = await _statisticsService.GetJobStatisticsAsync(jobId);

        // Assert
        Assert.AreEqual(1, statistics.TotalApplications);
        Assert.AreEqual("N/A", statistics.ConversionRate);
        Assert.AreEqual("N/A", statistics.SubmittedCvRate);
    }

    [TestMethod]
    public async Task GetJobStatisticsAsync_TotalApplicationsAndClicksCountNonZero_CalculatesConversionRateAndSubmittedCvRate()
    {
        // Arrange
        int jobId = 1;
        var job = new Job { Id = jobId };
        _fakeStatisticsRepository.AddJob(job);
        _fakeStatisticsRepository.AddApplication(new Application { Job = job, Cv = null });
        _fakeStatisticsRepository.IncrementClicksByJobIdAsync(jobId).Wait();

        // Act
        Statistics statistics = await _statisticsService.GetJobStatisticsAsync(jobId);

        // Assert
        Assert.AreEqual(1, statistics.TotalApplications);
        Assert.AreEqual("100,0%", statistics.ConversionRate);
        Assert.AreEqual("0%", statistics.SubmittedCvRate);
    }
}
