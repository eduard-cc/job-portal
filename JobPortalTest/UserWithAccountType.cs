using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalTest;

/// <summary>
/// Allows creating a list in the FakeUserRepository that associates an AccountType to each User
/// </summary>
public class UserWithAccountType
{
    public User User { get; set; }
    public AccountType AccountType { get; set; }

    public UserWithAccountType(User user, AccountType accountType)
    {
        User = user;
        AccountType = accountType;
    }
    public UserWithAccountType() { }
}
