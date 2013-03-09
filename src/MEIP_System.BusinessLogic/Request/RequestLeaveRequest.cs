
namespace MEIP_System
{
    public class RequestLeaveRequest
    {
        string _username;
        string _requestType;
        string _dateApplied;
        string _startDate;
        string _endDate;
        string _leaveType;
        string _reason;

        public RequestLeaveRequest()
        { }

        public RequestLeaveRequest(string username, string requesttype, string dateapplied, string startdate, string enddate, string leavetype, string reason)
        {
            _username = username;
            _requestType = requesttype;
            _dateApplied = dateapplied;
            _startDate = startdate;
            _endDate = enddate;
            _leaveType = leavetype;
            _reason = reason;
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string RequestType
        {
            get { return _requestType; }
            set { _requestType = value; }
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
