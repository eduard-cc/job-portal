using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Exceptions;
using JobPortalLogic.Interfaces;

namespace JobPortalLogic.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IJobRepository _jobRepository;
    private readonly PasswordService _passwordService;

    public UserService(IUserRepository userRepository, IJobRepository jobRepository, PasswordService passwordService)
    {
        _userRepository = userRepository;
        _jobRepository = jobRepository;
        _passwordService = passwordService;
    }
        
    public async Task ValidatePasswordByUserId(int userId, string password)
    {
        string correctHash = await _userRepository.GetUserPasswordByIdAsync(userId);

        bool passwordValidation = _passwordService.ValidatePassword(password, correctHash);

        if (!passwordValidation)
        {
            throw new IncorrectPasswordException();
        }
    }

    public async Task DeleteUserByIdAsync(int userId, AccountType accountType)
    {
        // Delete all jobs, saved jobs or applications associated with account
        if (accountType == AccountType.Employer)
        {
            await _jobRepository.DeleteJobsByEmployerIdAsync(userId);
        }
        else
        {
            await _jobRepository.DeleteApplicationsAndSavedJobsByJobseekerIdAsync(userId);
        }

        await _userRepository.DeleteUserAccountByIdAsync(userId);
    }

    public async Task ChangeUserEmailAsync(int userId, string newEmail, string password)
    {
        bool emailAlreadyExists = await _userRepository.CheckIfEmailExistsAsync(newEmail);

        if (emailAlreadyExists)
        {
            throw new EmailInUseException();
        }

        await ValidatePasswordByUserId(userId, password);

        await _userRepository.UpdateUserEmailByIdAsync(userId, newEmail);
    }

    public async Task ChangeUserPasswordAsync(int userId, string newPassword, string currentPassword)
    {
        await ValidatePasswordByUserId(userId, currentPassword);

        newPassword = _passwordService.HashPassword(newPassword);

        await _userRepository.UpdateUserPasswordByIdAsync(userId, newPassword);
    }

    public async Task<int> CreateUserAccountAsync(User user, AccountType accountType)
    {
        bool emailAlreadyExists = await _userRepository.CheckIfEmailExistsAsync(user.Email);

        if (emailAlreadyExists)
        {
            throw new EmailInUseException();
        }

        user.Password = _passwordService.HashPassword(user.Password);

        // Handle account creation and return the Id to be used for authentication
        user.Id = await _userRepository.AddUserAsync(user, accountType);

        return user.Id;
    }

    public async Task<User> AuthenticateUser(string email, string password, AccountType accountType)
    {
        User? user = await _userRepository.GetUserByEmailAsync(email, accountType);

        if (user is null)
        {
            throw new IncorrectCredentialsException();
        }

        bool validation = _passwordService.ValidatePassword(password, user.Password);

        if (validation is false)
        {
            throw new IncorrectCredentialsException();
        }

        return user;
    }

    public async Task UpdateUserDetailsAsync(User user, AccountType accountType)
    {
        if (accountType == AccountType.Jobseeker)
        {
            await _userRepository.UpdateJobseekerDetailsAsync((Jobseeker)user);
        }
        else
        {
            await _userRepository.UpdateEmployerDetailsAsync((Employer)user);
        }
    }

    public async Task<User?> GetUserDetailsByIdAsync(int id, AccountType accountType)
    {
        return await _userRepository.GetUserDetailsByIdAsync(id, accountType);
    }

    public async Task<string?> GetUserEmailByIdAsync(int userId)
    {
        return await _userRepository.GetUserEmailByIdAsync(userId);
    }
}
