using Autofac;
using JobPortalDesktop.Forms;
using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Exceptions;
using JobPortalLogic.Extensions;
using JobPortalLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortalDesktop.UserControls;

public partial class EmployerSignupForm : UserControl
{
    private readonly UserService _userService;
    private readonly InputValidator _inputValidator;
    Signup parentForm;

    public EmployerSignupForm(Signup signUpForm)
    {
        InitializeComponent();

        _userService = Program.Container.Resolve<UserService>();
        _inputValidator = Program.Container.Resolve<InputValidator>();

        parentForm = signUpForm;

        // Set the data source to an array of KeyValuePair objects
        // key = CompanySize enum value
        // value = [Display(Name)] attribute
        companySizeComboBox.DataSource = Enum.GetValues(typeof(CompanySize))
                                             .Cast<CompanySize>()
                                             .Select(e => new KeyValuePair<CompanySize, string?>(e, e.GetAttribute<DisplayAttribute>()
                                             .GetName()))
                                             .ToArray();
        companySizeComboBox.DisplayMember = "Value";
        companySizeComboBox.ValueMember = "Key";
    }

    private void passVisibilityCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (passVisibilityCheckBox.Checked)
        {
            passwordTxtBox.UseSystemPasswordChar = false;
            passVisibilityCheckBox.Text = "Hide";
        }
        else
        {
            passwordTxtBox.UseSystemPasswordChar = true;
            passVisibilityCheckBox.Text = "Show";
        }
    }

    private async void signUpBtn_Click(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            Employer employer = new Employer(email: emailTxtBox.Text,
                                             password: passwordTxtBox.Text,
                                             companyName: companyNameTxtBox.Text,
                                             companySize: (CompanySize)companySizeComboBox.SelectedValue,
                                             location: locationTxtBox.Text);
            try
            {
                int userId = await _userService.CreateUserAccountAsync(employer, AccountType.Employer);

                parentForm.Close();
                EmployerDashboard employerDashboard = new EmployerDashboard(userId, AccountType.Employer);
                employerDashboard.Show();
            }
            catch (EmailInUseException ex)
            {
                emailValidationLbl.Visible = true;
                emailValidationLbl.Text = ex.Message;
            }
        }
    }

    public bool ValidateInputs()
    {
        bool isValid = true;
        string errorMessage;

        // Validate email
        if (!_inputValidator.ValidateEmail(emailTxtBox.Text, out errorMessage))
        {
            emailValidationLbl.Visible = true;
            emailValidationLbl.Text = errorMessage;
            isValid = false;
        }
        else
        {
            emailValidationLbl.Visible = false;
        }

        // Validate password
        if (!_inputValidator.ValidatePassword(passwordTxtBox.Text, out errorMessage))
        {
            passwordValidationLbl.Visible = true;
            passwordValidationLbl.Text = errorMessage;
            isValid = false;
        }
        else
        {
            passwordValidationLbl.Visible = false;
        }

        // Validate company name
        if (String.IsNullOrWhiteSpace(companyNameTxtBox.Text))
        {
            companyNameValidationLbl.Visible = true;
            companyNameValidationLbl.Text = "This field is required.";
            isValid = false;
        }
        else
        {
            companyNameValidationLbl.Visible = false;
        }

        // Validate location
        if (String.IsNullOrWhiteSpace(locationTxtBox.Text))
        {
            locationValidationLbl.Visible = true;
            locationValidationLbl.Text = "This field is required.";
            isValid = false;
        }
        else
        {
            locationValidationLbl.Visible = false;
        }

        return isValid;
    }
}
