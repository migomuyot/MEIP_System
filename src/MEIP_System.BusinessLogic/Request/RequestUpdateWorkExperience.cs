
namespace MEIP_System
{
    public class RequestUpdateWorkExperience
    {
        int _workExperienceID;
        string _username;
        int _yearStarted;
        int _yearEnded;
        string _company;
        string _expPosition;

        public RequestUpdateWorkExperience()
        { }

        public RequestUpdateWorkExperience(int workExperienceID, string username, int yearstarted, int yearended, string company, string expposition)
        {
            _workExperienceID = workExperienceID;
            _username = username;
            _yearStarted = yearstarted;
            _yearEnded = yearended;
            _company = company;
            _expPosition = expposition;
        }

        public int WorkExperienceID
        {
            get { return _workExperienceID; }
            set { _workExperienceID = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public int YearStarted
        {
            get { return _yearStarted; }
            set { _yearStarted = value; }
        }

        public int YearEnded
        {
            get { return _yearEnded; }
            set { _yearEnded = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public string ExpPosition
        {
            get { return _expPosition; }
            set { _expPosition = value; }
        }
    }
}
