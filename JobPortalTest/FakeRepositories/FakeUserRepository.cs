using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalTest.FakeRepositories;

public class FakeUserRepository : IUserRepository
{
    private readonly List<UserWithAccountType> _users;

    public FakeUserRepository()
    {
        _users = new List<UserWithAccountType>();
    }

    public UserWithAccountType GetUserWithAccountTypeById(int userId, AccountType accountType)
    {
        return _users.FirstOrDefault(u => u.User.Id == userId && u.AccountType == accountType);
    }

    public async Task<User?> GetUserByEmailAsync(string email, AccountType accountType)
    {
        UserWithAccountType userWithAccountType = _users.FirstOrDefault(u => u.User.Email == email && u.AccountType == accountType);

        if (userWithAccountType != null)
        {
            return await Task.FromResult(userWithAccountType.User);
        }

        return await Task.FromResult<User?>(null);
    }

    public async Task<bool> CheckIfEmailExistsAsync(string email)
    {
        return _users.Any(u => u.User.Email == email);
    }

    public async Task<User?> GetUserDetailsByIdAsync(int id, AccountType accountType)
    {
        UserWithAccountType userWithAccountType = _users.FirstOrDefault(u => u.User.Id == id && u.AccountType == accountType);
        return userWithAccountType?.User;
    }

    public async Task<string> GetUserPasswordByIdAsync(int userId)
    {
        UserWithAccountType user = _users.FirstOrDefault(u => u.User.Id == userId);
        return user.User.Password;
    }

    public async Task<string?> GetUserEmailByIdAsync(int userId)
    {
        UserWithAccountType user = _users.FirstOrDefault(u => u.User.Id == userId);
        return user.User.Email;
    }

    public async Task UpdateUserEmailByIdAsync(int userId, string newEmail)
    {
        UserWithAccountType user = _users.FirstOrDefault(u => u.User.Id == userId);
        if (user != null)
        {
            user.User.Email = newEmail;
        }
    }

    public async Task UpdateUserPasswordByIdAsync(int userId, string newPassword)
    {
        UserWithAccountType user = _users.FirstOrDefault(u => u.User.Id == userId);
        if (user != null)
        {
            user.User.Password = newPassword;
        }
    }

    public async Task UpdateJobseekerDetailsAsync(Jobseeker jobseeker)
    {
        UserWithAccountType user = _users.FirstOrDefault(u => u.User.Id == jobseeker.Id && u.AccountType == AccountType.Jobseeker);
        if (user != null)
        {
            Jobseeker existingJobseeker = (Jobseeker)user.User;
            existingJobseeker.FirstName = jobseeker.FirstName;
            existingJobseeker.LastName = jobseeker.LastName;
            existingJobseeker.Location = jobseeker.Location;
            existingJobseeker.PhoneNumber = jobseeker.PhoneNumber;
        }
    }

    public async Task UpdateEmployerDetailsAsync(Employer employer)
    {
        UserWithAccountType user = _users.FirstOrDefault(u => u.User.Id == employer.Id && u.AccountType == AccountType.Employer);
        if (user != null)
        {
            Employer existingEmployer = (Employer)user.User;
            existingEmployer.CompanyName = employer.CompanyName;
            existingEmployer.CompanySize = employer.CompanySize;
            existingEmployer.Location = employer.Location;
        }
    }

    public async Task<int> AddUserAsync(User user, AccountType accountType)
    {
        UserWithAccountType userWithAccountType = new UserWithAccountType()
        {
            User = user,
            AccountType = accountType
        };

        _users.Add(userWithAccountType);

        int userId = _users.Count; // Simulates auto-incrementing ID 
        return userId; // This ID is used for logging in after account creation by ClaimTypes.NameIdentifier
    }

    public async Task DeleteUserAccountByIdAsync(int userId)
    {
        UserWithAccountType userToDelete = _users.FirstOrDefault(u => u.User.Id == userId);

        _users.Remove(userToDelete);
    }
}
