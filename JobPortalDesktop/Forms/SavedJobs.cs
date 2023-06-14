using Autofac;
using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Services;
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

public partial class SavedJobs : Form
{
    private readonly SavedJobService _savedJobService;
    int currentUserId;

    List<Job> jobs;

    public SavedJobs(int userId)
    {
        InitializeComponent();
        currentUserId = userId;

        _savedJobService = Program.Container.Resolve<SavedJobService>();
    }

    private async void SavedJobs_Load(object sender, EventArgs e)
    {
        jobs = await _savedJobService.GetAllSavedJobsAsync(currentUserId);
        savedJobsDataGridView.DataSource = GetBindingSource(jobs);
        SetColumns();
    }

    private BindingSource GetBindingSource(List<Job> jobs)
    {
        BindingSource bindingSource = new BindingSource();
        bindingSource.DataSource = jobs;
        return bindingSource;
    }

    private void savedJobsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = savedJobsDataGridView.Rows[e.RowIndex];

            Job job = (Job)row.DataBoundItem;

            JobListing jobListingForm = new JobListing(currentUserId, AccountType.Jobseeker, job);
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
            savedJobsDataGridView.Columns.Insert(2, companyNameColumn);
        }

        DataGridViewTextBoxColumn employerColumn = (DataGridViewTextBoxColumn)savedJobsDataGridView.Columns["Employer"];
        employerColumn.DataPropertyName = "Employer.CompanyName";
        employerColumn.HeaderText = "Company name";

        savedJobsDataGridView.Columns["Title"].DisplayIndex = 0;
        savedJobsDataGridView.Columns["DatePosted"].DisplayIndex = 6;

        savedJobsDataGridView.Columns["DatePosted"].HeaderText = "Date posted";
        savedJobsDataGridView.Columns["ContractType"].HeaderText = "Contract type";
        savedJobsDataGridView.Columns["WorkArrangement"].HeaderText = "Work arrangement";

        savedJobsDataGridView.Columns["Id"].Visible = false;
        savedJobsDataGridView.Columns["Description"].Visible = false;
        savedJobsDataGridView.Columns["Clicks"].Visible = false;

        foreach (DataGridViewColumn column in savedJobsDataGridView.Columns)
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
        foreach (DataGridViewColumn column in savedJobsDataGridView.Columns)
        {
            if (column.Name == columnName)
            {
                return true;
            }
        }
        return false;
    }

    // Allows for changing properties of bound columns
    private void savedJobsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridViewColumn column = savedJobsDataGridView.Columns[e.ColumnIndex];
        if (column.DataPropertyName.Contains("."))
        {
            object data = savedJobsDataGridView.Rows[e.RowIndex].DataBoundItem;
            string[] properties = column.DataPropertyName.Split('.');
            for (int i = 0; i < properties.Length && data != null; i++)
            {
                data = data.GetType().GetProperty(properties[i]).GetValue(data);
            }
            savedJobsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }
    }
}
