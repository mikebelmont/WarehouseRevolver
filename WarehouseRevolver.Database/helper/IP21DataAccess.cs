namespace WarehouseRevolver.Database.helper;

public interface IP21DataAccess
{
    void ExecuteCommand<T>(string sql, T parameters);
    void ExecuteCommandAsync<T>(string sql, T parameters);
    List<T> Query<T, U>(string sql, U parameters);
    Task<List<T>> QueryAsync<T, U>(string sql, U parameters);
    T QuerySingle<T, U>(string sql, U parameters);
    Task<T> QuerySingleAsync<T, U>(string sql, U parameters);
}