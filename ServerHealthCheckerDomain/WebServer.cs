using System.Collections.Generic;

namespace ServerHealthCheckerDomain
{
    public class WebServer : Server
    {
        public WebServer(Dictionary<object, string> notifyClientInNormal, Dictionary<object, string> notifyClientInCritical, Dictionary<object, string> notifyClientInWarning) : base(notifyClientInNormal, notifyClientInCritical, notifyClientInWarning)
        {
        }
    }
}
