using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEIP_System
{
    public class RequestUpdateSiblingInfo
    {
        string _username;
        int _siblingID;
        string _siblingFname;
        string _siblingLname;
        string _siblingContactnum;

        public RequestUpdateSiblingInfo()
        { }

        public RequestUpdateSiblingInfo(string username, int siblingID, string siblingFname, string siblingLname, string siblingContactnum)
        {
            _username = username;
            _siblingID = siblingID;
            _siblingFname = siblingFname;
            _siblingLname = siblingLname;
            _siblingContactnum = siblingContactnum;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public int SiblingID
        {
            get { return _siblingID; }
            set { _siblingID = value; }
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
