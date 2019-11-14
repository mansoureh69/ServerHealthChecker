using System;
using System.Collections.Generic;
using System.Text;

namespace ServerHealthCheckerDomain
{
     public class HealthCheckerService
    {
        public IHealthChecker HealthChecker { get; set; }

        public void Act(Server server)
        {
           var healthCheckResult= HealthChecker.ServerHealthCheck(server);

            if(!healthCheckResult)
                HealthChecker.NotifyToClient(server);

        }
    }
}
