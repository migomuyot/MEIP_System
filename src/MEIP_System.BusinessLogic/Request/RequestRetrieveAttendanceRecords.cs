
namespace MEIP_System
{
    public class RequestRetrieveAttendanceRecords
    {
        string _username;

        public RequestRetrieveAttendanceRecords()
        { }

        public RequestRetrieveAttendanceRecords(string username)
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
