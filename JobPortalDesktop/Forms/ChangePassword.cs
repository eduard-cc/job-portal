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

public partial class ChangePassword : Form
{
    int currentUserId;
    private readonly UserService _userService;
    private readonly InputValidator _inputValidator;
    public ChangePassword(int userId)
    {
        InitializeComponent();
        _userService = Program.Container.Resolve<UserService>();
        _inputValidator = Program.Container.Resolve<InputValidator>();

        currentUserId = userId;
    }

    private async void confirmBtn_Click(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            string newPassword = newPasswordTxtBox.Text;
            string currentPassword = currentPasswordTxtBox.Text;

            try
            {
                await _userService.ChangeUserPasswordAsync(currentUserId, newPassword, currentPassword);
                DialogResult = DialogResult.OK;
            }
            catch (IncorrectPasswordException ex)
            {
                currentPasswordValidationLbl.Visible = true;
                currentPasswordValidationLbl.Text = ex.Message;
            }
        }
    }

    public bool ValidateInputs()
    {
        bool isValid = true;
        string errorMessage;

        // Validate new password
        if (!_inputValidator.ValidatePassword(newPasswordTxtBox.Text, out errorMessage))
        {
            newPasswordValidationLbl.Visible = true;
            newPasswordValidationLbl.Text = errorMessage;
            isValid = false;
        }
        else
        {
            newPasswordValidationLbl.Visible = false;
        }

        // Validate confirm new password
        if (!_inputValidator.ValidatePassword(confirmNewPasswordTxtBox.Text, out errorMessage))
        {
            confirmNewPasswordValidationLbl.Visible = true;
            confirmNewPasswordValidationLbl.Text = errorMessage;
            isValid = false;
        }
        else
        {
            confirmNewPasswordValidationLbl.Visible = false;
        }

        // Validate current password
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

        if (newPasswordTxtBox.Text != confirmNewPasswordTxtBox.Text)
        {
            newPasswordValidationLbl.Visible = true;
            confirmNewPasswordValidationLbl.Visible = true;

            newPasswordValidationLbl.Text = "These fields do not match";
            confirmNewPasswordValidationLbl.Text = "These fields do not match";
            isValid = false;
        }

        return isValid;
    }
}