using System;
using System.Collections.Generic;
using System.Text;

namespace ServerHealthCheckerDomain
{
    public class WebServer :Server
    {
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
