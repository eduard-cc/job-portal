using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Services;

public class StatisticsService
{
    private readonly IStatisticsRepository _statisticsRepository;

    public StatisticsService(IStatisticsRepository statisticsRepository)
    {
        _statisticsRepository = statisticsRepository;
    }

    public async Task<Statistics> GetJobStatisticsAsync(int jobId)
    {
        // Get statistics
        int clicksCount = await _statisticsRepository.GetClickCountByJobIdAsync(jobId);
        int savedCount = await _statisticsRepository.GetSavedCountByJobIdAsync(jobId);
        (int applicationsWithoutCv, int applicationsWithCv) = await _statisticsRepository.GetApplicationCountByJobIdAsync(jobId);

        Statistics statistics = new Statistics(clicksCount, savedCount, applicationsWithCv, applicationsWithoutCv);

        if (statistics.TotalApplications == 0 || statistics.ClicksCount == 0)
        {
            statistics.ConversionRate = "N/A";
            statistics.SubmittedCvRate = "N/A";
        }
        else
        {
            decimal rate = (statistics.TotalApplications / (decimal)statistics.ClicksCount * 100);
            statistics.ConversionRate = rate.ToString("0.0'%'").Replace(".0%", "%");

            decimal cvRate = (statistics.ApplicationsWithCv / (decimal)statistics.TotalApplications * 100);

            // Check for decimal places
            if (cvRate == Math.Floor(cvRate))
            {
                statistics.SubmittedCvRate = cvRate.ToString("0") + "%";
            }
            else
            {
                statistics.SubmittedCvRate = cvRate.ToString("0.0") + "%";
            }
        }

        return statistics;
    }

    public async Task IncrementClicksByJobIdAsync(int jobId)
    {
        await _statisticsRepository.IncrementClicksByJobIdAsync(jobId);
    }
}