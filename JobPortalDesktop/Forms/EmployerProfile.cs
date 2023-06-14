using Autofac;
using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Extensions;
using JobPortalLogic.Services;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace JobPortalDesktop.Forms;

public partial class EmployerProfile : Form
{
    private readonly UserService _userService;

    int currentUserId;

    public EmployerProfile(int userId)
    {
        InitializeComponent();

        currentUserId = userId;

        _userService = Program.Container.Resolve<UserService>();

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

    private async void EmployerProfile_Load(object sender, EventArgs e)
    {
        Employer employer = (Employer)await _userService.GetUserDetailsByIdAsync(currentUserId, AccountType.Employer);

        companyNameTxtBox.Text = employer.CompanyName;
        companySizeComboBox.SelectedValue = employer.CompanySize;
        locationTxtBox.Text = employer.Location;
    }

    private async void saveBtn_Click(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            Employer employer = new Employer(location: locationTxtBox.Text,
                                             companyName: companyNameTxtBox.Text,
                                             companySize: (CompanySize)companySizeComboBox.SelectedValue);
            employer.Id = currentUserId;

            await _userService.UpdateUserDetailsAsync(employer, AccountType.Employer);

            successMessageProfileLbl.Visible = true;
            successMessageProfileLbl.Text = "Profile updated successfully!";
        }
    }

    public bool ValidateInputs()
    {
        bool isValid = true;
        string errorMessage;

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
