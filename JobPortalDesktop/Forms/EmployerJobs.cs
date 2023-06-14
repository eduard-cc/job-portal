using Autofac;
using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortalDesktop.Forms;

public partial class EmployerJobs : Form
{
    int currentUserId;
    private readonly JobService _jobService;

    List<Job> jobs;

    public EmployerJobs(int userId)
    {
        InitializeComponent();
        currentUserId = userId;

        _jobService = Program.Container.Resolve<JobService>();
    }

    private async void EmployerJobs_Load(object sender, EventArgs e)
    {
        jobs = await _jobService.GetJobsByEmployerIdAsync(currentUserId);
        jobsDataGridView.DataSource = jobs;
        SetColumns();
    }

    private async void postJobBtn_Click(object sender, EventArgs e)
    {
        PostOrEditJob postJobForm = new PostOrEditJob(currentUserId, false, null);
        DialogResult result = postJobForm.ShowDialog();

        if (result == DialogResult.OK)
        {
            jobs = await _jobService.GetJobsByEmployerIdAsync(currentUserId);
            jobsDataGridView.DataSource = jobs;
            SetColumns();
            MessageBox.Show("Job posted successfully!");
        }
    }

    public void SetColumns()
    {
        if (!CheckIfColumnExists("Employer.Location"))
        {
            DataGridViewTextBoxColumn companyNameColumn = new DataGridViewTextBoxColumn();
            companyNameColumn.Name = "Employer.Location";
            companyNameColumn.HeaderText = "Location";
            companyNameColumn.DataPropertyName = "Employer.Location";
            jobsDataGridView.Columns.Insert(2, companyNameColumn);
        }

        DataGridViewTextBoxColumn employerColumn = (DataGridViewTextBoxColumn)jobsDataGridView.Columns["Employer"];
        employerColumn.DataPropertyName = "Employer.CompanyName";
        employerColumn.HeaderText = "Company name";

        jobsDataGridView.Columns["Title"].DisplayIndex = 0;
        jobsDataGridView.Columns["DatePosted"].DisplayIndex = 6;

        jobsDataGridView.Columns["DatePosted"].HeaderText = "Date posted";
        jobsDataGridView.Columns["ContractType"].HeaderText = "Contract type";
        jobsDataGridView.Columns["WorkArrangement"].HeaderText = "Work arrangement";

        jobsDataGridView.Columns["Id"].Visible = false;
        jobsDataGridView.Columns["Description"].Visible = false;
        jobsDataGridView.Columns["Clicks"].Visible = false;

        foreach (DataGridViewColumn column in jobsDataGridView.Columns)
        {
            if (column.HeaderText == "Employer")
            {
                column.Visible = false;
                break;
            }
        }
    }

    public bool CheckIfColumnExists(string columnName)
    {
        foreach (DataGridViewColumn column in jobsDataGridView.Columns)
        {
            if (column.Name == columnName)
            {
                return true;
            }
        }
        return false;
    }

    // Allows for changing properties of bound columns

    private void jobsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridViewColumn column = jobsDataGridView.Columns[e.ColumnIndex];
        if (column.DataPropertyName.Contains('.'))
        {
            object data = jobsDataGridView.Rows[e.RowIndex].DataBoundItem;
            string[] properties = column.DataPropertyName.Split('.');
            for (int i = 0; i < properties.Length && data != null; i++)
            {
                data = data.GetType().GetProperty(properties[i]).GetValue(data);
            }
            jobsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }
    }

    private async void jobsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = jobsDataGridView.Rows[e.RowIndex];

            Job job = (Job)row.DataBoundItem;

            JobListing jobListingForm = new JobListing(currentUserId, AccountType.Employer, job);
            DialogResult result = jobListingForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                jobs = await _jobService.GetJobsByEmployerIdAsync(currentUserId);
                jobsDataGridView.DataSource = jobs;
                SetColumns();
            }
        }
    }
}
