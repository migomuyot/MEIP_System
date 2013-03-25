
namespace MEIP_System
{
    public class RequestUpdateEducationalInfo
    {
        int _educInfoID;
        string _username;
        string _school;
        string _degree;
        string _course;
        int _yearGraduated;

        public RequestUpdateEducationalInfo()
        { }

        public RequestUpdateEducationalInfo(int educInfoID, string username, string school, string degree, string course, int yearGraduated)
        {
            _educInfoID = educInfoID;
            _username = username;
            _school = school;
            _degree = degree;
            _course = course;
            _yearGraduated = yearGraduated;
        }

        public int EducInfoID
        {
            get { return _educInfoID; }
            set { _educInfoID = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string School
        {
            get { return _school; }
            set { _school = value; }
        }

        public string Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }
        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public int YearGraduated
        {
            get { return _yearGraduated; }
            set { _yearGraduated = value; }
        }
    }
}
