using Consul;

namespace Sample1.ServiceDiscoveryConfig
{
    public static class ConsuleIOCRegister
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddSingleton<IConsulClient>(consul => new ConsulClient(consulConfig =>
            {
                consulConfig.Address = ServiceConfig.ServiceDisCoveryAddress;
            }));
            services.AddHostedService<HostedServiceDiscovery>();


            return services;
        }
    }
}
