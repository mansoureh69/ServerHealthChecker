using System;

namespace ServerHealthCheckerDomain
{
    class DataBaseServerHealthChecker:IHealthChecker
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
