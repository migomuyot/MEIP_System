using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEIP_System
{
    public class RequestAuditTrail
    {
        string _username;
        string _action;

        public RequestAuditTrail()
        { }

        public RequestAuditTrail(string username, string action)
        {
            _username = username;
            _action = action;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
    }
}
