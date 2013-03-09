
namespace MEIP_System
{
    public class RequestUpdateContactInfo
    {
        string _username;
        string _homeNum;
        string _homeAddress;
        string _cellphoneNum;
        string _email;

        public RequestUpdateContactInfo()
        { }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string HomeNum
        {
            get { return _homeNum; }
            set { _homeNum = value; }
        }

        public string HomeAddress
        {
            get { return _homeAddress; }
            set { _homeAddress = value; }
        }

        public string CellphoneNum
        {
            get { return _cellphoneNum; }
            set { _cellphoneNum = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
