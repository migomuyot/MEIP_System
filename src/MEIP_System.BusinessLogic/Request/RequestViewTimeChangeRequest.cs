
namespace MEIP_System
{
    public class RequestViewTimeChangeRequest
    {
        string _username;

        public RequestViewTimeChangeRequest()
        { }

        public RequestViewTimeChangeRequest(string username)
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
