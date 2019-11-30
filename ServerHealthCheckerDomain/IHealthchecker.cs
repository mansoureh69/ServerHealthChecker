

namespace ServerHealthCheckerDomain
{
     public  interface  IHealthChecker
     {
           ServerHealthStatus ServerHealthCheck(Server server);
     }
}
