
namespace MEIP_System
{
    public class RequestAddTask
    {
        public RequestAddTask()
        { }

        public string _userid;
        public string _task;
        public string _taskdate;

        public string UserID
        {
            set { _userid = value; }
            get { return _userid; }
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
