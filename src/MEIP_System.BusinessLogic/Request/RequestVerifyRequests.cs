using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEIP_System
{
    public class RequestVerifyRequests
    {
        int _requestID;
        int _userID;
        string _status;
        string _remarks;
        string _username;

        public RequestVerifyRequests()
        { }

        public RequestVerifyRequests(int requestID, int UserID, string status, string remarks, string username)
        {
            _requestID = requestID;
            _userID = UserID;
            _status = status;
            _remarks = remarks;
            _username = username;
        }

        public int RequestID
        {
            get { return _requestID; }
            set { _requestID = value; }
        }

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
    }
}
