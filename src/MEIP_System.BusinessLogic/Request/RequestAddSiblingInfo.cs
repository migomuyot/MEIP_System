﻿
namespace MEIP_System
{
    public class RequestAddSiblingInfo
    {
        string _username;
        string _siblingFname;
        string _siblingLname;
        string _siblingContactnum;

        public RequestAddSiblingInfo()
        { }

        public RequestAddSiblingInfo(string username, string siblingFname, string siblingLname, string siblingContactnum)
        {
            _username = username;
            _siblingFname = siblingFname;
            _siblingLname = siblingLname;
            _siblingContactnum = siblingContactnum;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string SiblingFName
        {
            get { return _siblingFname; }
            set { _siblingFname = value; }
        }

        public string SiblingLName
        {
            get { return _siblingLname; }
            set { _siblingLname = value; }
        }

        public string SiblingContactNum
        {
            get { return _siblingContactnum; }
            set { _siblingContactnum = value; }
        }
    }
}
