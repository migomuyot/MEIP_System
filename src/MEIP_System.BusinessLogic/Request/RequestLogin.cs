
namespace MEIP_System
{
    public class RequestLogin
    {
        string _username;
        string _password;

        public RequestLogin()
        { }
        /// <summary>
        /// Overload for request login.
        /// </summary>
        /// <param name="username">Put username here</param>
        /// <param name="password">Put password here</param>
        public RequestLogin(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
