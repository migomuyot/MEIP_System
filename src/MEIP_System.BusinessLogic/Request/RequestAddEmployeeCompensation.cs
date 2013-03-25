
namespace MEIP_System
{
    public class RequestAddEmployeeCompensation
    {
        int _userID;
        double _basicPay;
        double _transport;
        double _meal;
        double _rice;
        double _laundry;

        public RequestAddEmployeeCompensation()
        { }

        public RequestAddEmployeeCompensation(int userID, double basicPay, double transport, double meal, double rice, double laundry)
        {
            _userID = userID;
            _basicPay = basicPay;
            _transport = transport;
            _meal = meal;
            _rice = rice;
            _laundry = laundry;
        }

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public double BasicPay
        {
            get { return _basicPay; }
            set { _basicPay = value; }
        }

        public double Transport
        {
            get { return _transport; }
            set { _transport = value; }
        }

        public double Meal
        {
            get { return _meal; }
            set { _meal = value; }
        }

        public double Rice
        {
            get { return _rice; }
            set { _rice = value; }
        }

        public double Laundry
        {
            get { return _laundry; }
            set { _laundry = value; }
        }
    }
}
