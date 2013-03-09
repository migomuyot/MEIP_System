
namespace MEIP_System
{
    public class RequestUpdatePassword
    {
        string userID;
        string password;

        public RequestUpdatePassword()
        { }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
