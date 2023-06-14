using JobPortalDesktop.UserControls;
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

public partial class Signup : Form
{
    private UserControl? activeUserControl;
    public Signup()
    {
        InitializeComponent();
        OpenUserControl(new JobseekerSignupForm(this));
    }

    private void jobseekerRadioBtn_CheckedChanged(object sender, EventArgs e)
    {

        OpenUserControl(new JobseekerSignupForm(this));
    }

    private void employerRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
        OpenUserControl(new EmployerSignupForm(this));
    }

    private void logInBtn_Click(object sender, EventArgs e)
    {
        Close();
        Login login = new Login();
        login.Show();
    }

    public void OpenUserControl(UserControl userControl)
    {
        if (activeUserControl != null)
        {
            activeUserControl.Dispose();
        }
        activeUserControl = userControl;
        formPanel.Controls.Add(activeUserControl);
        formPanel.Tag = activeUserControl;
        activeUserControl.BringToFront();
        activeUserControl.Show();
    }
}
