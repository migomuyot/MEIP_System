
namespace MEIP_System
{
    public class RequestViewTask
    {
        public string _username;
        public string _notifid;
        public string _userid;

        public RequestViewTask()
        { }

        public RequestViewTask(string username)
        {
            _username = username;
        }
        public string Username
        {
            set { _username = value; }
            get { return _username; }
        }

        public string NotifID
        {
            set { _notifid = value; }
            get { return _notifid; }
        }

        public string UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }

    }
}
