using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEIP_System
{
    public class RequestViewSiblingInfo
    {
        string _username;


        public RequestViewSiblingInfo()
        { }

        public RequestViewSiblingInfo(string username)
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
