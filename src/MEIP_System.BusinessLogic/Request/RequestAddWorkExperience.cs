using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEIP_System
{
    public class RequestAddWorkExperience
    {
        string _username;
        int _yearStarted;
        int _yearEnded;
        string _company;
        string _expPosition;

        public RequestAddWorkExperience()
        { }

        public RequestAddWorkExperience(string username, int yearstarted, int yearended, string company, string expposition)
        {
            _username = username;
            _yearStarted = yearstarted;
            _yearEnded = yearended;
            _company = company;
            _expPosition = expposition;
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
