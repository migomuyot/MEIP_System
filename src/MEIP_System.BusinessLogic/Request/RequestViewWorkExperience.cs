
namespace MEIP_System
{
    public class RequestViewWorkExperience
    {
        string _username;

        public RequestViewWorkExperience()
        { }

        public RequestViewWorkExperience(string username)
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
