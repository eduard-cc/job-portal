using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalLogic.Exceptions;
using JobPortalLogic.Interfaces;
using JobPortalLogic.Services;
using JobPortalTest.FakeRepositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalTest.Tests;

[TestClass]
public class UserServiceTests
{
    private readonly FakeUserRepository _fakeUserRepository;
    private readonly FakeJobRepository _fakeJobRepository;
    private readonly UserService _userService;

    public UserServiceTests()
    {
        _fakeUserRepository = new FakeUserRepository();
        _fakeJobRepository = new FakeJobRepository();
        _userService = new UserService(_fakeUserRepository, new FakeJobRepository(), new PasswordService());
    }

    [TestMethod]
    public async Task GetUserEmailByIdAsync_ExistingUserId_ReturnsUserEmail()
    {
        // Arrange
        int userId = 1;
        string expectedEmail = "test@example.com";
        await _fakeUserRepository.AddUserAsync(new User { Id = userId, Email = expectedEmail }, AccountType.Jobseeker);

        // Act
        string? userEmail = await _userService.GetUserEmailByIdAsync(userId);

        // Assert
        Assert.AreEqual(expectedEmail, userEmail);
    }

    [TestMethod]
    public async Task GetUserDetailsByIdAsync_ExistingUserIdAndAccountType_ReturnsUserDetails()
    {
        // Arrange
        int userId = 1;
        AccountType accountType = AccountType.Jobseeker;
        User expectedUser = new User { Id = userId };
        await _fakeUserRepository.AddUserAsync(expectedUser, accountType);

        // Act
        User? userDetails = await _userService.GetUserDetailsByIdAsync(userId, accountType);

        // Assert
        Assert.IsNotNull(userDetails);
        Assert.AreEqual(expectedUser.Id, userDetails.Id);
    }

    [TestMethod]
    public async Task GetUserDetailsByIdAsync_ExistingUserIdButDifferentAccountType_ReturnsNull()
    {
        // Arrange
        int userId = 1;
        AccountType accountType = AccountType.Jobseeker;
        User user = new User { Id = userId };
        await _fakeUserRepository.AddUserAsync(user, accountType);

        // Act
        User? userDetails = await _userService.GetUserDetailsByIdAsync(userId, AccountType.Employer);

        // Assert
        Assert.IsNull(userDetails);
    }

    [TestMethod]
    public async Task UpdateUserDetailsAsync_JobseekerAccountType_UpdatesJobseekerDetails()
    {
        // Arrange
        int userId = 1;
        AccountType accountType = AccountType.Jobseeker;
        User existingUser = new Jobseeker { Id = userId, FirstName = "John", LastName = "Doe", Location = "New York", PhoneNumber = "123456789" };
        await _fakeUserRepository.AddUserAsync(existingUser, accountType);
        Jobseeker updatedUser = new Jobseeker { Id = userId, FirstName = "Jane", LastName = "Smith", Location = "London", PhoneNumber = "987654321" };

        // Act
        await _userService.UpdateUserDetailsAsync(updatedUser, accountType);

        // Assert
        UserWithAccountType userWithAccountType = _fakeUserRepository.GetUserWithAccountTypeById(userId, accountType);
        Assert.IsNotNull(userWithAccountType);
        Jobseeker jobseeker = (Jobseeker)userWithAccountType.User;
        Assert.AreEqual(updatedUser.FirstName, jobseeker.FirstName);
        Assert.AreEqual(updatedUser.LastName, jobseeker.LastName);
        Assert.AreEqual(updatedUser.Location, jobseeker.Location);
        Assert.AreEqual(updatedUser.PhoneNumber, jobseeker.PhoneNumber);
    }

    [TestMethod]
    public async Task UpdateUserDetailsAsync_EmployerAccountType_UpdatesEmployerDetails()
    {
        // Arrange
        int userId = 1;
        AccountType accountType = AccountType.Employer;
        User existingUser = new Employer { Id = userId, CompanyName = "ABC Corp", CompanySize = CompanySize.Large, Location = "San Francisco" };
        await _fakeUserRepository.AddUserAsync(existingUser, accountType);
        Employer updatedUser = new Employer { Id = userId, CompanyName = "XYZ Inc", CompanySize = CompanySize.Medium, Location = "Seattle" };

        // Act
        await _userService.UpdateUserDetailsAsync(updatedUser, accountType);

        // Assert
        UserWithAccountType userWithAccountType = _fakeUserRepository.GetUserWithAccountTypeById(userId, accountType);
        Assert.IsNotNull(userWithAccountType);
        Employer employer = (Employer)userWithAccountType.User;
        Assert.AreEqual(updatedUser.CompanyName, employer.CompanyName);
        Assert.AreEqual(updatedUser.CompanySize, employer.CompanySize);
        Assert.AreEqual(updatedUser.Location, employer.Location);
    }

    [TestMethod]
    public async Task ChangeUserEmailAsync_EmailAlreadyExists_ThrowsEmailInUseException()
    {
        // Arrange
        int userId = 1;
        string currentEmail = "test@example.com";
        string newEmail = "existingemail@example.com";
        string password = "password";
        await _fakeUserRepository.AddUserAsync(new User { Id = userId, Email = currentEmail }, AccountType.Jobseeker);
        await _fakeUserRepository.AddUserAsync(new User { Email = newEmail }, AccountType.Jobseeker);

        try
        {
            // Act
            await _userService.ChangeUserEmailAsync(userId, newEmail, password);

            // Assert
            Assert.Fail("Expected EmailInUseException was not thrown.");
        }
        catch (EmailInUseException)
        {
            // Exception was thrown as expected
        }
    }

    [TestMethod]
    public async Task DeleteUserByIdAsync_EmployerAccount_DeletesJobsAndUserAccount()
    {
        // Arrange
        int userId = 1;
        AccountType accountType = AccountType.Employer;

        // Add sample jobs and user to the repositories
        _fakeJobRepository.AddJob(new Job { Id = 1, Employer = new Employer { Id = userId } });
        _fakeJobRepository.AddJob(new Job { Id = 2, Employer = new Employer { Id = 2 } });
        await _fakeUserRepository.AddUserAsync(new User { Id = userId }, accountType);

        // Act
        await _userService.DeleteUserByIdAsync(userId, accountType);

        // Assert
        List<Job> remainingJobs = _fakeJobRepository.GetJobsByEmployerIdAsync(userId).Result;
        User deletedUser = await _fakeUserRepository.GetUserDetailsByIdAsync(userId, accountType);
        
        Assert.AreEqual(1, remainingJobs.Count); // Only one job should remain after deletion
        Assert.IsNull(deletedUser); // User should be deleted
    }
}