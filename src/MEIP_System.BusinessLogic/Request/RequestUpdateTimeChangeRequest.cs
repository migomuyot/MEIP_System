
namespace MEIP_System
{
    public class RequestUpdateTimeChangeRequest
    {
        int _requestID;
        string _username;
        string _dateApplied;
        string _attendanceDateChange;
        string _timeChangeIn;
        string _timeChangeOut;
        string _reason;

        public RequestUpdateTimeChangeRequest()
        { }

        public RequestUpdateTimeChangeRequest(int requestID, string username, string dateApplied, string attedanceDateChange, string timeChangeIn, string timeChangeOut, string reason)
        {
            _requestID = requestID;
            _username = username;
            _dateApplied = dateApplied;
            _attendanceDateChange = attedanceDateChange;
            _timeChangeIn = timeChangeIn;
            _timeChangeOut = timeChangeOut;
            _reason = reason;
        }

        public int RequestID
        {
            get { return _requestID; }
            set { _requestID = value; }
        }

        public string Username
        {
            get { return _username;}
            set { _username = value; }
        }

        public string DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; }
        }

        public string AttendanceDateChange
        {
            get { return _attendanceDateChange; }
            set { _attendanceDateChange = value; }
        }

        public string TimeChangeIn
        {
            get { return _timeChangeIn; }
            set { _timeChangeIn = value; }
        }

        public string TimeChangeOut
        {
            get { return _timeChangeOut; }
            set { _timeChangeOut = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }
    }
}
