using System;
using System.Collections.Generic;
using System.Text;

namespace ServerHealthCheckerDomain
{
   public interface INotifyToClient
    {
        void NotifyToClient(Server server);
    }
}
