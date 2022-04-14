using System.Threading.Tasks;
using Doppler.UserSitesIntegration.DataAccess;
using Doppler.UserSitesIntegration.Repositories.DopplerDb.Queries;

namespace Doppler.UserSitesIntegration.Repositories.DopplerDb;

public class DapperFooRepository : IFooRepository
{
    private readonly IDbContext _dbContext;

    public DapperFooRepository(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateFooAsync()
    {
        var insertFooDbQuery = new InsertFooDbQuery(
                IdFoo: 1
            );

        await _dbContext.ExecuteAsync(insertFooDbQuery);
    }
}
