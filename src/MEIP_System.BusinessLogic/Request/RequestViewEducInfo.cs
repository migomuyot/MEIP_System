
namespace MEIP_System
{
    public class RequestViewEducInfo
    {
        string _username;


        public RequestViewEducInfo()
        { }

        public RequestViewEducInfo(string username)
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
