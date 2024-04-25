using Clients.BL.IManager;
using Clients.BL.Manager;
using Clients.DAL.IRepository;
using Clients.DAL.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Clients.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IClientsUnitOfWork, ClientsUnitOfWork>();

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IPolygonTickerRepository, PolygonTickerRepository>();
            services.AddScoped<IPolygonRequestRepository, PolygonRequestRepository>();
            services.AddScoped<IPreviousCloseResponseRepository, PreviousCloseResponseRepository>();

            services.AddScoped<IPolygonManager, PolygonManager>();
            services.AddScoped<IClientManager, ClientManager>();
            services.AddScoped<IClientsMailManager, ClientsMailManager>();
            
            return services;
        }
    }
}