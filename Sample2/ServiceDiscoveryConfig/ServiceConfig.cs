 namespace Sample2.ServiceDiscoveryConfig
{
    public static class ServiceConfig
    {
        public static Uri ServiceDisCoveryAddress = new("http://localhost:8500");
        public static Uri ServiceAddress = new("http://localhost:5085");
        public static Uri HealthCheck = new("http://localhost:5085/hc");
        public static string ServiceName = "Sample2";
        public static string SericeId = $"{ServiceName}_{01}";


    }
}
