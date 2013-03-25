
namespace MEIP_System
{
    public class RequestTimeChangeRequest
    {
        string _username;
        string _requestType;
        string _dateApplied;
        string _attendanceDateChange;
        string _timeInChange;
        string _timeOutChange;
        string _reason;

        public RequestTimeChangeRequest()
        { }

        public RequestTimeChangeRequest(string username, string requestType, string dateApplied, string attendanceDateChange, string timeInChange, string timeOutChange, string reason)
        {
            _username = username;
            _requestType = requestType;
            _dateApplied = dateApplied;
            _attendanceDateChange = attendanceDateChange;
            _timeInChange = timeInChange;
            _timeOutChange = timeOutChange;
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

        public string AttendanceDateChange
        {
            get { return _attendanceDateChange; }
            set { _attendanceDateChange = value; }
        }

        public string TimeInChange
        {
            get { return _timeInChange; }
            set { _timeInChange = value; }
        }

        public string TimeOutChange
        {
            get { return _timeOutChange; }
            set { _timeOutChange = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }
    }
}
