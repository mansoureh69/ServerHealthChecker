
using System.Collections.Generic;

namespace ServerHealthCheckerDomain
{
     public abstract class Server
    {
        protected Server(Dictionary<object, string>  notifyClientInNormal, Dictionary<object, string> notifyClientInCritical, Dictionary<object, string> notifyClientInWarning)
        {

        }
      
        public Dictionary<object, List<NotifyType>>[] NotifyClient = new Dictionary<object, List<NotifyType>>[3];
        public ServerHealthStatus ServerHealthStatus { get;  set; }

    }
}
