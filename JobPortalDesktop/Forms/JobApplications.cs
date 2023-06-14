using Autofac;
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
using JobPortalDomain.Models;
using Application = JobPortalDomain.Models.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JobPortalDesktop.Forms;

public partial class JobApplications : Form
{
    private readonly ApplicationService _applicationService;
    int currentUserId;
    int jobId;
    List<Application> applications;

    public JobApplications(int userId, int jobId)
    {
        InitializeComponent();

        currentUserId = userId;
        this.jobId = jobId;
        _applicationService = Program.Container.Resolve<ApplicationService>();
    }

    private async void JobApplications_Load(object sender, EventArgs e)
    {
        applications = await _applicationService.GetAllApplicationsByJobIdAsync(jobId);
        applicationsDataGridView.DataSource = applications;
        SetColumns();

        // Set the DataGridView control to non-read-only mode
        applicationsDataGridView.ReadOnly = false;
    }

    private void SetColumns()
    {
        applicationsDataGridView.Columns["Id"].Visible = false;
        applicationsDataGridView.Columns["Job"].Visible = false;
        applicationsDataGridView.Columns["Status"].Visible = false;
        applicationsDataGridView.Columns["Cv"].Visible = false;

        DataGridViewTextBoxColumn applicantName = new DataGridViewTextBoxColumn();
        applicantName.Name = "Applicant.FullName";
        applicantName.HeaderText = "Name";
        applicantName.DataPropertyName = "Applicant.FullName";
        applicationsDataGridView.Columns.Insert(0, applicantName);

        DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
        comboBoxColumn.DataSource = Enum.GetValues(typeof(ApplicationStatus));
        comboBoxColumn.DataPropertyName = "Status";
        comboBoxColumn.HeaderText = "Status";
        comboBoxColumn.Name = "Status";
        applicationsDataGridView.Columns.Add(comboBoxColumn);
    }

    // Allows for changing properties of bound columns
    private void applicationsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        DataGridViewColumn column = applicationsDataGridView.Columns[e.ColumnIndex];
        if (column.DataPropertyName.Contains("."))
        {
            object data = applicationsDataGridView.Rows[e.RowIndex].DataBoundItem;
            string[] properties = column.DataPropertyName.Split('.');
            for (int i = 0; i < properties.Length && data != null; i++)
            {
                data = data.GetType().GetProperty(properties[i]).GetValue(data);
            }
            applicationsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }
    }

    // Allow editing only for the Status column
    private void applicationsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
        DataGridViewColumn column = applicationsDataGridView.Columns[e.ColumnIndex];

        if (column.Name != "Status")
        {
            e.Cancel = true;
        }
    }

    private async void applicationsDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
    {
        // Commit changes to the ComboBox column when the cell is dirty
        if (applicationsDataGridView.IsCurrentCellDirty)
        {
            applicationsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }

    private async void applicationsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewColumn column = applicationsDataGridView.Columns[e.ColumnIndex];
        DataGridViewRow row = applicationsDataGridView.Rows[e.RowIndex];

        if (column.Name == "Status")
        {
            Application application = (Application)row.DataBoundItem;

            // Get the new value of the Status property
            ApplicationStatus newStatus = (ApplicationStatus)row.Cells["Status"].Value;

            // Update the status in db
            await _applicationService.UpdateStatusOfApplicationAsync(application.Id, newStatus);
        }
    }

    private void applicationsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            DataGridViewColumn column = applicationsDataGridView.Columns[e.ColumnIndex];
            if (column.Name == "Cv")
            {
                if (e.Value != null && e.Value.ToString() == "Download CV")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Draw a button-like appearance
                    Rectangle buttonRect = new Rectangle(
                        e.CellBounds.X + 2, e.CellBounds.Y + 2,
                        e.CellBounds.Width - 4, e.CellBounds.Height - 4
                    );
                    ControlPaint.DrawButton(e.Graphics, buttonRect, ButtonState.Normal);

                    // Draw the button text
                    TextRenderer.DrawText(
                        e.Graphics, e.Value.ToString(),
                        e.CellStyle.Font, buttonRect,
                        e.CellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                    );

                    e.Handled = true;
                }
            }
        }
    }
}
