using Autofac;
using JobPortalDesktop.UserControls;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
using JobPortalDomain.Enums;
using JobPortalLogic.Extensions;
using System.ComponentModel;
using System.Windows.Forms;

namespace JobPortalDesktop.Forms;

public partial class SearchJobs : Form
{
    private readonly JobService _jobService;
    int currentUserId;
    AccountType currentUserAccountType;
    List<Job> jobs;
    public SearchJobs(int userId, AccountType accountType)
    {
        InitializeComponent();
        currentUserId = userId;
        currentUserAccountType = accountType;

        _jobService = Program.Container.Resolve<JobService>();
    }

    private async void findJobsBtn_Click(object sender, EventArgs e)
    {
        int totalJobCount = await _jobService.GetTotalJobCountAsync();
        jobs = await _jobService.SearchJobsAsync(jobTitleOrCompanyTxtBox.Text, locationTxtBox.Text, 0, totalJobCount);
        jobsDataGridView.DataSource = GetBindingSource(jobs);
        SetColumns();
    }

    private async void SearchJobs_LoadAsync(object sender, EventArgs e)
    {
        int totalJobCount = await _jobService.GetTotalJobCountAsync();
        jobs = await _jobService.SearchJobsAsync(jobTitleOrCompanyTxtBox.Text, locationTxtBox.Text, 0, totalJobCount);
        jobsDataGridView.DataSource = GetBindingSource(jobs);
        SetColumns();
    }

    private BindingSource GetBindingSource(List<Job> jobs)
    {
        BindingSource bindingSource = new BindingSource();
        bindingSource.DataSource = jobs;
        return bindingSource;
    }

    // Allows for changing properties of bound columns
    private void jobsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridViewColumn column = jobsDataGridView.Columns[e.ColumnIndex];
        if (column.DataPropertyName.Contains("."))
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

    private void jobsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = jobsDataGridView.Rows[e.RowIndex];

            Job job = (Job)row.DataBoundItem;

            JobListing jobListingForm = new JobListing(currentUserId, currentUserAccountType, job);
            jobListingForm.ShowDialog();
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
}
