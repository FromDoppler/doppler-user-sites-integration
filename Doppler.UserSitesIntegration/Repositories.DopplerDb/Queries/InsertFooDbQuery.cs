using Doppler.UserSitesIntegration.DataAccess;

namespace Doppler.UserSitesIntegration.Repositories.DopplerDb.Queries;

public record InsertFooDbQuery(
    int IdFoo
) : IExecutableDbQuery
{
    public string GenerateSqlQuery() => @"
INSERT INTO Foo (
    IdFoo
) VALUES (
    @IdFoo
)";
}
