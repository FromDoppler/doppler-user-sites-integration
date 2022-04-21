using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Doppler.UserSitesIntegration.Storage
{
    public static class StorageExtensions
    {
        public static void AddStorage(this IServiceCollection services, IConfiguration configuration)
        {
            var storageSettingsSection = configuration.GetSection(nameof(StorageSettings));

            services.Configure<StorageSettings>(storageSettingsSection);

            var storageSettings = new StorageSettings();
            storageSettingsSection.Bind(storageSettings);

            var mongoClientSettings = MongoClientSettings.FromConnectionString(
                $"mongodb+srv://{storageSettings.Username}:{storageSettings.Password}@{storageSettings.Host}");

            services.AddSingleton<IMongoClient>(x =>
            {
                var mongoClient = new MongoClient(mongoClientSettings);

                var database = mongoClient.GetDatabase(storageSettings.DatabaseName);

                return mongoClient;
            });
        }
    }
}
