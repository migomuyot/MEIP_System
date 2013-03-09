
namespace MEIP_System
{
    public class RequestSearchEmployees
    {
        string _username;
        string _lName;

        public RequestSearchEmployees()
        { }

        public RequestSearchEmployees(string username, string lName)
        {
            _username = username;
            _lName = lName;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }

    }
}
