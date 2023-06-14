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

public partial class UserAccount : Form
{
    public event EventHandler ChildFormEventTriggered;
    private readonly UserService _userService;

    int currentUserId;
    AccountType currentUserAccountType;
    string currentEmail;
    Form dashboardForm;

    public UserAccount(int userId, AccountType accountType, Form dashboardForm)
    {
        InitializeComponent();
        _userService = Program.Container.Resolve<UserService>();
        currentUserId = userId;
        currentUserAccountType = accountType;
        this.dashboardForm = dashboardForm;
    }

    private async void UserAccount_Load(object sender, EventArgs e)
    {
        currentEmail = await _userService.GetUserEmailByIdAsync(currentUserId);
        userEmailLbl.Text = currentEmail;
    }

    private async void changeEmailBtn_Click(object sender, EventArgs e)
    {
        ChangeEmail changeEmail = new ChangeEmail(currentUserId, currentEmail);
        DialogResult result = changeEmail.ShowDialog();
        if (result == DialogResult.OK)
        {
            successMessageEmailLbl.Visible = true;
            successMessageEmailLbl.Text = "Email updated successfully!";
            currentEmail = await _userService.GetUserEmailByIdAsync(currentUserId);
            userEmailLbl.Text = currentEmail;
        }
    }

    private void ChangePasswordBtn_Click(object sender, EventArgs e)
    {
        ChangePassword changePassword = new ChangePassword(currentUserId);
        DialogResult result = changePassword.ShowDialog();
        if (result == DialogResult.OK)
        {
            successMessagePasswordLbl.Visible = true;
            successMessagePasswordLbl.Text = "Password updated successfully!";
        }
    }

    private async void deleteAccountBtn_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account? " +
            "\nThis action cannot be undone.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (dialogResult == DialogResult.Yes)
        {
            userEmailLbl.Text = await _userService.GetUserEmailByIdAsync(currentUserId);

            await _userService.DeleteUserByIdAsync(currentUserId, currentUserAccountType);

            Signup signUpForm = new Signup();
            signUpForm.Show();
            dashboardForm.Close();
        }
    }
}
