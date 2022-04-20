using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Doppler.UserSitesIntegration.DataAccess.DapperProvider;

public static class DapperProviderServiceCollectionExtensions
{
    public static IServiceCollection AddDapperDataAccessProvider(this IServiceCollection services, IConfiguration configuration)
        => services
            .AddSingleton<IDatabaseConnectionFactory, DopplerDatabaseConnectionFactory>()
            .AddScoped<IDbContext, DapperWrapperDbContext>()
            .Configure<DopplerDatabaseSettings>(configuration.GetSection(nameof(DopplerDatabaseSettings)));
}
