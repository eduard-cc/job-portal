using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JobPortalDomain.Models;

public class Jobseeker : User
{
    [Display(Name = "First name")]
    [Required(ErrorMessage = "This field is required.")]
    [StringLength(50, ErrorMessage = "Must not exceed 50 characters.")]
    public string FirstName { get; set; }

    [Display(Name = "Last name")]
    [Required(ErrorMessage = "This field is required.")]
    [StringLength(50, ErrorMessage = "Must not exceed 50 characters.")]
    public string LastName { get; set; }

    [Display(Name = "Phone number")]
    [Required(ErrorMessage = "This field is required.")]
    [Phone(ErrorMessage = "Format is invalid.")]
    [StringLength(20, ErrorMessage = "Must not exceed 20 characters.")]
    public string PhoneNumber { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public Jobseeker() { }

    public Jobseeker(string email, string location, string firstName, string lastName, string phoneNumber) : base(email, location)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }

    public Jobseeker(string location, string email, string password, string firstName, string lastName, string phoneNumber) : base(location)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Location = location;
        PhoneNumber = phoneNumber;
    }

    public Jobseeker(int id) : base(id)
    {
        Id = id;
    }

    public Jobseeker(string location, string firstName, string lastName, string phoneNumber) : base(location)
    {
        Location = location;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"{PhoneNumber}\n{Email}\n{Location}";
    }
}