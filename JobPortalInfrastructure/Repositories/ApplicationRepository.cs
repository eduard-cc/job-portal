using JobPortalDomain.Models;
using JobPortalInfrastructure.Helpers;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalInfrastructure.Repositories;

public class ApplicationRepository : IApplicationRepository
{
    private readonly string _connectionString;
    private readonly SqlConnection _connection;

    public ApplicationRepository()
    {
        _connectionString = ConnectionStringHelper.GetConnectionString();
        _connection = new SqlConnection(_connectionString);
    }

    public async Task AddApplicationAsync(Application application)
    {
        string queryCv = "INSERT INTO Cv (name, contentType, data) " +
                         "VALUES (@Name, @ContentType, @Data); " +
                         "SELECT CAST(SCOPE_IDENTITY() AS INT)";

        string queryApplication = "INSERT INTO Application (userId, jobId, status, dateApplied, cvId) " +
                                  "VALUES (@UserId, @JobId, @Status, @DateApplied, @CvId); " +
                                  "SELECT CAST(SCOPE_IDENTITY() AS INT)";
        try
        {
            await _connection.OpenAsync();

            int? cvId = null;
            if (application.Cv != null)
            {
                using (SqlCommand command = new SqlCommand(queryCv, _connection))
                {
                    command.Parameters.AddWithValue("@Name", application.Cv.Name);
                    command.Parameters.AddWithValue("@ContentType", application.Cv.ContentType);
                    command.Parameters.AddWithValue("@Data", application.Cv.Data);

                    cvId = (int)await command.ExecuteScalarAsync();
                }
            }

            using (SqlCommand secondCommand = new SqlCommand(queryApplication, _connection))
            {
                secondCommand.Parameters.AddWithValue("@UserId", application.Applicant.Id);
                secondCommand.Parameters.AddWithValue("@JobId", application.Job.Id);
                secondCommand.Parameters.AddWithValue("@Status", (int)application.Status);
                secondCommand.Parameters.AddWithValue("@DateApplied", application.DateApplied.ToString("yyyy-MM-dd"));
                secondCommand.Parameters.AddWithValue("@CvId", cvId.HasValue ? (object)cvId.Value : DBNull.Value);

                await secondCommand.ExecuteScalarAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while adding the application to the database.", ex);
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

    public async Task<List<Application>> GetAllApplicationsByJobseekerIdAsync(int jobseekerId)
    {
        string query = "SELECT a.*, j.*, u.location, u.companyName " +
                       "FROM Application a " +
                       "INNER JOIN Job j ON a.jobId = j.id " +
                       "INNER JOIN [User] u ON j.userId = u.id " +
                       "WHERE a.userId = @JobseekerId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@JobseekerId", jobseekerId);

                await _connection.OpenAsync();
                using SqlDataReader reader = await command.ExecuteReaderAsync();

                List<Application> applications = new List<Application>();

                while (reader.Read())
                {
                    Employer employer = new Employer(location: reader.GetString(reader.GetOrdinal("location")),
                                                     companyName: reader.GetString(reader.GetOrdinal("companyName")));

                    Salary salary = new Salary(
                           amount: reader.IsDBNull("salaryAmount") ? null : reader.GetDecimal(reader.GetOrdinal("salaryAmount")),
                           minAmount: reader.IsDBNull("salaryMinAmount") ? null : reader.GetDecimal(reader.GetOrdinal("salaryMinAmount")),
                           maxAmount: reader.IsDBNull("salaryMaxAmount") ? null : reader.GetDecimal(reader.GetOrdinal("salaryMaxAmount")),
                           rate: (SalaryRate)Enum.Parse(typeof(SalaryRate),
                                 reader.GetByte(reader.GetOrdinal("salaryRate")).ToString()),
                           type: (SalaryType)Enum.Parse(typeof(SalaryType),
                                 reader.GetByte(reader.GetOrdinal("salaryType")).ToString()));

                    Job job = new Job(
                        id: reader.GetInt32(reader.GetOrdinal("jobId")),
                        employer: employer,
                        title: reader.GetString(reader.GetOrdinal("title")),
                        salary: salary,
                        datePosted: reader.GetDateTime(reader.GetOrdinal("datePosted")),
                        contractType: (ContractType)Enum.Parse(typeof(ContractType),
                                      reader.GetByte(reader.GetOrdinal("contractType")).ToString()));

                    Application application = new Application(id: reader.GetInt32(reader.GetOrdinal("id")),
                                                              job: job,
                                                              status: (ApplicationStatus)Enum.Parse(typeof(ApplicationStatus), 
                                                                      reader.GetByte(reader.GetOrdinal("status")).ToString()),
                                                              dateApplied: reader.GetDateTime(reader.GetOrdinal("dateApplied")));
                    applications.Add(application);
                }
                await reader.CloseAsync();
                await _connection.CloseAsync();

                return applications;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the application data from the database.", ex);
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

    public async Task<List<Application>> GetAllApplicationsByJobIdAsync(int jobId)
    {
        string query = "SELECT a.*, u.email, u.location, u.firstName, u.lastName, u.phoneNumber, c.name, c.contentType, c.data " +
                        "FROM Application a " +
                        "INNER JOIN [User] u ON a.userId = u.id " +
                        "LEFT JOIN Cv c ON a.cvId = c.Id " +
                        "WHERE a.jobId = @JobId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                using SqlDataReader reader = await command.ExecuteReaderAsync();

                List<Application> applications = new List<Application>();

                while (reader.Read())
                {
                    Jobseeker jobseeker = new Jobseeker(email: reader.GetString(reader.GetOrdinal("email")),
                                                       firstName: reader.GetString(reader.GetOrdinal("firstName")),
                                                       lastName: reader.GetString(reader.GetOrdinal("lastName")),
                                                       location: reader.GetString(reader.GetOrdinal("location")),
                                                       phoneNumber: reader.GetString(reader.GetOrdinal("phoneNumber")));
                    Cv cv = null;
                    if (!reader.IsDBNull(reader.GetOrdinal("cvId")))
                    {
                        cv = new Cv(id: reader.GetInt32(reader.GetOrdinal("cvId")),
                                    contentType: reader.GetString(reader.GetOrdinal("contentType")));
                    }
                    Application application = new Application(id: reader.GetInt32(reader.GetOrdinal("id")),
                                                              applicant: jobseeker,
                                                              status: (ApplicationStatus)Enum.Parse(typeof(ApplicationStatus),
                                                                       reader.GetByte(reader.GetOrdinal("status")).ToString()),
                                                              dateApplied: reader.GetDateTime(reader.GetOrdinal("dateApplied")),
                                                              cv: cv);
                    applications.Add(application);
                }
                await reader.CloseAsync();
                await _connection.CloseAsync();

                return applications;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the application data from the database.", ex);
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

    public async Task<Application?> GetApplicationByJobseekerAndJobIdAsync(int jobseekerId, int jobId)
    {
        string query = "SELECT * FROM Application WHERE userId = @UserId AND jobId = @JobId";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", jobseekerId);
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                Application application = null;

                if (reader.HasRows)
                {
                    await reader.ReadAsync();

                    application = new Application(status: (ApplicationStatus)Enum.Parse(typeof(ApplicationStatus),
                                                  reader.GetByte(reader.GetOrdinal("status")).ToString()),
                                                  dateApplied: reader.GetDateTime(reader.GetOrdinal("dateApplied")));
                }
                await reader.CloseAsync();
                await _connection.CloseAsync();

                return application;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the application data from the database.", ex);
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

    public async Task UpdateStatusOfApplicationAsync(int applicationId, ApplicationStatus applicationStatus)
    {
        string query = "UPDATE [Application] SET status=@Status WHERE id=@Id";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@Status", applicationStatus);
                command.Parameters.AddWithValue("@Id", applicationId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while updating the application's status in the database.", ex);
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

    public async Task<Cv> GetCvByIdAsync(int cvId)
    {
        string query = "SELECT * FROM Cv WHERE id=@CvId";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@CvId", cvId);

                await _connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                Cv cv = null;

                if (reader.HasRows)
                {
                    await reader.ReadAsync();

                   cv = new Cv(id: reader.GetInt32(reader.GetOrdinal("id")),
                                   contentType: reader.GetString(reader.GetOrdinal("contentType")),
                                   name: reader.GetString(reader.GetOrdinal("Name")),
                                   data: reader.GetFieldValue<byte[]>(reader.GetOrdinal("data")));
                }
                await reader.CloseAsync();
                await _connection.CloseAsync();

                return cv;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the cv data from the database.", ex);
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
