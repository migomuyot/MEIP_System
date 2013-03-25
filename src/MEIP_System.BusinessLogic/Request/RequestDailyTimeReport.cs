
namespace MEIP_System
{
    public class RequestDailyTimeReport
    {
        string _username;

        public RequestDailyTimeReport()
        { }

        public RequestDailyTimeReport(string username)
        {
            _username = username;
        }

        public string Username
        {
            set { _username = value; }
            get { return _username; }
        }
    }
}
