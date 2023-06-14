using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Interfaces;

public interface IUserRepository
{
    Task<User?> GetUserByEmailAsync(string email, AccountType accountType);

    Task<bool> CheckIfEmailExistsAsync(string email);

    Task<User> GetUserDetailsByIdAsync(int id, AccountType accountType);

    Task<string> GetUserPasswordByIdAsync(int userId);

    Task<string> GetUserEmailByIdAsync(int userId);

    Task UpdateUserEmailByIdAsync(int userId, string newEmail);

    Task UpdateUserPasswordByIdAsync(int userId, string newPassword);

    Task UpdateJobseekerDetailsAsync(Jobseeker jobseeker);

    Task UpdateEmployerDetailsAsync(Employer employer);

    Task<int> AddUserAsync(User user, AccountType accountType);

    Task DeleteUserAccountByIdAsync(int userId);
}