using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Application = JobPortalDomain.Models.Application;

namespace JobPortalDesktop.Forms;

public partial class AppliedJobs : Form
{
    private readonly ApplicationService _applicationService;
    int currentUserId;

    List<Application> applications;
    public AppliedJobs(int userId)
    {
        InitializeComponent();
        currentUserId = userId;

        _applicationService = Program.Container.Resolve<ApplicationService>();
    }

    private async void AppliedJobs_Load(object sender, EventArgs e)
    {
        applications = await _applicationService.GetAllApplicationsByJobseekerIdAsync(currentUserId);
        appliedJobsDataGridView.DataSource = applications;
        SetColumns();
    }

    public void SetColumns()
    {
        appliedJobsDataGridView.Columns["id"].Visible = false;
        appliedJobsDataGridView.Columns["Applicant"].Visible = false;
        appliedJobsDataGridView.Columns["Cv"].Visible = false;
        appliedJobsDataGridView.Columns["DateApplied"].HeaderText = "Date applied";

        DataGridViewTextBoxColumn employerColumn = (DataGridViewTextBoxColumn)appliedJobsDataGridView.Columns["Job"];
        employerColumn.DataPropertyName = "Job.Title";
        employerColumn.HeaderText = "Job";
    }

    private void appliedJobsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridViewColumn column = appliedJobsDataGridView.Columns[e.ColumnIndex];
        if (column.DataPropertyName.Contains("."))
        {
            object data = appliedJobsDataGridView.Rows[e.RowIndex].DataBoundItem;
            string[] properties = column.DataPropertyName.Split('.');
            for (int i = 0; i < properties.Length && data != null; i++)
            {
                data = data.GetType().GetProperty(properties[i]).GetValue(data);
            }
            appliedJobsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }
    }

    private void appliedJobsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = appliedJobsDataGridView.Rows[e.RowIndex];

            Application application = (Application)row.DataBoundItem;

            JobListing jobListingForm = new JobListing(currentUserId, AccountType.Jobseeker, application.Job);
            jobListingForm.ShowDialog();
        }
    }
}
