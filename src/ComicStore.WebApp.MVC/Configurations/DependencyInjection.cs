using ComicStore.Catalog.Data;
using ComicStore.Sales.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ComicStore.WebApp.MVC.Configurations
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Contexts
            services.AddScoped<CatalogDbContext>();
            services.AddScoped<SalesDbContext>();
        }
    }
}