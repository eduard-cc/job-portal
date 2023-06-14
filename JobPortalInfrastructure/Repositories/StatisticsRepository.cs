using JobPortalDomain.Models;
using JobPortalInfrastructure.Helpers;
using JobPortalLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalInfrastructure.Repositories;

public class StatisticsRepository : IStatisticsRepository
{
    private readonly string _connectionString;
    private readonly SqlConnection _connection;

    public StatisticsRepository()
    {
        _connectionString = ConnectionStringHelper.GetConnectionString();
        _connection = new SqlConnection(_connectionString);
    }

    public async Task<int> GetClickCountByJobIdAsync(int jobId)
    {
        string query = @"SELECT clicks 
                         FROM Job 
                         WHERE id = @JobId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                int clicksCount = (int)await command.ExecuteScalarAsync();
                await _connection.CloseAsync();

                return clicksCount;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the job's click count data from the database.", ex);
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

    public async Task<int> GetSavedCountByJobIdAsync(int jobId)
    {
        string query = @"SELECT COUNT(*) 
                         FROM SavedJob 
                         WHERE jobId = @JobId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                int savedCount = (int)await command.ExecuteScalarAsync();
                await _connection.CloseAsync();

                return savedCount;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the saved job count from the database.", ex);
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

    public async Task<(int applicationsWithoutCv, int applicationsWithCv)> GetApplicationCountByJobIdAsync(int jobId)
    {
        string query = @"SELECT COUNT(CASE WHEN cvId IS NULL THEN 1 END) AS ApplicationsWithoutCv,
                         COUNT(CASE WHEN cvId IS NOT NULL THEN 1 END) AS ApplicationsWithCv
                         FROM Application
                         WHERE jobId = @JobId";
        try
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        int applicationsWithoutCv = reader.GetInt32(reader.GetOrdinal("ApplicationsWithoutCv"));
                        int applicationsWithCv = reader.GetInt32(reader.GetOrdinal("ApplicationsWithCv"));

                        await _connection.CloseAsync();

                        return (applicationsWithoutCv, applicationsWithCv);
                    }
                }
                await _connection.CloseAsync();

                return (0, 0);
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while retrieving the application count from the database.", ex);
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

    public async Task IncrementClicksByJobIdAsync(int jobId)
    {
        string updateQuery = @"UPDATE Job 
                               SET clicks = clicks + 1 
                               WHERE id = @JobId";
        try
        {
            using (SqlCommand command = new SqlCommand(updateQuery, _connection))
            {
                command.Parameters.AddWithValue("@JobId", jobId);

                await _connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("An error occurred while updating the job's click count in the database.", ex);
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