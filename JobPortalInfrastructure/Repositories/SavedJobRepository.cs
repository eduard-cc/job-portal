using JobPortalDomain.Models;
using JobPortalInfrastructure.Helpers;
using JobPortalLogic.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalInfrastructure.Repositories;

public class SavedJobRepository : ISavedJobRepository
{
    private readonly string _connectionString;
    private readonly SqlConnection _connection;

    public SavedJobRepository()
    {
        _connectionString = ConnectionStringHelper.GetConnectionString();
        _connection = new SqlConnection(_connectionString);
    }

    public async Task<List<Job>> GetAllSavedJobsAsync(int jobseekerId)
    {
        string query = "SELECT j.*, u.location, u.companyName " +
                       "FROM SavedJob s INNER JOIN Job j ON s.jobId = j.id INNER JOIN [User] u ON j.userId = u.id " +
                       "WHERE s.userId = @UserId;";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", jobseekerId);

                await _connection.OpenAsync();
                using SqlDataReader reader = await command.ExecuteReaderAsync();

                List<Job> savedJobs = new List<Job>();

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
                        id: reader.GetInt32(reader.GetOrdinal("id")),
                        employer: employer,
                        title: reader.GetString(reader.GetOrdinal("title")),
                        salary: salary,
                        datePosted: reader.GetDateTime(reader.GetOrdinal("datePosted")),
                        contractType: (ContractType)Enum.Parse(typeof(ContractType),
                                      reader.GetByte(reader.GetOrdinal("contractType")).ToString()));
                    savedJobs.Add(job);
                }

                await reader.CloseAsync();
                await _connection.CloseAsync();

                return savedJobs;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving saved jobs from the database.", ex);
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

    public async Task SaveJobAsync(int jobseekerId, int jobId)
    {
        string query = "INSERT INTO SavedJob (UserId, JobId) VALUES (@UserId, @JobId);";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", jobseekerId);
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while saving the job in the database.", ex);
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

    public async Task UnsaveJobAsync(int jobseekerId, int jobId)
    {
        string query = "DELETE FROM SavedJob WHERE UserId = @UserId AND JobId = @JobId;";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", jobseekerId);
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while unsaving the job in the database.", ex);
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

    public async Task<bool> CheckIfJobSavedAsync(int jobseekerId, int jobId)
    {
        string query = "SELECT COUNT(*) FROM SavedJob WHERE UserId = @UserId AND JobId = @JobId;";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", jobseekerId);
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                int count = (int)await command.ExecuteScalarAsync();
                await _connection.CloseAsync();

                return count > 0;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while checking if the job is saved in the database.", ex);
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
}