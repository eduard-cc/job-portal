using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalDomain.Models;

public class Statistics
{
    public int ClicksCount { get; set; }
    public int SavedCount { get; set; }
    public int ApplicationsWithCv { get; set; }
    public int ApplicationsWithoutCv { get; set; }
    public int TotalApplications => ApplicationsWithCv + ApplicationsWithoutCv;
    public string ConversionRate { get; set; }
    public string SubmittedCvRate { get; set; }

    public Statistics(int clicksCount, int savedCount, int applicationsWithCv, int applicationsWithoutCv)
    {
        ClicksCount = clicksCount;
        SavedCount = savedCount;
        ApplicationsWithCv = applicationsWithCv;
        ApplicationsWithoutCv = applicationsWithoutCv;
    }
}