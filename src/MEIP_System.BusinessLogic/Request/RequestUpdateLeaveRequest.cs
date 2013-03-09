using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEIP_System
{
    public class RequestUpdateLeaveRequest
    {
        int _requestID;
        string _username;
        string _dateApplied;
        string _startDate;
        string _endDate;
        string _leaveType;
        string _reason;

        public RequestUpdateLeaveRequest()
        { }

        public RequestUpdateLeaveRequest(int requestid, string username, string dateapplied, string startdate, string enddate, string leavetype, string reason)
        {
            _requestID = requestid;
            _username = username;
            _dateApplied = dateapplied;
            _startDate = startdate;
            _endDate = enddate;
            _leaveType = leavetype;
            _reason = reason;
        }

        public int RequestID
        {
            get { return _requestID; }
            set { _requestID = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; }
        }

        public string StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string LeaveType
        {
            get { return _leaveType; }
            set { _leaveType = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }
    }
}
