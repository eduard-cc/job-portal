using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobPortalLogic.Extensions;

public class InputValidator
{
    public bool ValidateEmail(string email, out string errorMessage)
    {
        if (String.IsNullOrWhiteSpace(email))
        {
            errorMessage = "This field is required.";
            return false;
        }

        Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);

        if (!emailRegex.IsMatch(email))
        {
            errorMessage = "Format is invalid.";
            return false;
        }

        errorMessage = null;
        return true;
    }

    public bool ValidatePassword(string password, out string errorMessage)
    {
        if (String.IsNullOrWhiteSpace(password))
        {
            errorMessage = "This field is required";
            return false;
        }
        if (password.Length < 8)
        {
            errorMessage = "Must be at least 8 characters long.";
            return false;
        }

        errorMessage = null;
        return true;
    }

    public bool ValidatePhoneNumber(string phoneNumber, out string errorMessage)
    {
        if (string.IsNullOrEmpty(phoneNumber))
        {
            errorMessage = "This field is required.";
            return false;
        }

        // Remove any whitespace or dashes from the phone number
        phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");

        if (!phoneNumber.All(char.IsDigit))
        {
            errorMessage = "Must contain only digits.";
            return false;
        }

        if (phoneNumber.Length != 10)
        {
            errorMessage = "Length must be 10 digits.";
            return false;
        }

        errorMessage = null;
        return true;
    }

    public bool ValidateSalaryAmount(string exactAmount, out string errorMessage)
    {
        if (decimal.TryParse(exactAmount, out decimal result))
        {
            if (result >= 1 && result <= 1000000)
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "This field must be a number between 1 and 1000000";
                return false;
            }
        }
        else
        {
            errorMessage = "This field must be a number.";
            return false;
        }
    }
}