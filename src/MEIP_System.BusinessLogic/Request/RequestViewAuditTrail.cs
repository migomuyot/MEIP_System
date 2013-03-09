using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEIP_System
{
    public class RequestViewAuditTrail
    {
        string _username;

        public RequestViewAuditTrail()
        { }

        public RequestViewAuditTrail(string username)
        {
            _username = username;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
    }
}
