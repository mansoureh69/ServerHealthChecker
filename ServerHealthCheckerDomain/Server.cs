using System;
using System.Collections.Generic;

namespace ServerHealthCheckerDomain
{
     public abstract class Server
    {
        protected  List<int> NotifyTypes { get; set; }
        protected  List<Client> ContactsCLients { get; set; }
        protected abstract void ServerHealthCheck();
        protected abstract void Notify();

    }
}
