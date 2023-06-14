using Autofac;
using JobPortalDomain.Models;
using JobPortalLogic.Extensions;
using JobPortalLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortalDesktop.Forms;

public partial class PostOrEditJob : Form
{
    int currentUserId;
    private readonly JobService _jobService;
    private readonly InputValidator _inputValidator;
    bool editMode;
    Job job;
    int? jobId;

    public PostOrEditJob(int userId, bool editMode, int? jobId)
    {
        InitializeComponent();
        currentUserId = userId;
        this.editMode = editMode;
        job = new Job();
        this.jobId = jobId;

        _jobService = Program.Container.Resolve<JobService>();
        _inputValidator = Program.Container.Resolve<InputValidator>();

        if (editMode)
        {
            this.Text = "Edit job";
            headerLbl.Text = "Edit job";
            submitBtn.Text = "Save";
        }

        SetComboBoxValues<ContractType>(contractTypeComboBox);
        SetComboBoxValues<WorkArrangement>(workArrangementComboBox);
        SetComboBoxValues<SalaryType>(salaryTypeComboBox);
        SetComboBoxValues<SalaryRate>(salaryRateComboBox);
    }

    private async void PostOrEditJob_Load(object sender, EventArgs e)
    {
        if (editMode)
        {
            job = await _jobService.GetJobByIdAsync((int)jobId);

            jobTitleTxtBox.Text = job.Title;
            jobDescriptionTxtBox.Text = job.Description;

            contractTypeComboBox.SelectedIndex = (int)job.ContractType;
            workArrangementComboBox.SelectedIndex = (int)job.WorkArrangement;
            salaryTypeComboBox.SelectedIndex = (int)job.Salary.Type;
            salaryRateComboBox.SelectedIndex = (int)job.Salary.Rate;

            if (job.Salary.Type == SalaryType.ExactAmount)
            {
                exactAmountTxtBox.Text = job.Salary.Amount.ToString();
            }
            else
            {
                minAmountTxtBox.Text = job.Salary.MinAmount.ToString();
                maxAmountTxtBox.Text = job.Salary.MaxAmount.ToString();
            }
        }
    }

    public void SetComboBoxValues<TEnum>(ComboBox comboBox) where TEnum : Enum
    {
        Type enumType = typeof(TEnum);
        // Set the data source to an array of KeyValuePair objects
        // key = enum value
        // value = [Display(Name)] attribute or enum value string representation
        comboBox.DataSource = Enum.GetValues(enumType)
                                     .Cast<Enum>()
                                     .Select(e =>
                                     {
                                         var displayName = e.GetAttribute<DisplayAttribute>()?.GetName();
                                         return new KeyValuePair<Enum, string?>(e, displayName ?? e.ToString());
                                     })
                                     .ToArray();
        comboBox.DisplayMember = "Value";
        comboBox.ValueMember = "Key";
    }

    private void salaryTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (salaryTypeComboBox.SelectedIndex == 0)
        {
            minAmountTxtBox.Clear();
            maxAmountTxtBox.Clear();
            minAmountLbl.Visible = false;
            maxAmountLbl.Visible = false;
            minAmountTxtBox.Visible = false;
            maxAmountTxtBox.Visible = false;

            exactAmountLbl.Visible = true;
            exactAmountTxtBox.Visible = true;
        }
        else
        {
            exactAmountTxtBox.Clear();
            exactAmountLbl.Visible = false;
            exactAmountTxtBox.Visible = false;

            minAmountLbl.Visible = true;
            maxAmountLbl.Visible = true;
            minAmountTxtBox.Visible = true;
            maxAmountTxtBox.Visible = true;
        }
    }

    private async void submitBtn_Click(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            if (!editMode)
            {
                Salary salary = new Salary
                {
                    Type = (SalaryType)salaryTypeComboBox.SelectedValue
                };

                if (salary.Type == SalaryType.ExactAmount)
                {
                    salary.Amount = Convert.ToDecimal(exactAmountTxtBox.Text);
                }
                else
                {
                    salary.MinAmount = Convert.ToDecimal(minAmountTxtBox.Text);
                    salary.MaxAmount = Convert.ToDecimal(maxAmountTxtBox.Text);
                }

                Job job = new Job
                {
                    Title = jobTitleTxtBox.Text,
                    Description = jobDescriptionTxtBox.Text,
                    ContractType = (ContractType)contractTypeComboBox.SelectedValue,
                    WorkArrangement = (WorkArrangement)workArrangementComboBox.SelectedValue,
                    DatePosted = DateTime.Now
                };
                job.Salary = salary;

                await _jobService.AddJobAsync(job, currentUserId);
            }
            else
            {
                job.Title = jobTitleTxtBox.Text;
                job.Description = jobDescriptionTxtBox.Text;
                job.ContractType = (ContractType)contractTypeComboBox.SelectedValue;
                job.WorkArrangement = (WorkArrangement)workArrangementComboBox.SelectedValue;
                job.Salary.Type = (SalaryType)salaryTypeComboBox.SelectedValue;
                job.Salary.Rate = (SalaryRate)salaryRateComboBox.SelectedValue;

                if (job.Salary.Type == SalaryType.ExactAmount)
                {
                    job.Salary.Amount = Convert.ToDecimal(exactAmountTxtBox.Text);
                }
                else
                {
                    job.Salary.MinAmount = Convert.ToDecimal(minAmountTxtBox.Text);
                    job.Salary.MaxAmount = Convert.ToDecimal(maxAmountTxtBox.Text);
                }

                await _jobService.UpdateJobDetailsAsync(job);
            }
            DialogResult = DialogResult.OK;
        }
    }

    private bool ValidateInputs()
    {
        bool isValid = true;
        string errorMessage;

        // Validate job title
        if (String.IsNullOrWhiteSpace(jobTitleTxtBox.Text))
        {
            jobTitleValidationLbl.Visible = true;
            jobTitleValidationLbl.Text = "This field is required.";
            isValid = false;
        }
        else
        {
            jobTitleValidationLbl.Visible = false;
        }

        // Validate job description
        if (String.IsNullOrWhiteSpace(jobDescriptionTxtBox.Text))
        {
            jobDescriptionValidationLbl.Visible = true;
            jobDescriptionValidationLbl.Text = "This field is required.";
            isValid = false;
        }
        else
        {
            jobDescriptionValidationLbl.Visible = false;
        }

        // Validate salary
        if (salaryTypeComboBox.SelectedIndex == 0)
        {
            if (!_inputValidator.ValidateSalaryAmount(exactAmountTxtBox.Text, out errorMessage))
            {
                amountValidationLbl.Visible = true;
                amountValidationLbl.Text = errorMessage;
                isValid = false;
            }
            else
            {
                amountValidationLbl.Visible = false;
            }
        }
        else
        {
            if (!_inputValidator.ValidateSalaryAmount(minAmountTxtBox.Text, out errorMessage))
            {
                amountValidationLbl.Visible = true;
                amountValidationLbl.Text = errorMessage;
                isValid = false;
            }
            else
            {
                amountValidationLbl.Visible = false;
            }

            if (!_inputValidator.ValidateSalaryAmount(maxAmountTxtBox.Text, out errorMessage))
            {
                amountValidationLbl.Visible = true;
                amountValidationLbl.Text = errorMessage;
                isValid = false;
            }
            else
            {
                amountValidationLbl.Visible = false;
            }

            if (Convert.ToDecimal(minAmountTxtBox.Text) > Convert.ToDecimal(maxAmountTxtBox.Text))
            {
                amountValidationLbl.Visible = true;
                amountValidationLbl.Text = "Min amount cannot be greater than max amount";
                isValid = false;
            }
            else
            {
                amountValidationLbl.Visible = false;
            }
        }
        return isValid;
    }
}
