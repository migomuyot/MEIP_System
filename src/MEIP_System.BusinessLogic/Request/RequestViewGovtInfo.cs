
namespace MEIP_System
{
    public class RequestViewGovtInfo
    {
        string _username;
        string _tin;
        string _sss;
        string _philHealth;
        string _hdmf;
        string _pagibig;

        public RequestViewGovtInfo()
        { }

        public RequestViewGovtInfo(string username)
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
