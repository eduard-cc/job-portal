using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JobPortalDomain.Models;

public enum SalaryRate
{
    [Display(Name = "per hour")]
    Hour,
    [Display(Name = "per day")]
    Day,
    [Display(Name = "per week")]
    Week,
    [Display(Name = "per month")]
    Month,
    [Display(Name = "per year")]
    Year
}

public enum SalaryType
{
    [Display(Name = "Exact amount")]
    ExactAmount,
    Range
}

public class Salary
{
    [Required(ErrorMessage = "This field is required.")]
    [Range(typeof(decimal), "1", "10000000", ErrorMessage = "This field cannot exceed 7 digits.")]
    public decimal? Amount { get; set; }

    [Display(Name = "Minimum")]
    [Required(ErrorMessage = "This field is required.")]
    [Range(typeof(decimal), "1", "10000000", ErrorMessage = "This field cannot exceed 7 digits.")]
    public decimal? MinAmount { get; set; }

    [Display(Name = "Maximum")]
    [Required(ErrorMessage = "This field is required.")]
    [Range(typeof(decimal), "1", "1000000", ErrorMessage = "This field cannot exceed 7 digits.")]
    public decimal? MaxAmount { get; set; }

    public SalaryRate Rate { get; set; }

    [Display(Name = "Salary type")]
    public SalaryType Type { get; set; }

    public Salary(decimal? amount, decimal? minAmount, decimal? maxAmount, SalaryRate rate, SalaryType type)
    {
        Amount = amount;
        MinAmount = minAmount;
        MaxAmount = maxAmount;
        Rate = rate;
        Type = type;
    }

    public Salary() { }

    /// <summary>
    ///     Salary may be a range or an exact amount.
    ///     If it is a range, then MinAmount and MaxAmount will be set.
    ///     If it is an exact amount, then Amount will be set.
    /// </summary>

    public string DisplaySalary()
    {
        if (Type == SalaryType.ExactAmount)
        {
            decimal amount = Amount.Value;
            string amountString = $"€{amount:#,0.##}";
            return $"{amountString} per {Rate.ToString().ToLower()}";
        }
        else if (Type == SalaryType.Range)
        {
            decimal minAmount = MinAmount.Value;
            decimal maxAmount = MaxAmount.Value;
            string minAmountString = $"€{minAmount:#,0.##}";
            string maxAmountString = $"€{maxAmount:#,0.##}";
            return $"{minAmountString} - {maxAmountString} per {Rate.ToString().ToLower()}";
        }
        else
        {
            return "Salary unknown.";
        }
    }

    public override string ToString()
    {
        return DisplaySalary();
    }
}