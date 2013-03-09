
namespace MEIP_System
{
    public class RequestViewFamilyInfo
    {
        string _username;


        public RequestViewFamilyInfo()
        { }

        public RequestViewFamilyInfo(string username)
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
