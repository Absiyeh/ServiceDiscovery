using Consul;

namespace Sample1.ServiceDiscoveryConfig
{

    /// <summary>
    /// هر بار که پروژه راه اندازی میشه به سرویس دیسکاوری  اعلام میکنه که به جریان برگشته 
    /// </summary>
    public class HostedServiceDiscovery : IHostedService
    {
        private readonly IConsulClient _consulClient;
        public HostedServiceDiscovery(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {

            var agentservicecfg = new AgentServiceRegistration
            {
                Address = ServiceConfig.ServiceAddress.Host,
                ID = ServiceConfig.SericeId,
                Name = ServiceConfig.ServiceName,
                Port = ServiceConfig.ServiceAddress.Port,
                Check = new AgentCheckRegistration
                {
                    HTTP = ServiceConfig.HealthCheck.ToString(),
                    Notes = "Checks /health/status on localhost",
                    Timeout = TimeSpan.FromSeconds(3),
                    Interval = TimeSpan.FromSeconds(10),
                    DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(10)
                }

        };
            await _consulClient.Agent.ServiceDeregister(ServiceConfig.SericeId, cancellationToken);

          await  _consulClient.Agent.ServiceRegister( agentservicecfg, cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
           await _consulClient.Agent.ServiceDeregister(ServiceConfig.SericeId, cancellationToken);
        }
    }
}
