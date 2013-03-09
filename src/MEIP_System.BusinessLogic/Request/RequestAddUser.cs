
namespace MEIP_System
{
    public class RequestAddUser
    {
        int _usertypeid;
        string _lname;
        string _fname;
        string _mname;
        string _nickname;
        string _dob;
        string _civilstatus;
        string _gender;
        string _username;
        string _password;
        string _datetimeadded;
        string _accountstatus;
        string _userStatus;

        public RequestAddUser()
        { }

        public RequestAddUser(int usertypeid, string lName, string fName, 
            string mName, string nickname, string dob, string civilStatus,
            string gender, string username, string password, string datetimeadded,
            string accountstatus, string userStatus)
        {
            _usertypeid = usertypeid;
            _lname = lName;
            _fname = fName;
            _nickname = nickname;
            _dob = dob;
            _civilstatus = civilStatus;
            _gender = gender;
            _username = username;
            _password = password;
            _datetimeadded = datetimeadded;
            _accountstatus = accountstatus;
            _userStatus = userStatus;
        }

        public int UsertypeID
        {
            set { _usertypeid = value; }
            get { return _usertypeid; }
        }

        public string LName
        {
            set { _lname = value; }
            get { return _lname; }
        }

        public string FName
        {
            set { _fname = value; }
            get { return _fname; }
        }

        public string MName
        {
            set { _mname = value; }
            get { return _mname; }
        }

        public string Nickname
        {
            set { _nickname = value; }
            get { return _nickname; }
        }

        public string DOB
        {
            set { _dob = value; }
            get { return _dob; }
        }

        public string CivilStatus
        {
            set { _civilstatus = value; }
            get { return _civilstatus; }
        }

        public string Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }

        public string Username
        {
            set { _username = value; }
            get { return _username; }
        }

        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        public string DateTimeAdded
        {
            set { _datetimeadded = value; }
            get { return _datetimeadded; }
        }

        public string AccountStatus
        {
            set { _accountstatus = value; }
            get { return _accountstatus; }
        }

        public string UserStatus
        {
            set { _userStatus = value; }
            get { return _userStatus; }
        }
    }
}
