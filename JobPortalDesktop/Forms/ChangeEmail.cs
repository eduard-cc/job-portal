using Autofac;
using JobPortalLogic.Extensions;
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

namespace JobPortalDesktop.Forms;

public partial class ChangeEmail : Form
{
    private readonly UserService _userService;
    private readonly InputValidator _inputValidator;

    int currentUserId;
    public ChangeEmail(int userId, string currentEmail)
    {
        InitializeComponent();
        _userService = Program.Container.Resolve<UserService>();
        _inputValidator = Program.Container.Resolve<InputValidator>();

        currentUserId = userId;
        userEmailLbl.Text = currentEmail;
    }

    private async void confirmBtn_ClickAsync(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            string newEmail = newEmailTxtBox.Text;
            string currentPassword = currentPasswordTxtBox.Text;

            try
            {
                await _userService.ChangeUserEmailAsync(currentUserId, newEmail, currentPassword);
                DialogResult = DialogResult.OK;
            }
            catch (EmailInUseException ex)
            {
                newEmailValidationLbl.Visible = true;
                newEmailValidationLbl.Text = ex.Message;
            }
            catch (IncorrectPasswordException ex)
            {
                currentPasswordValidationLbl.Visible = true;
                currentPasswordValidationLbl.Text = ex.Message;
            }
        }
    }

    private void passVisibilityCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (passVisibilityCheckBox.Checked)
        {
            currentPasswordTxtBox.UseSystemPasswordChar = false;
            passVisibilityCheckBox.Text = "Hide";
        }
        else
        {
            currentPasswordTxtBox.UseSystemPasswordChar = true;
            passVisibilityCheckBox.Text = "Show";
        }
    }

    public bool ValidateInputs()
    {
        bool isValid = true;
        string errorMessage;

        // Validate email
        if (!_inputValidator.ValidateEmail(newEmailTxtBox.Text, out errorMessage))
        {
            newEmailValidationLbl.Visible = true;
            newEmailValidationLbl.Text = errorMessage;
            isValid = false;
        }
        else
        {
            newEmailValidationLbl.Visible = false;
        }

        // Validate password
        if (!_inputValidator.ValidatePassword(currentPasswordTxtBox.Text, out errorMessage))
        {
            currentPasswordValidationLbl.Visible = true;
            currentPasswordValidationLbl.Text = errorMessage;
            isValid = false;
        }
        else
        {
            currentPasswordValidationLbl.Visible = false;
        }

        return isValid;
    }
}
