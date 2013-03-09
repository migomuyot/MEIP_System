
namespace MEIP_System
{
    public class RequestGetUserID
    {
        string _username;

        public RequestGetUserID()
        { }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
    }
}
