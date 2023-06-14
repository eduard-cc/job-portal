using Autofac;
using JobPortalLogic.Extensions;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobPortalLogic.Exceptions;

namespace JobPortalDesktop.Forms;

public partial class Login : Form
{
    private readonly UserService _userService;
    private readonly PasswordService _passwordService;
    private readonly InputValidator _inputValidator;
    public Login()
    {
        InitializeComponent();
        _userService = Program.Container.Resolve<UserService>();
        _passwordService = Program.Container.Resolve<PasswordService>();
        _inputValidator = Program.Container.Resolve<InputValidator>();
    }

    private void signUpBtn_Click(object sender, EventArgs e)
    {
        Close();
        Signup signUpForm = new Signup();
        signUpForm.Show();
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

    private async void logInBtn_Click(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            AccountType accountType;

            if (jobseekerRadioBtn.Checked)
            {
                accountType = AccountType.Jobseeker;
            }
            else
            {
                accountType = AccountType.Employer;
            }

            User user;

            try
            {
                user = await _userService.AuthenticateUser(emailTxtBox.Text, passwordTxtBox.Text, accountType);
            }
            catch (IncorrectCredentialsException ex)
            {
                passwordValidationLbl.Visible = true;
                passwordValidationLbl.Text = ex.Message;
                return;
            }

            Close();
            if (accountType == AccountType.Jobseeker)
            {
                JobseekerDashboard jobseekerDashboard = new JobseekerDashboard(user.Id, accountType);
                jobseekerDashboard.Show();
            }
            else
            {
                EmployerDashboard employerDashboard = new EmployerDashboard(user.Id, accountType);
                employerDashboard.Show();
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

        return isValid;
    }
}