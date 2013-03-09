
namespace MEIP_System
{
    public class RequestViewGeneralInfo
    {
        string _username;
        string _fName;
        string _lName;
        string _mName;
        string _nickname;
        string _gender;
        string _dob;
        string _civilStatus;

        public RequestViewGeneralInfo()
        { }

        public RequestViewGeneralInfo(string username, string fName, string lName, string mName, string nickname, string gender, string dob, string civilStatus)
        {
            _username = username;
            _fName = fName;
            _lName = lName;
            _mName = mName;
            _nickname = nickname;
            _gender = gender;
            _dob = dob;
            _civilStatus = civilStatus;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public string MName
        {
            get { return _mName; }
            set { _mName = value; }
        }

        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string CivilStatus
        {
            get { return _civilStatus; }
            set { _civilStatus = value; }
        }
    }
}
