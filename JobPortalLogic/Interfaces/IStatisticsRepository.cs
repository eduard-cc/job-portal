using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Interfaces;

public interface IStatisticsRepository
{
    Task<int> GetClickCountByJobIdAsync(int jobId);

    Task<int> GetSavedCountByJobIdAsync(int jobId);

    Task<(int applicationsWithoutCv, int applicationsWithCv)> GetApplicationCountByJobIdAsync(int jobId);

    Task IncrementClicksByJobIdAsync(int jobId);
}