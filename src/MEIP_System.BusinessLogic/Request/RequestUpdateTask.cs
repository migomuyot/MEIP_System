
namespace MEIP_System
{
    public class RequestUpdateTask
    {
        public int _userid;
        public string _notifid;
        public string _task;
        public string _taskdate;

        public RequestUpdateTask()
        { }

        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }

        public string NotifID
        {
            set { _notifid = value; }
            get { return _notifid; }
        }
        public string Task
        {
            set { _task = value; }
            get { return _task; }
        }

        public string TaskDate
        {
            set { _taskdate = value; }
            get { return _taskdate; }
        }

    }
}
