﻿using JobPortalDomain.Enums;
using JobPortalDomain.Models;
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

public partial class EmployerDashboard : Form
{
    int currentUserId;
    AccountType currentUserAccountType;

    // Form that is currently displayed in the panel
    private Form? activeForm = null;
    List<Control> controls;

    public EmployerDashboard(int userId, AccountType accountType)
    {
        InitializeComponent();

        currentUserId = userId;
        currentUserAccountType = accountType;
        controls = new List<Control>
        {
            findJobsBtn,
            profileBtn,
            accountBtn,
            jobsBtn
        };
        SetNavBarButtonColors(findJobsBtn);
        OpenChildForm(new SearchJobs(currentUserId, currentUserAccountType));
    }

    private void OpenChildForm(Form childForm)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }
        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.Dock = DockStyle.Fill;
        containerPanel.Controls.Add(childForm);
        containerPanel.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
    }

    private void findJobsBtn_Click(object sender, EventArgs e)
    {
        SetNavBarButtonColors(findJobsBtn);
        OpenChildForm(new SearchJobs(currentUserId, currentUserAccountType));
    }

    private void profileBtn_Click(object sender, EventArgs e)
    {
        SetNavBarButtonColors(profileBtn);
        OpenChildForm(new EmployerProfile(currentUserId));
    }

    private void accountBtn_Click(object sender, EventArgs e)
    {
        SetNavBarButtonColors(accountBtn);
        OpenChildForm(new UserAccount(currentUserId, currentUserAccountType, this));
    }

    private void jobsBtn_Click(object sender, EventArgs e)
    {
        SetNavBarButtonColors(jobsBtn);
        OpenChildForm(new EmployerJobs(currentUserId));
    }


    private void logOutBtn_Click(object sender, EventArgs e)
    {
        Login login = new Login();
        Close();
        login.Show();
    }

    private void SetNavBarButtonColors(Control clickedControl)
    {
        foreach (Control control in controls)
        {
            if (clickedControl == control)
            {
                clickedControl.BackColor = Color.FromArgb(31, 37, 46);
            }
            else
            {
                control.BackColor = Color.FromArgb(55, 65, 81);
            }
        }
    }
}
