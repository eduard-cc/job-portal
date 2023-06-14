using JobPortalDomain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobPortalLogic.Extensions;
using System.Threading.Tasks.Dataflow;
using JobPortalDomain.Enums;
using JobPortalLogic.Services;
using Autofac;
using Application = JobPortalDomain.Models.Application;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.ApplicationServices;

namespace JobPortalDesktop.Forms;

public partial class JobListing : Form
{
    Job job;
    int currentUserId;
    AccountType currentUserAccountType;
    bool AllowEditAndDelete;

    Application? applicationAlreadyMade;

    private readonly SavedJobService _savedJobService;
    private readonly ApplicationService _applicationService;
    private readonly JobService _jobService;

    bool updateListInParentForm = false;
    bool saved;
    public JobListing(int userId, AccountType accountType, Job job)
    {
        InitializeComponent();
        currentUserId = userId;
        currentUserAccountType = accountType;
        this.job = job;

        _savedJobService = Program.Container.Resolve<SavedJobService>();
        _applicationService = Program.Container.Resolve<ApplicationService>();
        _jobService = Program.Container.Resolve<JobService>();

        if (currentUserAccountType == AccountType.Employer)
        {
            saveBtn.Visible = false;
            applyPanel.Visible = false;
            descriptionRichTxtBox.Size = new Size(868, 365);
            descriptionRichTxtBox.Refresh();
        }
    }

    private async void UpdateJob()
    {
        Job updatedJob = await _jobService.GetJobByIdAsync(job.Id);

        titleLbl.Text = updatedJob.Title;
        companyNameLbl.Text = updatedJob.Employer.CompanyName;
        locationLbl.Text = updatedJob.Employer.Location;
        workArrangementLbl.Text = GetDisplayAttribute(updatedJob.WorkArrangement);
        contractTypeLbl.Text = GetDisplayAttribute(updatedJob.ContractType);
        salaryLbl.Text = updatedJob.Salary.ToString();
        descriptionRichTxtBox.Text = updatedJob.Description;
    }

    private async void JobListing_Load(object sender, EventArgs e)
    {
        job = await _jobService.GetJobByIdAsync(job.Id);

        titleLbl.Text = job.Title;
        companyNameLbl.Text = job.Employer.CompanyName;
        locationLbl.Text = job.Employer.Location;
        workArrangementLbl.Text = GetDisplayAttribute(job.WorkArrangement);
        contractTypeLbl.Text = GetDisplayAttribute(job.ContractType);
        salaryLbl.Text = job.Salary.ToString();
        descriptionRichTxtBox.Text = job.Description;

        // Check if jobseeker already applied to this job
        applicationAlreadyMade = await _applicationService.GetApplicationByJobseekerAndJobIdAsync(currentUserId, job.Id);

        CheckCurrentApplication();

        // Check if job is saved by jobseeker or not
        saved = await _savedJobService.CheckIfJobSavedAsync(currentUserId, job.Id);

        if (saved)
        {
            saveBtn.Image = Properties.Resources.saved_icon;
            saveBtn.Refresh();
        }

        AllowEditAndDelete = await _jobService.CheckIfJobPostedByEmployerAsync(currentUserId, job.Id);

        if (currentUserAccountType == AccountType.Employer && AllowEditAndDelete)
        {
            deleteBtn.Visible = true;
            editBtn.Visible = true;
            dashboardBtn.Visible = true;
        }
    }

    public string GetDisplayAttribute(Enum enumValue)
    {
        if (enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttribute<DisplayAttribute>() != null)
        {
            return enumValue.GetAttribute<DisplayAttribute>().Name;
        }
        else
        {
            return enumValue.ToString();
        }
    }

    private async void applyBtn_Click(object sender, EventArgs e)
    {
        ApplyForm applyForm = new ApplyForm(currentUserId, job);
        DialogResult result = applyForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            applicationAlreadyMade = await _applicationService.GetApplicationByJobseekerAndJobIdAsync(currentUserId, job.Id);
            CheckCurrentApplication();
        }
    }

    private async void saveBtn_Click(object sender, EventArgs e)
    {
        if (!saved)
        {
            await _savedJobService.SaveOrUnsaveJobAsync(currentUserId, job.Id);
            saved = true;
            saveBtn.Image = Properties.Resources.saved_icon;
            saveBtn.Refresh();
        }
        else
        {
            await _savedJobService.SaveOrUnsaveJobAsync(currentUserId, job.Id);
            saved = false;
            saveBtn.Image = Properties.Resources.unsaved_icon;
            saveBtn.Refresh();
        }
    }

    private void editBtn_Click(object sender, EventArgs e)
    {
        PostOrEditJob editJobForm = new PostOrEditJob(currentUserId, true, job.Id);
        DialogResult result = editJobForm.ShowDialog();

        if (result == DialogResult.OK)
        {
            UpdateJob();
            MessageBox.Show("Job edited successfully!");
            updateListInParentForm = true;
        }
    }

    private void dashboardBtn_Click(object sender, EventArgs e)
    {
        JobApplications jobApplicationsForm = new JobApplications(currentUserId, job.Id);
        DialogResult result = jobApplicationsForm.ShowDialog();
    }

    private void CheckCurrentApplication()
    {
        if (currentUserAccountType == AccountType.Jobseeker && applicationAlreadyMade != null)
        {
            applicationDateApplied.Visible = true;
            applicationDateApplied.Text = $"You applied to this job on {applicationAlreadyMade.DateApplied:MMM d, yyyy}";
            applyBtn.Visible = false;
            alreadyAppliedLbl.Visible = true;
            alreadyAppliedLbl.Text = applicationAlreadyMade.Status.ToString();
            applicationStatusIcon.Visible = true;

            switch (applicationAlreadyMade.Status)
            {
                case ApplicationStatus.Pending:
                    applyPanel.BackColor = Color.FromArgb(253, 230, 138);
                    applicationStatusIcon.Image = Properties.Resources.pending_icon;
                    break;
                case ApplicationStatus.Interviewing:
                    applyPanel.BackColor = Color.FromArgb(125, 211, 252);
                    applicationStatusIcon.Image = Properties.Resources.interviewing_icon;
                    break;
                case ApplicationStatus.Offered:
                    applyPanel.BackColor = Color.FromArgb(110, 231, 183);
                    applicationStatusIcon.Image = Properties.Resources.offered_icon;
                    break;
                case ApplicationStatus.Accepted:
                    applyPanel.BackColor = Color.FromArgb(134, 239, 172);
                    applicationStatusIcon.Image = Properties.Resources.accepted_icon;
                    break;
                case ApplicationStatus.Rejected:
                    applyPanel.BackColor = Color.FromArgb(252, 165, 165);
                    applicationStatusIcon.Image = Properties.Resources.rejected_icon;
                    break;
            }
            applicationStatusIcon.Refresh();
        }
    }

    private void JobListing_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (updateListInParentForm == true)
        {
            DialogResult = DialogResult.Yes;
        }
    }

    private async void deleteBtn_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this job? " +
                     "\nThis action cannot be undone.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (dialogResult == DialogResult.Yes)
        {
            await _jobService.DeleteJobByIdAsync(job.Id);
            DialogResult = DialogResult.OK;
            updateListInParentForm = true;
        }
    }
}
