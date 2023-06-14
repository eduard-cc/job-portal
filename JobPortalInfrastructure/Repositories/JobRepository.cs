using JobPortalDomain.Enums;
using JobPortalDomain.Models;
using JobPortalInfrastructure.Helpers;
using JobPortalLogic.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace JobPortalInfrastructure.Repositories;

public class JobRepository : IJobRepository
{
    private readonly string _connectionString;
    private readonly SqlConnection _connection;

    public JobRepository()
    {
        _connectionString = ConnectionStringHelper.GetConnectionString();
        _connection = new SqlConnection(_connectionString);
    }

    public async Task<List<Job>> SearchJobsAsync(string jobTitleOrCompany, string location, int startIndex, int count)
    {
        string query = "SELECT j.*, u.location, u.companyName, u.companySize " +
                       "FROM Job j " +
                       "INNER JOIN [User] u ON j.userId = u.id";

        List<SqlParameter> parameters = new List<SqlParameter>();

        if (!String.IsNullOrWhiteSpace(jobTitleOrCompany) || !String.IsNullOrWhiteSpace(location))
        {
            query += " WHERE ";
        }

        if (!String.IsNullOrWhiteSpace(jobTitleOrCompany))
        {
            query += "(j.title LIKE '%' + @JobTitleOrCompany + '%' OR u.companyName LIKE '%' + @JobTitleOrCompany + '%')";
            parameters.Add(new SqlParameter("@JobTitleOrCompany", jobTitleOrCompany));
        }

        if (!String.IsNullOrWhiteSpace(jobTitleOrCompany) && !String.IsNullOrWhiteSpace(location))
        {
            query += " AND ";
        }

        if (!String.IsNullOrWhiteSpace(location))
        {
            query += "u.location LIKE '%' + @Location + '%'";
            parameters.Add(new SqlParameter("@Location", location));
        }

        // Add the OFFSET and FETCH clauses for pagination
        query += " ORDER BY j.id OFFSET @StartIndex ROWS FETCH NEXT @Count ROWS ONLY";
        parameters.Add(new SqlParameter("@StartIndex", startIndex));
        parameters.Add(new SqlParameter("@Count", count));

        try
        {
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddRange(parameters.ToArray());

            await _connection.OpenAsync();
            using SqlDataReader reader = await command.ExecuteReaderAsync();

            List<Job> jobs = new List<Job>();

            while (await reader.ReadAsync())
            {
                Employer employer = new Employer(
                         location: reader.GetString(reader.GetOrdinal("location")),
                         companyName: reader.GetString(reader.GetOrdinal("companyName")),
                         companySize: (CompanySize)Enum.Parse(typeof(CompanySize),
                                      reader.GetByte(reader.GetOrdinal("companySize")).ToString()));

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
                    description: reader.GetString(reader.GetOrdinal("description")),
                    salary: salary,
                    datePosted: reader.GetDateTime(reader.GetOrdinal("datePosted")),
                    contractType: (ContractType)Enum.Parse(typeof(ContractType),
                                  reader.GetByte(reader.GetOrdinal("contractType")).ToString()),
                    workArrangement: (WorkArrangement)Enum.Parse(typeof(WorkArrangement),
                                     reader.GetByte(reader.GetOrdinal("workArrangement")).ToString())
                    );

                jobs.Add(job);
            }
            reader.Close();
            await _connection.CloseAsync();

            return jobs;
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the job data from the database.", ex);
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

    public async Task<int> CountJobsAsync(string jobTitleOrCompany, string location)
    {
        string query = "SELECT COUNT(*) " +
                       "FROM Job j " +
                       "INNER JOIN [User] u ON j.userId = u.id";

        List<SqlParameter> parameters = new List<SqlParameter>();

        if (!String.IsNullOrWhiteSpace(jobTitleOrCompany) || !String.IsNullOrWhiteSpace(location))
        {
            query += " WHERE ";
        }

        if (!String.IsNullOrWhiteSpace(jobTitleOrCompany))
        {
            query += "(j.title LIKE '%' + @JobTitleOrCompany + '%' OR u.companyName LIKE '%' + @JobTitleOrCompany + '%')";
            parameters.Add(new SqlParameter("@JobTitleOrCompany", jobTitleOrCompany));
        }

        if (!String.IsNullOrWhiteSpace(jobTitleOrCompany) && !String.IsNullOrWhiteSpace(location))
        {
            query += " AND ";
        }

        if (!String.IsNullOrWhiteSpace(location))
        {
            query += "u.location LIKE '%' + @Location + '%'";
            parameters.Add(new SqlParameter("@Location", location));
        }

        try
        {
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddRange(parameters.ToArray());

            await _connection.OpenAsync();
            int totalCount = (int)await command.ExecuteScalarAsync();
            await _connection.CloseAsync();

            return totalCount;
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while counting the job data in the database.", ex);
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

    public async Task<List<Job>> GetAllJobsAsync()
    {
        string query = "SELECT j.*, u.location, u.companyName, u.companySize " +
                       "FROM Job j " +
                       "INNER JOIN [User] u ON j.userId = u.id ";
        try
        {
            using SqlCommand command = new SqlCommand(query, _connection);
            await _connection.OpenAsync();

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            List<Job> jobs = new List<Job>();

            while (await reader.ReadAsync())
            {
                Employer employer = new Employer(
                         location: reader.GetString(reader.GetOrdinal("location")),
                         companyName: reader.GetString(reader.GetOrdinal("companyName")),
                         companySize: (CompanySize)Enum.Parse(typeof(CompanySize),
                                      reader.GetByte(reader.GetOrdinal("companySize")).ToString()));

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
                    description: reader.GetString(reader.GetOrdinal("description")),
                    salary: salary,
                    datePosted: reader.GetDateTime(reader.GetOrdinal("datePosted")),
                    contractType: (ContractType)Enum.Parse(typeof(ContractType),
                                  reader.GetByte(reader.GetOrdinal("contractType")).ToString()),
                    workArrangement: (WorkArrangement)Enum.Parse(typeof(WorkArrangement),
                                     reader.GetByte(reader.GetOrdinal("workArrangement")).ToString())
                    );

                jobs.Add(job);
            }
            reader.Close();
            await _connection.CloseAsync();

            return jobs;
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the job data from the database.", ex);
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

    public async Task<Job> GetJobByIdAsync(int jobId)
    {
        string query = "SELECT j.*, u.location, u.companyName, u.companySize " +
                       "FROM Job j " +
                       "INNER JOIN [User] u ON j.userId = u.id " +
                       "WHERE j.id = @jobId";
        try
        {
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@jobId", jobId);

            await _connection.OpenAsync();
            using SqlDataReader reader = await command.ExecuteReaderAsync();

            if (!reader.HasRows)
            {
                return null;
            }
            await reader.ReadAsync();

            Employer employer = new Employer(
                     location: reader.GetString(reader.GetOrdinal("location")),
                     companyName: reader.GetString(reader.GetOrdinal("companyName")),
                     companySize: (CompanySize)Enum.Parse(typeof(CompanySize),
                                  reader.GetByte(reader.GetOrdinal("companySize")).ToString()));
            
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
                description: reader.GetString(reader.GetOrdinal("description")),
                salary: salary,
                datePosted: reader.GetDateTime(reader.GetOrdinal("datePosted")),
                contractType: (ContractType)Enum.Parse(typeof(ContractType),
                              reader.GetByte(reader.GetOrdinal("contractType")).ToString()),
                workArrangement: (WorkArrangement)Enum.Parse(typeof(WorkArrangement),
                                 reader.GetByte(reader.GetOrdinal("workArrangement")).ToString())
                );
            reader.Close();
            await _connection.CloseAsync();

            return job;
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the job data from the database.", ex);
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

    public async Task<bool> CheckIfJobPostedByEmployerAsync(int employerId, int jobId)
    {
        string query = "SELECT COUNT(*) FROM Job WHERE UserId = @UserId AND id = @JobId;";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", employerId);
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                int count = (int)await command.ExecuteScalarAsync();
                await _connection.CloseAsync();

                return count > 0;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while checking if the job was posted by employer id.", ex);
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

    public async Task<List<Job>> GetJobsByEmployerIdAsync(int employerId)
    {
        string query = "SELECT j.*, u.location, u.companyName, u.companySize " +
                       "FROM Job j " +
                       "INNER JOIN [User] u ON j.userId = u.id " +
                       "WHERE j.userId = @employerId";
        try
        {
            using SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@employerId", employerId);

            await _connection.OpenAsync();

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            List<Job> jobs = new List<Job>();

            while (await reader.ReadAsync())
            {
                Employer employer = new Employer(
                         location: reader.GetString(reader.GetOrdinal("location")),
                         companyName: reader.GetString(reader.GetOrdinal("companyName")),
                         companySize: (CompanySize)Enum.Parse(typeof(CompanySize),
                                      reader.GetByte(reader.GetOrdinal("companySize")).ToString()));

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
                    description: reader.GetString(reader.GetOrdinal("description")),
                    salary: salary,
                    datePosted: reader.GetDateTime(reader.GetOrdinal("datePosted")),
                    contractType: (ContractType)Enum.Parse(typeof(ContractType),
                                  reader.GetByte(reader.GetOrdinal("contractType")).ToString()),
                    workArrangement: (WorkArrangement)Enum.Parse(typeof(WorkArrangement),
                                     reader.GetByte(reader.GetOrdinal("workArrangement")).ToString())
                    );

                jobs.Add(job);
            }
            reader.Close();
            await _connection.CloseAsync();

            return jobs;
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the job data from the database.", ex);
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

    public async Task AddJobAsync(Job job, int employerId)
    {
        string query = "INSERT INTO Job (userId, title, description, salaryAmount, salaryMinAmount, salaryMaxAmount, " +
                                        "salaryRate, salaryType, datePosted, contractType, workArrangement, clicks) " +
                       "VALUES (@UserId, @Title, @Description, @SalaryAmount, @SalaryMinAmount, @SalaryMaxAmount, " +
                               "@SalaryRate, @SalaryType, @DatePosted, @ContractType, @WorkArrangement, @Clicks); " +
                       "SELECT CAST(SCOPE_IDENTITY() AS INT)";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", employerId);
                command.Parameters.AddWithValue("@Title", job.Title);
                command.Parameters.AddWithValue("@Description", job.Description);
                command.Parameters.AddWithValue("@SalaryAmount", job.Salary.Amount ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SalaryMinAmount", job.Salary.MinAmount ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SalaryMaxAmount", job.Salary.MaxAmount ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SalaryRate", (int)job.Salary.Rate);
                command.Parameters.AddWithValue("@SalaryType", (int)job.Salary.Type);
                command.Parameters.AddWithValue("@DatePosted", job.DatePosted.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@ContractType", (int)job.ContractType);
                command.Parameters.AddWithValue("@WorkArrangement", (int)job.WorkArrangement);
                command.Parameters.AddWithValue("@Clicks", job.Clicks);

                await _connection.OpenAsync();
                await command.ExecuteScalarAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while adding the job to the database.", ex);
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

    // Also deletes any saved jobs and applications associated with each job deleted
    public async Task DeleteJobsByEmployerIdAsync(int employerId)
    {
        string query = "DELETE FROM SavedJob " +
                       "WHERE jobId IN (SELECT j.id FROM Job j WHERE j.userId = @UserId);" +
                       "DELETE FROM Application " +
                       "WHERE jobId IN (SELECT j.id FROM Job j WHERE j.userId = @UserId);" +
                       "DELETE FROM Job WHERE userId = @UserId;";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", employerId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while deleting the jobs from the database.", ex);
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

    public async Task DeleteApplicationsAndSavedJobsByJobseekerIdAsync(int jobseekerId)
    {
        string query = "DELETE FROM SavedJob " +
                       "WHERE userId = @UserId;" +
                       "DELETE FROM Application " +
                       "WHERE userId = @UserId;";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@UserId", jobseekerId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while deleting the applications and saved jobs from the database.", ex);
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

    public async Task UpdateJobDetailsAsync(Job job)
    {
        string query = "UPDATE Job SET title=@Title, description=@Description, salaryAmount=@SalaryAmount, " +
                              "salaryMinAmount=@SalaryMinAmount, salaryMaxAmount=@SalaryMaxAmount, salaryRate=@SalaryRate, " +
                              "salaryType=@SalaryType, contractType=@ContractType, workArrangement=@WorkArrangement " +
                       "WHERE id=@JobId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@JobId", job.Id);
                command.Parameters.AddWithValue("@Title", job.Title);
                command.Parameters.AddWithValue("@Description", job.Description);
                command.Parameters.AddWithValue("@SalaryAmount", job.Salary.Amount ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SalaryMinAmount", job.Salary.MinAmount ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SalaryMaxAmount", job.Salary.MaxAmount ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@SalaryRate", (int)job.Salary.Rate);
                command.Parameters.AddWithValue("@SalaryType", (int)job.Salary.Type);
                command.Parameters.AddWithValue("@ContractType", (int)job.ContractType);
                command.Parameters.AddWithValue("@WorkArrangement", (int)job.WorkArrangement);

                await _connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while updating the job in the database.", ex);
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
    public async Task<int> GetTotalJobCountAsync()
    {
        string query = "SELECT COUNT(*) FROM Job";

        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                await _connection.OpenAsync();
                int totalCount = (int)await command.ExecuteScalarAsync();
                await _connection.CloseAsync();

                return totalCount;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the job data from the database.", ex);
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

    public async Task DeleteJobByIdAsync(int jobId)
    {
        string query = @" DELETE FROM Application
                          WHERE jobId = @jobId;

                          DELETE FROM SavedJob
                          WHERE jobId = @jobId;

                          DELETE FROM Job
                          WHERE id = @jobId;";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@jobId", jobId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
                await _connection.CloseAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while deleting the job from the database.", ex);
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