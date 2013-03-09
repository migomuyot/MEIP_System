
namespace MEIP_System
{
    public class RequestViewLeaveRequest
    {
        string _username;

        public RequestViewLeaveRequest()
        { }

        public RequestViewLeaveRequest(string username)
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
