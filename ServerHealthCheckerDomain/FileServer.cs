using System.Collections.Generic;

namespace ServerHealthCheckerDomain
{
   public class FileServer:Server
    {
        public FileServer(Dictionary<object, string> notifyClientInNormal, Dictionary<object, string> notifyClientInCritical, Dictionary<object, string> notifyClientInWarning) : base(notifyClientInNormal, notifyClientInCritical, notifyClientInWarning)
        {
        }
    }
}
