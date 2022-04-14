using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Doppler.UserSitesIntegration.DataAccess.DapperProvider;

public class DopplerDatabaseConnectionFactory : IDatabaseConnectionFactory
{
    private readonly string _connectionString;

    public DopplerDatabaseConnectionFactory(IOptions<DopplerDatabaseSettings> dopplerDatabaseSettings)
    {
        _connectionString = dopplerDatabaseSettings.Value.GetSqlConnectionString();
    }

    public IDbConnection GetConnection()
        => new SqlConnection(_connectionString);
}
