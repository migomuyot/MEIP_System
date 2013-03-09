
namespace MEIP_System
{
    public class RequestUpdateEducationalInfo
    {
        string _username;
        string _graduateSchool;
        string _courseTaken;
        string _yearGraduated;

        public RequestUpdateEducationalInfo()
        { }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string GraduateSchool
        {
            get { return _graduateSchool; }
            set { _graduateSchool = value; }
        }

        public string CourseTaken
        {
            get { return _courseTaken; }
            set { _courseTaken = value; }
        }

        public string YearGraduated
        {
            get { return _yearGraduated; }
            set { _yearGraduated = value; }
        }
    }
}
