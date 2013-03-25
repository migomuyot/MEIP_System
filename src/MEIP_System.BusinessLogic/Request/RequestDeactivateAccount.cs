
namespace MEIP_System
{
    public class RequestDeactivateAccount
    {
        int _userid;
        string _username;

        public RequestDeactivateAccount()
        { }

        public RequestDeactivateAccount(int userid, string username)
        {
            _userid = userid;
            _username = username;
        }

        public int UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }

        public string Username
        {
            get {return _username;}
            set {_username = value;}
        }
    }
}
