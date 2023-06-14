using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalInfrastructure.Helpers;
using JobPortalLogic.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace JobPortalInfrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;
    private readonly SqlConnection _connection;

    public UserRepository()
    {
        _connectionString = ConnectionStringHelper.GetConnectionString();
        _connection = new SqlConnection(_connectionString);
    }

    public async Task<User?> GetUserByEmailAsync(string email, AccountType accountType)
    {
        string query = "SELECT * FROM [User] WHERE email = @email AND accountType = @accountType";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@AccountType", (int)accountType);

                await _connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                if (!reader.HasRows)
                {
                    return null;
                }

                await reader.ReadAsync();

                User user = new User(id: reader.GetInt32(reader.GetOrdinal("id")),
                                     email: reader.GetString(reader.GetOrdinal("email")),
                                     password: reader.GetString(reader.GetOrdinal("password")));

                reader.Close();
                await _connection.CloseAsync();

                return user;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the user data from the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task<bool> CheckIfEmailExistsAsync(string email)
    {
        string query = "SELECT COUNT(*) FROM [User] WHERE email = @Email";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                await _connection.OpenAsync();

                int count = (int)await command.ExecuteScalarAsync();

                await _connection.CloseAsync();

                return count > 0;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while checking if email exists in the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task<User> GetUserDetailsByIdAsync(int userId, AccountType accountType)
    {
        string query = "SELECT * FROM [User] WHERE id = @id AND accountType = @accountType";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@id", userId);
                command.Parameters.AddWithValue("@accountType", (int)accountType);

                await _connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                await reader.ReadAsync();

                // Create a new user object based on account type

                User user;
                if (accountType == AccountType.Employer)
                {
                    user = new Employer(
                        email: reader.GetString(reader.GetOrdinal("email")),
                        location: reader.GetString(reader.GetOrdinal("location")),
                        companyName: reader.GetString(reader.GetOrdinal("companyName")),
                        companySize: (CompanySize)Enum.Parse(typeof(CompanySize),
                                     reader.GetByte(reader.GetOrdinal("companySize")).ToString()));
                }
                else if (accountType == AccountType.Jobseeker)
                {
                    user = new Jobseeker(
                        email: reader.GetString(reader.GetOrdinal("email")),
                        location: reader.GetString(reader.GetOrdinal("location")),
                        firstName: reader.GetString(reader.GetOrdinal("firstName")),
                        lastName: reader.GetString(reader.GetOrdinal("lastName")),
                        phoneNumber: reader.GetString(reader.GetOrdinal("phoneNumber")));
                }
                else
                {
                    throw new ArgumentException("Invalid account type specified.");
                }

                reader.Close();
                await _connection.CloseAsync();

                return user;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the user data from the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task<string> GetUserPasswordByIdAsync(int userId)
    {
        string query = "SELECT password FROM [User] WHERE id = @id";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@id", userId);

                await _connection.OpenAsync();
                object result = await command.ExecuteScalarAsync();

                string password = result.ToString();

                await _connection.CloseAsync();

                return password;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the user's password from the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task<string> GetUserEmailByIdAsync(int userId)
    {
        string query = "SELECT email FROM [User] WHERE id = @id";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@id", userId);

                await _connection.OpenAsync();
                object result = await command.ExecuteScalarAsync();

                string email = result.ToString();

                await _connection.CloseAsync();

                return email;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the user's email from the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task UpdateUserEmailByIdAsync(int userId, string newEmail)
    {
        string query = "UPDATE [User] SET email=@NewEmail WHERE id=@UserId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@NewEmail", newEmail);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while updating the user's email in the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task UpdateUserPasswordByIdAsync(int userId, string newPassword)
    {
        string query = "UPDATE [User] SET password=@NewPassword WHERE id=@UserId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@NewPassword", newPassword);

                await _connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while updating the user's password in the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task UpdateJobseekerDetailsAsync(Jobseeker jobseeker)
    {
        string query = "UPDATE [User] SET firstName=@FirstName, lastName=@LastName, location=@Location, phoneNumber=@PhoneNumber " +
                       "WHERE id=@Id";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", jobseeker.Id);
                command.Parameters.AddWithValue("@FirstName", jobseeker.FirstName);
                command.Parameters.AddWithValue("@LastName", jobseeker.LastName);
                command.Parameters.AddWithValue("@Location", jobseeker.Location);
                command.Parameters.AddWithValue("@PhoneNumber", jobseeker.PhoneNumber);

                await _connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while updating the jobseeker details in the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task UpdateEmployerDetailsAsync(Employer employer)
    {
        string query = "UPDATE [User] SET companyName=@CompanyName, companySize=@CompanySize, location=@Location " +
                       "WHERE id=@Id";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Id", employer.Id);
                command.Parameters.AddWithValue("@CompanyName", employer.CompanyName);
                command.Parameters.AddWithValue("@CompanySize", (int)employer.CompanySize);
                command.Parameters.AddWithValue("@Location", employer.Location);

                await _connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while updating the employer details in the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    // Includes a SELECT query which returns the added User's ID. This is used for logging in after account creation.

    public async Task<int> AddUserAsync(User user, AccountType accountType)
    {
        // Construct SQL query based on account type

        string query = "INSERT INTO [User] (email, password, location, accountType";
        List<string> values = new List<string> { "@Email", "@Password", "@Location", "@AccountType" };

        if (accountType == AccountType.Employer)
        {
            query += ", companyName, companySize) VALUES ";
            values.Add("@CompanyName");
            values.Add("@CompanySize");
        }
        else if (accountType == AccountType.Jobseeker)
        {
            query += ", firstName, lastName, phoneNumber) VALUES ";
            values.Add("@FirstName");
            values.Add("@LastName");
            values.Add("@PhoneNumber");
        }
        else
        {
            throw new ArgumentException("Invalid account type specified.");
        }

        // Append the values to the query string

        query += "(" + string.Join(",", values) + "); SELECT CAST(SCOPE_IDENTITY() AS INT)";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Location", user.Location);
                command.Parameters.AddWithValue("@AccountType", (int)accountType);

                if (accountType == AccountType.Employer)
                {
                    Employer employer = (Employer)user;
                    command.Parameters.AddWithValue("@CompanyName", employer.CompanyName);
                    command.Parameters.AddWithValue("@CompanySize", (int)employer.CompanySize);
                }
                else if (accountType == AccountType.Jobseeker)
                {
                    Jobseeker jobseeker = (Jobseeker)user;
                    command.Parameters.AddWithValue("@FirstName", jobseeker.FirstName);
                    command.Parameters.AddWithValue("@LastName", jobseeker.LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", jobseeker.PhoneNumber);
                }

                await _connection.OpenAsync();
                int userId = (int)await command.ExecuteScalarAsync();
                await _connection.CloseAsync();

                return userId;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while adding the user to the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }

    public async Task DeleteUserAccountByIdAsync(int userId)
    {
        string query = "DELETE FROM [User] WHERE id = @UserId;";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while deleting the user from the database.", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred: " + ex.Message, ex);
        }
        finally
        {
            if (_connection.State != ConnectionState.Closed)
            {
                await _connection.CloseAsync();
            }
        }
    }
}