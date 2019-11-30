using System;

namespace ServerHealthCheckerDomain
{
    public class HealthCheckerService
    {
        public IHealthChecker HealthChecker { get; set; }
        public INotifyToClient NotifyToClient { get; set; }

        public void Act(Server server)
        {
            if ( typeof(Server) == typeof(DataBaseServer))
            {
                var dbHealthChecker = HealthChecker as DataBaseServerHealthChecker;
               var dbHealthStatus= dbHealthChecker?.ServerHealthCheck(server);
                switch (dbHealthStatus)
                {
                    case ServerHealthStatus.Normal:

                        break;
                 case ServerHealthStatus.Critical:

                        break;
                    case ServerHealthStatus.Warning:

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else if ( typeof(Server) == typeof(WebServer))
            {
                var webServerHealthChecker = HealthChecker as WebServerHeathChecker;
               var webHealthStatus= webServerHealthChecker?.ServerHealthCheck(server);
                switch (webHealthStatus)
                {
                    case ServerHealthStatus.Normal:

                        break;
                 case ServerHealthStatus.Critical:

                        break;
                    case ServerHealthStatus.Warning:

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else if  ( typeof(Server) == typeof(FileServer))
            {
                var fileServerHealthChecker = HealthChecker as FileServerHealthChecker;
               var fileServerHealthStatus= fileServerHealthChecker?.ServerHealthCheck(server);
                switch (fileServerHealthStatus)
                {
                    case ServerHealthStatus.Normal:

                        break;
                 case ServerHealthStatus.Critical:

                        break;
                    case ServerHealthStatus.Warning:

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }





        }
    }
}
