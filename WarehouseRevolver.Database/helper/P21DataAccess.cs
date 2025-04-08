using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WarehouseRevolver.Database.helper;


namespace WarehouseRevolver.Database.helper;

public class P21DataAccess : IP21DataAccess
{
    private readonly string connectionString = string.Empty;

    public P21DataAccess(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<T> Query<T, U>(string sql, U parameters)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            return conn.Query<T>(sql, parameters).ToList();
        }
    }
    public async Task<List<T>> QueryAsync<T, U>(string sql, U parameters)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            return (await conn.QueryAsync<T>(sql, parameters)).ToList();
        }
    }
    public T QuerySingle<T, U>(string sql, U parameters)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            return conn.QuerySingleOrDefault<T>(sql, parameters);
        }
    }
    public async Task<T> QuerySingleAsync<T, U>(string sql, U parameters)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            return await conn.QuerySingleAsync<T>(sql, parameters);
        }
    }
    public void ExecuteCommand<T>(string sql, T parameters)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            conn.Execute(sql, parameters);
        }
    }
    public async void ExecuteCommandAsync<T>(string sql, T parameters)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            await conn.ExecuteAsync(sql, parameters);
        }
    }
    public async Task<List<T>> ExecuteYourStoredProcedure<T, U>(string sql, U parameters)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            return (await conn.QueryAsync<T>(sql, parameters)).ToList();
        }
    }

    public async Task<List<T>> QueryAsync<T, U>(string sql, U parameters, CommandType commandType)
    {
        using (IDbConnection conn = new SqlConnection(connectionString))
        {
            commandType = CommandType.StoredProcedure;
            return (await conn.QueryAsync<T>(sql, parameters, null, null, commandType)).ToList();
        }
    }
}
