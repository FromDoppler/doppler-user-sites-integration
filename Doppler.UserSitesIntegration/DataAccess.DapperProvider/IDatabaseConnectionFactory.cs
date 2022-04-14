using System.Data;

namespace Doppler.UserSitesIntegration.DataAccess.DapperProvider;

public interface IDatabaseConnectionFactory
{
    IDbConnection GetConnection();
}
