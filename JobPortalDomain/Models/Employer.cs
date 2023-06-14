using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JobPortalDomain.Models;

public enum CompanySize
{
    [Display(Name = "10 to 99")]
    Small,
    [Display(Name = "100 to 499")]
    Medium,
    [Display(Name = "500+")]
    Large
}
public class Employer : User
{
    [Display(Name = "Company name")]
    [Required(ErrorMessage = "This field is required.")]
    [StringLength(50, ErrorMessage = "Must not exceed 50 characters.")]
    public string CompanyName { get; set; }

    [Display(Name = "Number of employees")]
    public CompanySize CompanySize { get; set; }

    public Employer(string email, string location, string companyName, CompanySize companySize) : base(email, location)
    {
        CompanyName = companyName;
        CompanySize = companySize;
    }

    public Employer(string location, string companyName) : base(location)
    {
        CompanyName = companyName;
    }

    public Employer(string location, string companyName, CompanySize companySize) : base(location)
    {
        CompanyName = companyName;
        CompanySize = companySize;
    }

    public Employer() { }

    public Employer(string location, string email, string password, string companyName, CompanySize companySize) : base(location)
    {
        Email = email;
        Password = password;
        CompanyName = companyName;
        Location = location;
    }
}