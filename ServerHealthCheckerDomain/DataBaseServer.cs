using System;

namespace ServerHealthCheckerDomain
{
     public class DataBaseServer:Server
    {
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public string ConnectionString { get; set; }
        public string TestQuery { get; set; }
        
        protected override void ServerHealthCheck()
        {
            throw new NotImplementedException();
        }

        protected override void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
