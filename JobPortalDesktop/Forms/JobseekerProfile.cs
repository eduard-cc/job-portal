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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortalDesktop.Forms;

public partial class JobseekerProfile : Form
{
    private readonly UserService _userService;
    private readonly InputValidator _inputValidator;

    int currentUserId;

    public JobseekerProfile(int userId)
    {
        InitializeComponent();

        currentUserId = userId;

        _userService = Program.Container.Resolve<UserService>();
        _inputValidator = Program.Container.Resolve<InputValidator>();
    }

    private async void JobseekerProfile_Load(object sender, EventArgs e)
    {
        Jobseeker jobseeker = (Jobseeker)await _userService.GetUserDetailsByIdAsync(currentUserId, AccountType.Jobseeker);

        firstNameTxtBox.Text = jobseeker.FirstName;
        lastNameTxtBox.Text = jobseeker.LastName;
        locationTxtBox.Text = jobseeker.Location;
        phoneNumberTxtBox.Text = jobseeker.PhoneNumber;
    }

    private async void saveBtn_Click(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();

        if (isValid)
        {
            Jobseeker jobseeker = new Jobseeker(location: locationTxtBox.Text,
                                                firstName: firstNameTxtBox.Text,
                                                lastName: lastNameTxtBox.Text,
                                                phoneNumber: phoneNumberTxtBox.Text);
            jobseeker.Id = currentUserId;

            await _userService.UpdateUserDetailsAsync(jobseeker, AccountType.Jobseeker);

            successMessageProfileLbl.Visible = true;
            successMessageProfileLbl.Text = "Profile updated successfully!";
        }
    }

    public bool ValidateInputs()
    {
        bool isValid = true;
        string errorMessage;

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
