 namespace Sample1.ServiceDiscoveryConfig
{
    public static class ServiceConfig
    {
        public static Uri ServiceDisCoveryAddress = new("http://localhost:8500");
        public static Uri ServiceAddress = new("http://localhost:5141");
        public static Uri HealthCheck = new("http://localhost:5141/hc");
        public static string ServiceName = "Sample1";
        public static string SericeId = $"{ServiceName}_{01}";


    }
}
