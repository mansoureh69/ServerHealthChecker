

namespace ServerHealthCheckerDomain
{
     public  interface  IHealthChecker
     {
           bool ServerHealthCheck(Server server);
           void NotifyToClient(Server server);
     }
}
