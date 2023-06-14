using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalDomain.Models;

public enum ApplicationStatus
{
    Pending,
    Interviewing,
    Offered,
    Accepted,
    Rejected
}

public class Application
{
    public int Id { get; set; }
    public Jobseeker Applicant { get; set; }
    public Job Job { get; set; }
    public ApplicationStatus Status { get; set; }
    public DateTime DateApplied { get; set; }
    public Cv? Cv { get; set; }

    public Application(int id, Job job, ApplicationStatus status, DateTime dateApplied)
    {
        Id = id;
        Job = job;
        Status = status;
        DateApplied = dateApplied;
    }

    public Application(Jobseeker applicant, Job job, ApplicationStatus status, DateTime dateApplied, Cv? cv)
    {
        Applicant = applicant;
        Job = job;
        Status = status;
        DateApplied = dateApplied;
        Cv = cv;
    }

    public Application(ApplicationStatus status, DateTime dateApplied)
    {
        Status = status;
        DateApplied = dateApplied;
    }

    public Application() { }

    public Application(int id, Jobseeker applicant, ApplicationStatus status, DateTime dateApplied, Cv? cv)
    {
        Id = id;
        Applicant = applicant;
        Status = status;
        DateApplied = dateApplied;
        Cv = cv;
    }

    public FileContentResult DownloadCv()
    {
        if (Cv != null)
        {
            return Cv.ToFileContentResult();
        }

        return null;
    }
}