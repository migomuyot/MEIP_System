
namespace MEIP_System
{
    public class RequestComputePayroll
    {
        public int _payrollid;
        public int _userid;
        public double _basicpay;
        public double _dailyrate;
        public int _workinghrs;
        public double _perhrrate;
        public int _nominutelate;
        public double _latedeductions;
        public int _noofdaysabsent;
        public double _absentdeductions;
        public int _nominuteundertime;
        public double _undertimedeductions;
        public double _holidaypay;
        public int _nightdifferentialhrs;
        public double _totalnightdifferential;
        public double _nightdifferential;
        public double _transportallowance;
        public double _mealallowance;
        public double _ricesubsidy;
        public double _laundry;
        public double _bonus;
        public double _monthlyincentive;
        public double _grosspay;
        public double _taxsss;
        public double _taxphilhealth;
        public double _taxsssloan;
        public double _hdmf;
        public double _pagibigloan;
        public double _withholdtax;
        public string _payrolldate;
        public double _netpay;
        public double _SSSContribution;
        public double _HDMFContribution;
        public double _PhilHealthContribution;
        public double _SSSTotalContribution;
        public double _HDMFTotalContribution;
        public double _PhilHealthTotalContribution;

        public RequestComputePayroll()
        { }

        public int PayrollID
        {
            set { _payrollid = value; }
            get { return _payrollid; }
        }

        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }



        public double BasicPay
        {
            set { _basicpay = value; }
            get { return _basicpay; }
        }

        public double DailyRate
        {
            set { _dailyrate = value; }
            get { return _dailyrate; }
        }


        public int WorkingHrs
        {
            set { _workinghrs = value; }
            get { return _workinghrs; }
        }

        public double PerHrRate
        {
            set { _perhrrate = value; }
            get { return _perhrrate; }
        }


        public int NoofMinuteLate
        {
            set { _nominutelate = value; }
            get { return _nominutelate; }
        }

        public double LateDeductions
        {
            set { _latedeductions = value; }
            get { return _latedeductions; }
        }

        public int NoofMinuteUndertime
        {
            set { _nominuteundertime = value; }
            get { return _nominuteundertime; }
        }

        public double UndertimeDeductions
        {
            set { _undertimedeductions = value; }
            get { return _undertimedeductions; }
        }

        public int NoDaysAbsent
        {
            set { _noofdaysabsent = value; }
            get { return _noofdaysabsent; }
        }

        public double AbsentDeductions
        {
            set { _absentdeductions = value; }
            get { return _absentdeductions; }
        }

        public double HolidayPay
        {
            set { _holidaypay = value; }
            get { return _holidaypay; }
        }

        public int NightDifferentialHrs
        {
            set { _nightdifferentialhrs = value; }
            get { return _nightdifferentialhrs; }
        }

        public double TotalNightDifferential
        {
            set { _totalnightdifferential = value; }
            get { return _totalnightdifferential; }
        }

        public double NightDifferential
        {
            set { _nightdifferential = value; }
            get { return _nightdifferential; }
        }

        public double TransportAllowance
        {
            set { _transportallowance = value; }
            get { return _transportallowance; }
        }

        public double MealAllowance
        {
            set { _mealallowance = value; }
            get { return _mealallowance; }
        }

        public double Ricesubsidy
        {
            set { _ricesubsidy = value; }
            get { return _ricesubsidy; }
        }

        public double Laundry
        {
            set { _laundry = value; }
            get { return _laundry; }
        }

        public double Bonus
        {
            set { _bonus = value; }
            get { return _bonus; }
        }

        public double MonthlyIncentive
        {
            set { _monthlyincentive = value; }
            get { return _monthlyincentive; }
        }

        public double GrossPay
        {
            set { _grosspay = value; }
            get { return _grosspay; }
        }

        public double TaxSSS
        {
            get { return _taxsss; }
            set
            {
                if (BasicPay >= 1000.00 && BasicPay <= 1249.99)
                    _taxsss = 33.30;
                else if (BasicPay >= 1250.00 && BasicPay <= 1749.99)
                    _taxsss = 50.00;
                else if (BasicPay >= 1750.00 && BasicPay <= 2249.99)
                    _taxsss = 66.70;
                else if (BasicPay >= 2250.00 && BasicPay <= 2749.99)
                    _taxsss = 83.30;
                else if (BasicPay >= 2750.00 && BasicPay <= 3249.99)
                    _taxsss = 100.00;
                else if (BasicPay >= 3250.00 && BasicPay <= 3749.99)
                    _taxsss = 116.70;
                else if (BasicPay >= 3750.00 && BasicPay <= 4249.99)
                    _taxsss = 133.30;
                else if (BasicPay >= 4250.00 && BasicPay <= 4749.99)
                    _taxsss = 150.00;
                else if (BasicPay >= 4750.00 && BasicPay <= 5249.99)
                    _taxsss = 166.70;
                else if (BasicPay >= 5250.00 && BasicPay <= 5749.99)
                    _taxsss = 183.30;
                else if (BasicPay >= 5750.00 && BasicPay <= 6249.99)
                    _taxsss = 200;
                else if (BasicPay >= 6250.00 && BasicPay <= 6749.99)
                    _taxsss = 216.70;
                else if (BasicPay >= 6750.00 && BasicPay <= 7249.99)
                    _taxsss = 233.30;
                else if (BasicPay >= 7250.00 && BasicPay <= 7749.99)
                    _taxsss = 250.00;
                else if (BasicPay >= 7750.00 && BasicPay <= 8249.99)
                    _taxsss = 266.70;
                else if (BasicPay >= 8250.00 && BasicPay <= 8749.99)
                    _taxsss = 283.30;
                else if (BasicPay >= 8750.00 && BasicPay <= 9249.99)
                    _taxsss = 300.00;
                else if (BasicPay >= 9250.00 && BasicPay <= 9749.99)
                    _taxsss = 316.70;
                else if (BasicPay >= 9750.00 && BasicPay <= 10249.99)
                    _taxsss = 333.30;
                else if (BasicPay >= 10250.00 && BasicPay <= 10749.99)
                    _taxsss = 350.00;
                else if (BasicPay >= 10750.00 && BasicPay <= 11249.99)
                    _taxsss = 366.70;
                else if (BasicPay >= 11250.00 && BasicPay <= 11749.99)
                    _taxsss = 383.30;
                else if (BasicPay >= 11750.00 && BasicPay <= 12249.99)
                    _taxsss = 400.00;
                else if (BasicPay >= 12250.00 && BasicPay <= 12749.99)
                    _taxsss = 416.70;
                else if (BasicPay >= 12750.00 && BasicPay <= 13249.99)
                    _taxsss = 433.30;
                else if (BasicPay >= 13250.00 && BasicPay <= 13749.99)
                    _taxsss = 450.00;
                else if (BasicPay >= 13750.00 && BasicPay <= 14249.99)
                    _taxsss = 466.70;
                else if (BasicPay >= 14250.00 && BasicPay <= 14749.99)
                    _taxsss = 483.30;
                else if (BasicPay >= 14750.00)
                    _taxsss = 500.00;
            }

        }

        public double TaxPhilHealth
        {
            get { return _taxphilhealth; }
            set
            {
                if (BasicPay <= 7999.99)
                    _taxphilhealth = 87.50;

                else if (BasicPay >= 8000.00 && BasicPay <= 8999.99)
                    _taxphilhealth = 100.00;

                else if (BasicPay >= 9000.00 && BasicPay <= 9999.99)
                    _taxphilhealth = 112.50;

                else if (BasicPay >= 10000.00 && BasicPay <= 10999.99)
                    _taxphilhealth = 125.00;

                else if (BasicPay >= 11000.00 && BasicPay <= 11999.99)
                    _taxphilhealth = 137.50;

                else if (BasicPay >= 12000.00 && BasicPay <= 12999.99)
                    _taxphilhealth = 150.00;

                else if (BasicPay >= 13000.00 && BasicPay <= 13999.99)
                    _taxphilhealth = 162.50;

                else if (BasicPay >= 14000.00 && BasicPay <= 14999.99)
                    _taxphilhealth = 175.00;

                else if (BasicPay >= 15000.00 && BasicPay <= 15999.99)
                    _taxphilhealth = 187.50;

                else if (BasicPay >= 16000.00 && BasicPay <= 16999.99)
                    _taxphilhealth = 200.00;

                else if (BasicPay >= 17000.00 && BasicPay <= 17999.99)
                    _taxphilhealth = 212.50;

                else if (BasicPay >= 18000.00 && BasicPay <= 18999.99)
                    _taxphilhealth = 225.00;

                else if (BasicPay >= 19000.00 && BasicPay <= 19999.99)
                    _taxphilhealth = 237.50;

                else if (BasicPay >= 20000.00 && BasicPay <= 20999.99)
                    _taxphilhealth = 250.00;

                else if (BasicPay >= 21000.00 && BasicPay <= 21999.99)
                    _taxphilhealth = 262.50;

                else if (BasicPay >= 22000.00 && BasicPay <= 22999.99)
                    _taxphilhealth = 275.00;

                else if (BasicPay >= 23000.00 && BasicPay <= 23999.99)
                    _taxphilhealth = 287.50;

                else if (BasicPay >= 24000.00 && BasicPay <= 24999.99)
                    _taxphilhealth = 300.00;

                else if (BasicPay >= 25000.00 && BasicPay <= 25999.99)
                    _taxphilhealth = 312.50;

                else if (BasicPay >= 26000.00 && BasicPay <= 26999.99)
                    _taxphilhealth = 325.00;

                else if (BasicPay >= 27000.00 && BasicPay <= 27999.99)
                    _taxphilhealth = 337.50;

                else if (BasicPay >= 28000.00 && BasicPay <= 28999.99)
                    _taxphilhealth = 350.00;

                else if (BasicPay >= 29000.00 && BasicPay <= 29999.99)
                    _taxphilhealth = 362.50;

                else if (BasicPay >= 30000.00 && BasicPay <= 30999.99)
                    _taxphilhealth = 375.00;

                else if (BasicPay >= 31000.00 && BasicPay <= 31999.99)
                    _taxphilhealth = 387.50;

                else if (BasicPay >= 32000.00 && BasicPay <= 32999.99)
                    _taxphilhealth = 400.00;

                else if (BasicPay >= 33000.00 && BasicPay <= 33999.99)
                    _taxphilhealth = 412.50;

                else if (BasicPay >= 34000.00 && BasicPay <= 34999.99)
                    _taxphilhealth = 425.00;

                else if (BasicPay >= 35000.00)
                    _taxphilhealth = 437.50;
            }
        }

        public double TaxSSSLoan
        {
            set { _taxsssloan = value; }
            get { return _taxsssloan; }
        }

        public double TaxHDMF
        {
            get { return _hdmf; }
            set
            {
                if (GrossPay >= 0 && GrossPay <= 1499.00)
                    _hdmf = GrossPay * 0.01;

                else if (GrossPay >= 1500)
                    _hdmf = GrossPay * 0.02;
            }

        }

        public double TaxPagibigLoan
        {
            set { _pagibigloan = value; }
            get { return _pagibigloan; }
        }

        public double _taxableincome;

        public double TaxableIncome
        {
            get { return _taxableincome; }
            set
            {
                _taxableincome = value;
            }
        }

        public double WithHoldTax
        {
            get { return _withholdtax; }
            set
            {
                _withholdtax = value;
            }

        }

        public string PayrollDate
        {
            set { _payrolldate = value; }
            get { return _payrolldate; }
        }

        public double NetPay
        {
            set { _netpay = value; }
            get { return _netpay; }
        }

        public double SSSContribution
        {
            get { return _SSSContribution; }
            set
            {
                if (BasicPay >= 1000.00 && BasicPay <= 1249.99)
                    _SSSContribution = 70.70;
                else if (BasicPay >= 1250.00 && BasicPay <= 1749.99)
                    _SSSContribution = 106.00;
                else if (BasicPay >= 1750.00 && BasicPay <= 2249.99)
                    _SSSContribution = 141.30;
                else if (BasicPay >= 2250.00 && BasicPay <= 2749.99)
                    _SSSContribution = 176.70;
                else if (BasicPay >= 2750.00 && BasicPay <= 3249.99)
                    _SSSContribution = 212.00;
                else if (BasicPay >= 3250.00 && BasicPay <= 3749.99)
                    _SSSContribution = 247.30;
                else if (BasicPay >= 3750.00 && BasicPay <= 4249.99)
                    _SSSContribution = 282.70;
                else if (BasicPay >= 4250.00 && BasicPay <= 4749.99)
                    _SSSContribution = 318.00;
                else if (BasicPay >= 4750.00 && BasicPay <= 5249.99)
                    _SSSContribution = 353.30;
                else if (BasicPay >= 5250.00 && BasicPay <= 5749.99)
                    _SSSContribution = 388.70;
                else if (BasicPay >= 5750.00 && BasicPay <= 6249.99)
                    _SSSContribution = 424.00;
                else if (BasicPay >= 6250.00 && BasicPay <= 6749.99)
                    _SSSContribution = 459.30;
                else if (BasicPay >= 6750.00 && BasicPay <= 7249.99)
                    _SSSContribution = 694.70;
                else if (BasicPay >= 7250.00 && BasicPay <= 7749.99)
                    _SSSContribution = 530.00;
                else if (BasicPay >= 7750.00 && BasicPay <= 8249.99)
                    _SSSContribution = 565.30;
                else if (BasicPay >= 8250.00 && BasicPay <= 8749.99)
                    _SSSContribution = 600.70;
                else if (BasicPay >= 8750.00 && BasicPay <= 9249.99)
                    _SSSContribution = 636.00;
                else if (BasicPay >= 9250.00 && BasicPay <= 9749.99)
                    _SSSContribution = 671.30;
                else if (BasicPay >= 9750.00 && BasicPay <= 10249.99)
                    _SSSContribution = 706.70;
                else if (BasicPay >= 10250.00 && BasicPay <= 10749.99)
                    _SSSContribution = 742.00;
                else if (BasicPay >= 10750.00 && BasicPay <= 11249.99)
                    _SSSContribution = 777.30;
                else if (BasicPay >= 11250.00 && BasicPay <= 11749.99)
                    _SSSContribution = 812.70;
                else if (BasicPay >= 11750.00 && BasicPay <= 12249.99)
                    _SSSContribution = 848.00;
                else if (BasicPay >= 12250.00 && BasicPay <= 12749.99)
                    _SSSContribution = 883.30;
                else if (BasicPay >= 12750.00 && BasicPay <= 13249.99)
                    _SSSContribution = 918.70;
                else if (BasicPay >= 13250.00 && BasicPay <= 13749.99)
                    _SSSContribution = 954.00;
                else if (BasicPay >= 13750.00 && BasicPay <= 14249.99)
                    _SSSContribution = 989.30;
                else if (BasicPay >= 14250.00 && BasicPay <= 14749.99)
                    _SSSContribution = 1024.70;
                else if (BasicPay >= 14750.00)
                    _SSSContribution = 1060.00;
            }
        }

        public double HDMFContribution
        {
            get { return _HDMFContribution; }
            set
            {
                if (GrossPay >= 0 && GrossPay <= 1499.00)
                    _HDMFContribution = GrossPay * 0.01;

                else if (GrossPay >= 1500)
                    _HDMFContribution = GrossPay * 0.02;
            }

        }

        public double PhilHealthContribution
        {
            get { return _PhilHealthContribution; }
            set
            {
                if (BasicPay <= 7999.99)
                    _PhilHealthContribution = 87.50;

                else if (BasicPay >= 8000.00 && BasicPay <= 8999.99)
                    _PhilHealthContribution = 100.00;

                else if (BasicPay >= 9000.00 && BasicPay <= 9999.99)
                    _PhilHealthContribution = 112.50;

                else if (BasicPay >= 10000.00 && BasicPay <= 10999.99)
                    _PhilHealthContribution = 125.00;

                else if (BasicPay >= 11000.00 && BasicPay <= 11999.99)
                    _PhilHealthContribution = 137.50;

                else if (BasicPay >= 12000.00 && BasicPay <= 12999.99)
                    _PhilHealthContribution = 150.00;

                else if (BasicPay >= 13000.00 && BasicPay <= 13999.99)
                    _PhilHealthContribution = 162.50;

                else if (BasicPay >= 14000.00 && BasicPay <= 14999.99)
                    _PhilHealthContribution = 175.00;

                else if (BasicPay >= 15000.00 && BasicPay <= 15999.99)
                    _PhilHealthContribution = 187.50;

                else if (BasicPay >= 16000.00 && BasicPay <= 16999.99)
                    _PhilHealthContribution = 200.00;

                else if (BasicPay >= 17000.00 && BasicPay <= 17999.99)
                    _PhilHealthContribution = 212.50;

                else if (BasicPay >= 18000.00 && BasicPay <= 18999.99)
                    _PhilHealthContribution = 225.00;

                else if (BasicPay >= 19000.00 && BasicPay <= 19999.99)
                    _PhilHealthContribution = 237.50;

                else if (BasicPay >= 20000.00 && BasicPay <= 20999.99)
                    _PhilHealthContribution = 250.00;

                else if (BasicPay >= 21000.00 && BasicPay <= 21999.99)
                    _PhilHealthContribution = 262.50;

                else if (BasicPay >= 22000.00 && BasicPay <= 22999.99)
                    _PhilHealthContribution = 275.00;

                else if (BasicPay >= 23000.00 && BasicPay <= 23999.99)
                    _PhilHealthContribution = 287.50;

                else if (BasicPay >= 24000.00 && BasicPay <= 24999.99)
                    _PhilHealthContribution = 300.00;

                else if (BasicPay >= 25000.00 && BasicPay <= 25999.99)
                    _PhilHealthContribution = 312.50;

                else if (BasicPay >= 26000.00 && BasicPay <= 26999.99)
                    _PhilHealthContribution = 325.00;

                else if (BasicPay >= 27000.00 && BasicPay <= 27999.99)
                    _PhilHealthContribution = 337.50;

                else if (BasicPay >= 28000.00 && BasicPay <= 28999.99)
                    _PhilHealthContribution = 350.00;

                else if (BasicPay >= 29000.00 && BasicPay <= 29999.99)
                    _PhilHealthContribution = 362.50;

                else if (BasicPay >= 30000.00 && BasicPay <= 30999.99)
                    _PhilHealthContribution = 375.00;

                else if (BasicPay >= 31000.00 && BasicPay <= 31999.99)
                    _PhilHealthContribution = 387.50;

                else if (BasicPay >= 32000.00 && BasicPay <= 32999.99)
                    _PhilHealthContribution = 400.00;

                else if (BasicPay >= 33000.00 && BasicPay <= 33999.99)
                    _PhilHealthContribution = 412.50;

                else if (BasicPay >= 34000.00 && BasicPay <= 34999.99)
                    _PhilHealthContribution = 425.00;

                else if (BasicPay >= 35000.00)
                    _PhilHealthContribution = 437.50;
            }
        }

        public double SSSTotalContribution
        {
            get { return _SSSTotalContribution; }
            set
            {
                if (BasicPay >= 1000.00 && BasicPay <= 1249.99)
                    _SSSTotalContribution = 104.00;
                else if (BasicPay >= 1250.00 && BasicPay <= 1749.99)
                    _SSSTotalContribution = 156.00;
                else if (BasicPay >= 1750.00 && BasicPay <= 2249.99)
                    _SSSTotalContribution = 208.00;
                else if (BasicPay >= 2250.00 && BasicPay <= 2749.99)
                    _SSSTotalContribution = 260.00;
                else if (BasicPay >= 2750.00 && BasicPay <= 3249.99)
                    _SSSTotalContribution = 312.00;
                else if (BasicPay >= 3250.00 && BasicPay <= 3749.99)
                    _SSSTotalContribution = 364.00;
                else if (BasicPay >= 3750.00 && BasicPay <= 4249.99)
                    _SSSTotalContribution = 416.00;
                else if (BasicPay >= 4250.00 && BasicPay <= 4749.99)
                    _SSSTotalContribution = 468.00;
                else if (BasicPay >= 4750.00 && BasicPay <= 5249.99)
                    _SSSTotalContribution = 520.00;
                else if (BasicPay >= 5250.00 && BasicPay <= 5749.99)
                    _SSSTotalContribution = 572.00;
                else if (BasicPay >= 5750.00 && BasicPay <= 6249.99)
                    _SSSTotalContribution = 624.00;
                else if (BasicPay >= 6250.00 && BasicPay <= 6749.99)
                    _SSSTotalContribution = 676.00;
                else if (BasicPay >= 6750.00 && BasicPay <= 7249.99)
                    _SSSTotalContribution = 728.00;
                else if (BasicPay >= 7250.00 && BasicPay <= 7749.99)
                    _SSSTotalContribution = 780.00;
                else if (BasicPay >= 7750.00 && BasicPay <= 8249.99)
                    _SSSTotalContribution = 832.00;
                else if (BasicPay >= 8250.00 && BasicPay <= 8749.99)
                    _SSSTotalContribution = 884.00;
                else if (BasicPay >= 8750.00 && BasicPay <= 9249.99)
                    _SSSTotalContribution = 936.00;
                else if (BasicPay >= 9250.00 && BasicPay <= 9749.99)
                    _SSSTotalContribution = 988.00;
                else if (BasicPay >= 9750.00 && BasicPay <= 10249.99)
                    _SSSTotalContribution = 1040.00;
                else if (BasicPay >= 10250.00 && BasicPay <= 10749.99)
                    _SSSTotalContribution = 1092.00;
                else if (BasicPay >= 10750.00 && BasicPay <= 11249.99)
                    _SSSTotalContribution = 1144.00;
                else if (BasicPay >= 11250.00 && BasicPay <= 11749.99)
                    _SSSTotalContribution = 1196.00;
                else if (BasicPay >= 11750.00 && BasicPay <= 12249.99)
                    _SSSTotalContribution = 1248.00;
                else if (BasicPay >= 12250.00 && BasicPay <= 12749.99)
                    _SSSTotalContribution = 1300.00;
                else if (BasicPay >= 12750.00 && BasicPay <= 13249.99)
                    _SSSTotalContribution = 1352.00;
                else if (BasicPay >= 13250.00 && BasicPay <= 13749.99)
                    _SSSTotalContribution = 1404.00;
                else if (BasicPay >= 13750.00 && BasicPay <= 14249.99)
                    _SSSTotalContribution = 1456.00;
                else if (BasicPay >= 14250.00 && BasicPay <= 14749.99)
                    _SSSTotalContribution = 1508.00;
                else if (BasicPay >= 14750.00)
                    _SSSTotalContribution = 1560.00;
            }
        }
        public double HDMFTotalContribution
        {
            get { return _HDMFTotalContribution; }
            set
            {
                _HDMFTotalContribution = TaxHDMF + HDMFContribution;
            }
        }

        public double PhilHealthTotalContribution
        {
            get { return _PhilHealthTotalContribution; }
            set
            {
                _PhilHealthTotalContribution = TaxPhilHealth + PhilHealthContribution;
            }
        }

    }
}
