using System;
using System.Collections.Generic;

namespace ServerHealthCheckerDomain
{
     public class DataBaseServer:Server
    {
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public string ConnectionString { get; set; }
        public string TestQuery { get; set; }


        public DataBaseServer(Dictionary<object, string> notifyClientInNormal, Dictionary<object, string> notifyClientInCritical, Dictionary<object, string> notifyClientInWarning) : base(notifyClientInNormal, notifyClientInCritical, notifyClientInWarning)
        {
        }
    }
}
