using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Schmiedicke.At.Models;

namespace Schmiedicke.At.Repositories.EF.Cosmos;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEfCosmos(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ApplicationDbContext>(
            options =>
            {
                options.UseCosmos(config["CosmosDb:ConnectionString"].NotNull(),
                                  config["CosmosDb:DatabaseName"].NotNull());
            });

        return services;
    }
}