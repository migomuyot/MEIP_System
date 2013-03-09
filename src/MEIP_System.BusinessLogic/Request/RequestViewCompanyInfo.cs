
namespace MEIP_System
{
    public class RequestViewCompanyInfo
    {
        string _username;

        public RequestViewCompanyInfo()
        { }

        public RequestViewCompanyInfo(string username)
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
