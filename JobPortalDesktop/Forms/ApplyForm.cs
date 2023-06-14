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
using static System.Net.Mime.MediaTypeNames;
using Application = JobPortalDomain.Models.Application;

namespace JobPortalDesktop.Forms;

public partial class ApplyForm : Form
{
    private readonly UserService _userService;
    private readonly JobService _jobService;
    private readonly ApplicationService _applicationService;
    int currentUserId;
    Job job;
    Cv cv;

    public ApplyForm(int userId, Job job)
    {
        InitializeComponent();
        currentUserId = userId;
        this.job = job;

        _userService = Program.Container.Resolve<UserService>();
        _jobService = Program.Container.Resolve<JobService>();
        _applicationService = Program.Container.Resolve<ApplicationService>();
    }

    private async void ApplyForm_Load(object sender, EventArgs e)
    {
        Jobseeker jobseeker = (Jobseeker)await _userService.GetUserDetailsByIdAsync(currentUserId, AccountType.Jobseeker);

        nameLbl.Text = jobseeker.FullName;
        locationLbl.Text = jobseeker.Location;
        phoneLbl.Text = jobseeker.PhoneNumber;
        emailLbl.Text = jobseeker.Email;
    }

    private async void applyBtn_Click(object sender, EventArgs e)
    {
        Jobseeker jobseeker = new Jobseeker(currentUserId);
        Application application = new Application(jobseeker, job, ApplicationStatus.Pending, DateTime.Now, cv);
        await _applicationService.AddApplicationAsync(application);
        DialogResult = DialogResult.OK;
    }

    private void uploadBtn_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|Word Documents (*.doc; *.docx)|*.doc;*.docx";
        openFileDialog.Title = "Select file";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            string fileName = Path.GetFileName(filePath);
            string contentType = GetContentType(fileName);
            byte[] data = File.ReadAllBytes(filePath);

            cv = new Cv(fileName, contentType, data);
        }
    }

    private string GetContentType(string fileName)
    {
        string extension = Path.GetExtension(fileName).ToLower();

        switch (extension)
        {
            case ".pdf":
                return "application/pdf";
            case ".doc":
                return "application/msword";
            case ".docx":
                return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            default:
                return "application/octet-stream";
        }
    }
}
