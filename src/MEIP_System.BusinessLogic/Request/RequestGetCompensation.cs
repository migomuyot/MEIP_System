
namespace MEIP_System
{
    public class RequestGetCompensation
    {
        int _userID;

        public RequestGetCompensation()
        { }

        public RequestGetCompensation(int userID)
        {
            _userID = userID;
        }

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
    }
}
