using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MEIP_System.UI.ExternalAccountant
{
    public partial class EA_ComputePayroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializeTextboxes();
            }
        }

        protected void InitializeTextboxes()
        {
            txtNoOfLate.Text = "0";
            txtNoOfAbsent.Text = "0";
            txtNoOfUndertime.Text = "0";
            txtNightDiffHrs.Text = "0";
            txtHolidayPay.Text = "0";
            txtBonus.Text = "0";
            txtSSS.Text = "0.00";
            txtEmployerSSS.Text = "0";
            txtTotalSSS.Text = "0";
            txtPhilHealth.Text = "0";
            txtEmployerPhilHealth.Text = "0";
            txtTotalPhilHealth.Text = "0";
            txtHDMF.Text = "0";
            txtEmployerHDMF.Text = "0";
            txtTotalHDMF.Text = "0";
            txtMonthlyIncentive.Text = "0";
            txtSSSLoan.Text = "0";
            txtPagibigLoan.Text = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestGetCompensation request = new RequestGetCompensation();
            request.UserID = int.Parse(txtUserID.Text);
            DataTable dt = DAT.GetCompensation(request);

            txtBasicPay.Text = dt.Rows[0]["CBasicPay"].ToString();
            txtTransportAllowance.Text = dt.Rows[0]["CTransport"].ToString();
            txtMealAllowance.Text = dt.Rows[0]["CMeal"].ToString();
            txtRiceSubsidy.Text = dt.Rows[0]["CRiceSubsidy"].ToString();
            txtLaundry.Text = dt.Rows[0]["CLaundry"].ToString();
        }
        protected void ComputePayroll_Click(object sender, EventArgs e)
        {
            RequestComputePayroll request = new RequestComputePayroll();
            DataTable dt = new DataTable();

            double BasicPay = Convert.ToDouble(txtBasicPay.Text);
            double DailyRate = ((BasicPay * 2) * 12) / 261;
            int WorkingHrs = 8;
            double PerHrRate = DailyRate / WorkingHrs;
            double PerMinuteRate = PerHrRate / 60;
            int NoOfLate = Convert.ToInt32(txtNoOfLate.Text);
            double LateDeductions = PerMinuteRate * NoOfLate;
            int NoOfAbsent = Convert.ToInt32(txtNoOfAbsent.Text);
            double AbsentDeductions = PerMinuteRate * NoOfAbsent;
            int NoOfUndertime = Convert.ToInt32(txtNoOfUndertime.Text);
            double UndertimeDeductions = PerMinuteRate * NoOfUndertime;
            int NightDifferentialHrs = Convert.ToInt32(txtNightDiffHrs.Text);
            double TotalNightDifferential = PerHrRate * NightDifferentialHrs;
            double NightDifferential = TotalNightDifferential * 0.10;
            double TransportAllowance = Convert.ToDouble(txtTransportAllowance.Text);
            double MealAllowance = Convert.ToDouble(txtMealAllowance.Text);
            double RiceSubsidy = Convert.ToDouble(txtRiceSubsidy.Text);
            double Laundry = Convert.ToDouble(txtLaundry.Text);
            double HolidayPay = Convert.ToDouble(txtHolidayPay.Text);
            double Bonus = Convert.ToDouble(txtBonus.Text);
            double MonthlyIncentive = Convert.ToDouble(txtMonthlyIncentive.Text);
            double GrossPay = (BasicPay + NightDifferential + MonthlyIncentive +
                TransportAllowance) - (LateDeductions + AbsentDeductions - UndertimeDeductions);
            double TaxSSS = Convert.ToDouble(txtSSS.Text);
            double SSSContribution = Convert.ToDouble(txtEmployerSSS.Text);
            double SSSTotalContribution = TaxSSS + SSSContribution;
            double TaxPhilHealth = Convert.ToDouble(txtPhilHealth.Text);
            double PhilHealthContribution = Convert.ToDouble(txtEmployerPhilHealth.Text);
            double PhilHealthTotalContribution = TaxPhilHealth + PhilHealthContribution;
            double TaxSSSLoan = Convert.ToDouble(txtSSSLoan.Text);
            double TaxHDMF = Convert.ToDouble(txtHDMF.Text);
            double HDMFContribution = Convert.ToDouble(txtEmployerHDMF.Text);
            double HDMFTotalContribution = TaxHDMF + HDMFContribution;
            double TaxPagibigLoan = Convert.ToDouble(txtPagibigLoan.Text);
            double TaxableIncome = (GrossPay + HolidayPay + NightDifferential);
            string CivilStatus = DAT.GetCivilStatus(txtUserID.Text);
            double Bracket = 0.0;
            double Percent = 0.00;
            double BaseTax = 0.00;

            SortedDictionary<string, string> Exemptions = new SortedDictionary<string, string>();
            Exemptions.Add("1", (Math.Abs(TaxableIncome - 1)).ToString());
            Exemptions.Add("2", (Math.Abs(TaxableIncome - 4167)).ToString());
            Exemptions.Add("3", (Math.Abs(TaxableIncome - 5000)).ToString());
            Exemptions.Add("4", (Math.Abs(TaxableIncome - 6667)).ToString());
            Exemptions.Add("5", (Math.Abs(TaxableIncome - 10000)).ToString());
            Exemptions.Add("6", (Math.Abs(TaxableIncome - 15833)).ToString());
            Exemptions.Add("7", (Math.Abs(TaxableIncome - 25000)).ToString());
            Exemptions.Add("8", (Math.Abs(TaxableIncome - 45833)).ToString());
            //TODO: No .Next() function in .net 2.0
            
            switch (Exemptions.Last().Key)
            {
                case "1":
                    {
                        Bracket = 1;
                        Percent = 0;
                        BaseTax = 0;
                        break;
                    }
                case "2":
                    {
                        Bracket = 4167;
                        Percent = 5;
                        BaseTax = 0.00;
                        break;
                    }
                case "3":
                    {
                        Bracket = 5000;
                        Percent = 0.10;
                        BaseTax = 41.67;
                        break;
                    }
                case "4":
                    {
                        Bracket = 6667;
                        Percent = 0.15;
                        BaseTax = 208.33;
                        break;
                    }
                case "5":
                    {
                        Bracket = 10000;
                        Percent = 0.20;
                        BaseTax = 708.33;
                        break;
                    }
                case "6":
                    {
                        Bracket = 15833;
                        Percent = 0.25;
                        BaseTax = 1875;
                        break;
                    }
                case "7":
                    {
                        Bracket = 25000;
                        Percent = 0.30;
                        BaseTax = 4166.67;
                        break;
                    }
                case "8":
                    {
                        Bracket = 45833;
                        Percent = 0.32;
                        BaseTax = 10416.67;
                        break;
                    }
            }
            double WithHoldTax = (((TaxableIncome - Bracket) * Percent) + (BaseTax));
            double NetPay = GrossPay + MealAllowance + Bonus + MonthlyIncentive + TransportAllowance + MealAllowance + RiceSubsidy + Laundry
                - TaxSSS - TaxPhilHealth - TaxSSSLoan - TaxHDMF - TaxPagibigLoan - WithHoldTax;

            request.UserID = int.Parse(txtUserID.Text);
            request.BasicPay = BasicPay;
            request.DailyRate = DailyRate;
            request.WorkingHrs = WorkingHrs;
            request.PerHrRate = PerHrRate;
            request.NoofMinuteLate = NoOfLate;
            request.LateDeductions = LateDeductions;
            request.NoDaysAbsent = NoOfAbsent;
            request.AbsentDeductions = AbsentDeductions;
            request.NoofMinuteUndertime = NoOfUndertime;
            request.UndertimeDeductions = UndertimeDeductions;
            request.NightDifferentialHrs = NightDifferentialHrs;
            request.TotalNightDifferential = TotalNightDifferential;
            request.NightDifferential = NightDifferential;
            request.TransportAllowance = TransportAllowance;
            request.MealAllowance = MealAllowance;
            request.Ricesubsidy = RiceSubsidy;
            request.Laundry = Laundry;
            request.HolidayPay = HolidayPay;
            request.Bonus = Bonus;
            request.MonthlyIncentive = MonthlyIncentive;
            request.GrossPay = GrossPay;
            request.TaxSSS = TaxSSS;
            request.SSSContribution = SSSContribution;
            request.SSSTotalContribution = SSSTotalContribution;
            request.TaxPhilHealth = TaxPhilHealth;
            request.PhilHealthContribution = PhilHealthContribution;
            request.PhilHealthTotalContribution = PhilHealthTotalContribution;
            request.TaxSSSLoan = TaxSSSLoan;
            request.TaxHDMF = TaxHDMF;
            request.HDMFContribution = HDMFContribution;
            request.HDMFTotalContribution = HDMFTotalContribution;
            request.TaxPagibigLoan = TaxPagibigLoan;
            request.TaxableIncome = TaxableIncome;
            request.WithHoldTax = WithHoldTax;
            request.PayrollDate = Calendar1.SelectedDate.ToString();
            request.NetPay = NetPay;

            if (OkayToGenerateMonth())
                try
                {
                    DAT.ComputePayroll(request);
                    Response.Write("<script language='javascript'>alert('Compute Payroll Successfully!.')</script>");
                }
                catch (Exception ex)
                {
                    String jstring;
                    jstring = "<script language='javascript'>alert('Compute Payroll Failed!" + ex.Message + "')</script>";
                    Response.Write(jstring);
                }
                finally
                {
                    txtBasicPay.Text = ""; txtDailyRate.Text = ""; txtWorkingHrs.Text = ""; txtPerHrRate.Text = "";
                    txtPerMinuteRate.Text = ""; txtNoOfLate.Text = ""; txtLateDeductions.Text = "";
                    txtNoOfAbsent.Text = ""; txtAbsentDeduction.Text = ""; txtNoOfUndertime.Text = "";
                    txtUndertimeDeduction.Text = ""; txtHolidayPay.Text = ""; txtBonus.Text = "";
                    txtMonthlyIncentive.Text = ""; txtTransportAllowance.Text = "";
                    txtMealAllowance.Text = ""; txtRiceSubsidy.Text = ""; txtLaundry.Text = "";
                    txtSSS.Text = ""; txtPhilHealth.Text = ""; txtSSSLoan.Text = ""; txtHDMF.Text = "";
                    txtPagibigLoan.Text = "";
                }
            else
                Response.Write("<script language='javascript'>alert('Payroll already generated for the entire month!.')</script>");

        }
        protected void CancelComputation_Click(object sender, EventArgs e)
        {
            Response.Redirect("EA_Home.apspx");
        }

        protected bool OkayToGenerateMonth()
        {
            // this method will determine if there are already 2 rows in the payroll table for the selected month
            // returns false if there already 2 rows for the selected month
            bool Retval;
            int month = Calendar1.SelectedDate.Month;
            int existingpayrollcount;
            string sqlstring = "SELECT COUNT(*) FROM payroll WHERE DATEPART(MONTH, PayrollDate) = " + month.ToString();
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
            SqlCommand command = new SqlCommand(sqlstring, sqlcon);
            sqlcon.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            existingpayrollcount = Convert.ToInt32(reader[0]);
            reader.Close();
            if (existingpayrollcount < 8)
                Retval = true;
            else
                Retval = false;

            return Retval;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
}
}