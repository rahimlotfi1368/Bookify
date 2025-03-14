using System.Data;
using Bookify.Application.Abstractions.Data;
using Npgsql;

namespace Bookify.Infrastructure.Data;

internal sealed class SqlConnectionFactory(string connectionString) : ISqlConnectionFactory
{
    #region Implementation of ISqlConnectionFactory

    private readonly string _connectionString = !string.IsNullOrEmpty(connectionString)
        ? connectionString
        : throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty.");

    public IDbConnection CreateConnection()
    {
        var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        return connection;
    }

    #endregion
}