
namespace MEIP_System
{
    public class RequestUpdateFamilyInfo
    {
        string _username;
        int _familyInfoID;
        string _fatherLname;
        string _motherLname;
        string _fatherFname;
        string _motherFname;
        string _fatherContactnum;
        string _motherContactnum;


        public RequestUpdateFamilyInfo()
        { }

        public RequestUpdateFamilyInfo(string username, int familyInfoID, string fatherLname, string motherLname, string fatherFname, string motherFname, string fatherContactnum, string motherContactnum)
        {
            _username = username;
            _familyInfoID = familyInfoID;
            _fatherLname = fatherLname;
            _motherLname = motherLname;
            _fatherFname = fatherFname;
            _motherFname = motherFname;
            _fatherContactnum = fatherContactnum;
            _motherContactnum = motherContactnum;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public int FamilyInfoID
        {
            get { return _familyInfoID; }
            set { _familyInfoID = value; }
        }
        public string FatherLName
        {
            get { return _fatherLname; }
            set { _fatherLname = value; }
        }

        public string MotherLName
        {
            get { return _motherLname; }
            set { _motherLname = value; }
        }

        public string FatherFName
        {
            get { return _fatherFname; }
            set { _fatherFname = value; }
        }

        public string MotherFName
        {
            get { return _motherFname; }
            set { _motherFname = value; }
        }

        public string FatherContactNum
        {
            get { return _fatherContactnum; }
            set { _fatherContactnum = value; }
        }

        public string MotherContactNum
        {
            get { return _motherContactnum; }
            set { _motherContactnum = value; }
        }
    }
}
