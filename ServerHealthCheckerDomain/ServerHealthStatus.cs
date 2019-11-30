using System;
using System.Collections.Generic;
using System.Text;

namespace ServerHealthCheckerDomain
{
    public enum ServerHealthStatus
    {
        Normal=1,
        Critical=2,
        Warning=3
    }
    public enum NotifyType
    { 
        Call=1,
        EMail=2,
        Sms=3
    }
}
