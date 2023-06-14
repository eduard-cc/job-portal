using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalDomain.Models;

public class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    [StringLength(254, ErrorMessage = "Must not exceed 254 characters.")]
    [EmailAddress(ErrorMessage = "Format is invalid.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
    [StringLength(128, ErrorMessage = "Must not exceed 128 characters.")]
    public string Password { get; set; }

    [Required(ErrorMessage = "This field is required.")]
    [StringLength(50, ErrorMessage = "Must not exceed 50 characters.")]
    public string Location { get; set; }

    public User(int id, string email, string password, string location)
    {
        Id = id;
        Email = email;
        Password = password;
        Location = location;
    }
    public User() { }

    public User(string location)
    {
        Location = location;
    }
    public User(string email, string location)
    {
        Email = email;
        Location = location;
    }
    public User(int id, string email, string password)
    {
        Id = id;
        Email = email;
        Password = password;
    }
    public User(int id)
    {
        Id = id;
    }
}