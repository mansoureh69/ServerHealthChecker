using System;

namespace ServerHealthCheckerDomain
{
    public class FileServerHealthChecker : IHealthChecker
    {
        public void NotifyToClient(Server server)
        {
            throw new NotImplementedException();
        }

        public bool ServerHealthCheck(Server server)
        {
            throw new NotImplementedException();
        }
    }
}
