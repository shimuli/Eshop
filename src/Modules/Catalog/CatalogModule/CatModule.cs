using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CatalogModule;

public static class CatModule
{
    public static IServiceCollection AddCatelogModule(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }

    public static IApplicationBuilder UseCatelogModule(this IApplicationBuilder app)
    {
        // Configure the application pipeline for the Catalog module if needed
        return app;
    }
}