using System;

namespace ServerHealthCheckerDomain
{
   public class WebServerHeathChecker:IHealthChecker
    {
        public bool ServerHealthCheck(Server server)
        {
            throw new NotImplementedException();
        }

        public void NotifyToClient(Server server)
        {
            throw new NotImplementedException();
        }
    }
}
