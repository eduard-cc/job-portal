using Autofac;
using JobPortalLogic.Extensions;
using JobPortalDesktop.Forms;
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
using JobPortalLogic.Exceptions;

namespace JobPortalDesktop.UserControls;

public partial class JobseekerSignupForm : UserControl
{
    private readonly UserService _userService;
    private readonly InputValidator _inputValidator;
    Signup parentForm;

    public JobseekerSignupForm(Signup signUpForm)
    {
        InitializeComponent();

        _userService = Program.Container.Resolve<UserService>();
        _inputValidator = Program.Container.Resolve<InputValidator>();

        parentForm = signUpForm;
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
            Jobseeker jobseeker = new Jobseeker(email: emailTxtBox.Text,
                                               password: passwordTxtBox.Text,
                                               firstName: firstNameTxtBox.Text,
                                               lastName: lastNameTxtBox.Text,
                                               location: locationTxtBox.Text,
                                               phoneNumber: phoneNumberTxtBox.Text);
            try
            {
                int userId = await _userService.CreateUserAccountAsync(jobseeker, AccountType.Jobseeker);

                parentForm.Close();
                JobseekerDashboard jobseekerDashboard = new JobseekerDashboard(userId, AccountType.Jobseeker);
                jobseekerDashboard.Show();
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

        // Validate first name
        if (String.IsNullOrWhiteSpace(firstNameTxtBox.Text))
        {
            firstNameValidationLbl.Visible = true;
            firstNameValidationLbl.Text = "This field is required.";
            isValid = false;
        }
        else
        {
            firstNameValidationLbl.Visible = false;
        }

        // Validate last name
        if (String.IsNullOrWhiteSpace(lastNameTxtBox.Text))
        {
            lastNameValidationLbl.Visible = true;
            lastNameValidationLbl.Text = "This field is required.";
            isValid = false;
        }
        else
        {
            lastNameValidationLbl.Visible = false;
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

        // Validate phone number
        if (!_inputValidator.ValidatePhoneNumber(phoneNumberTxtBox.Text, out errorMessage))
        {
            phoneNumberValidationLbl.Visible = true;
            phoneNumberValidationLbl.Text = errorMessage;
            isValid = false;
        }
        else
        {
            phoneNumberValidationLbl.Visible = false;
        }

        return isValid;
    }
}
