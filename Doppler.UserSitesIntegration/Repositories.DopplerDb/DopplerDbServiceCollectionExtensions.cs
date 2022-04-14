using Microsoft.Extensions.DependencyInjection;

namespace Doppler.UserSitesIntegration.Repositories.DopplerDb;

public static class DopplerDbServiceCollectionExtensions
{
    public static IServiceCollection AddDopplerDbRepositories(this IServiceCollection services)
        => services
            .AddScoped<IFooRepository, DapperFooRepository>();
}
