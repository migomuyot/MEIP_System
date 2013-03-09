
namespace MEIP_System
{
    public class RequestViewContactInfo
    {
        string _username;


        public RequestViewContactInfo()
        { }

        public RequestViewContactInfo(string username)
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
