﻿using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;
using System;
using System.Text;

namespace MEIP_System
{
    public class DAT
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        #region Login
        public static DataTable Login(RequestLogin request)
        {
            DataTable d2 = new DataTable();
            string password = ComputeHash(request.Password);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_LoginUser '" + request.Username + "', '" + password + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "LoggedIn");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region UserID
        public static DataTable GetUserID(RequestGetUserID request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_GetUserID '" + request.Username + "'", cs);
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Accounts
        public static DataTable AddUser(RequestAddUser request)
        {
            string password = ComputeHash(request.Password);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_AddEmployee '" + request.UsertypeID + "','" + request.LName + "','" + request.FName + "','" + request.MName + "','" + request.Nickname + "','" + request.DOB + "','" + request.CivilStatus + "','" + request.Gender + "','" + request.Username + "','" + password + "','" + request.DateTimeAdded + "','" + request.AccountStatus + "','" + request.UserStatus + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Added User");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewUsers()
        {
            string cs = "SERVER =localhost; DATABASE=EmployeePortal; Integrated Security=true;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewUsers", cs);

            da.Fill(dt);
            return dt;
        }

        public static DataTable DeactivateAccount(RequestDeactivateAccount request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_DeactivateAccount '" + request.UserID + "'", cs);
            RequestAuditTrail RequestAudit = new RequestAuditTrail(request.Username, "Deactivated an Account");
            DAT.AuditTrail(RequestAudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ActivateAccount(RequestActivateAccount request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ActivateAccount '" + request.UserID + "'", cs);
            RequestAuditTrail RequestAudit = new RequestAuditTrail(request.Username, "Activated an Account");
            DAT.AuditTrail(RequestAudit);
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Add Information

        public static void AddWorkExperience(RequestAddWorkExperience request)
        {
            string cs = "SERVER =localhost; DATABASE=EmployeePortal; Integrated Security=true;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_AddWorkExperience '" + request.Username + "','" + request.YearStarted + "','" + request.YearEnded + "','" + request.Company + "','" + request.ExpPosition + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Added Work Experience");
            DAT.AuditTrail(requestaudit);
            
            da.Fill(dt);
        }
       
        public static void AddSiblingInfo(RequestAddSiblingInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_AddSiblingInfo '" + request.Username + "','" + request.SiblingLName + "','" + request.SiblingFName + "','" + request.SiblingContactNum + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Added New Sibling Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        public static void AddEducInfo(RequestAddEducInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_AddEducInfo '" + request.Username + "','" + request.School + "','" + request.Degree + "','" + request.Course + "','" + request.YearGraduated + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Added School");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        #endregion

        #region View
        public static DataTable ViewGeneralInfo(RequestViewGeneralInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewGeneralInfo '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed General Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewEducInfo(RequestViewEducInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewEducInfo '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Educational Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewContactInfo(RequestViewContactInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewContactInfo '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Contact Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewFamilyInfo(RequestViewFamilyInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewFamilyInfo '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Family Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewSiblingInfo(RequestViewSiblingInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewSiblingInfo '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Sibling Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewGovtInfo(RequestViewGovtInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewGovtInfo '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Government Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewCompanyInfo(RequestViewCompanyInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewCompanyInfo '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Company Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewWorkExperience(RequestViewWorkExperience request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewWorkExperience '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Work Experience");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewAuditTrail(RequestViewAuditTrail request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewAuditTrail '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Audit Trail");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Reports
        public static DataTable UserList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("UserList ", cs);
            da.Fill(dt);
            return dt;
        }

        public static DataTable DailyTimeReport(RequestDailyTimeReport request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_DailyTimeReport " + request, cs);
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Update
        public static void UpdateContactInfo(RequestUpdateContactInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateContactInfo '" + request.Username + "','" + request.HomeNum + "','" + request.CellphoneNum + "','" + request.HomeAddress + "','" + request.Email + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Updated Contact Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        public static void UpdateEducInfo(RequestUpdateEducationalInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateEducInfo '" + request.EducInfoID + "','" + request.Username + "','" + request.School + "','" + request.Degree + "','" + request.Course + "','" + request.YearGraduated + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Updated Educational Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        public static void UpdateFamilyInfo(RequestUpdateFamilyInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateFamilyInfo '" + request.FamilyInfoID + "','" +  request.Username + "','" + request.FatherLName + "','" + request.FatherFName + "','" + request.MotherLName + "','" + request.MotherFName + "','" + request.FatherContactNum + "','" + request.MotherContactNum + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Updated Family Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        public static void UpdateSiblingInfo(RequestUpdateSiblingInfo request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateSiblingInfo '" + request.SiblingID + "','" + request.Username  + "','" + request.SiblingLName + "','" + request.SiblingFName + "','" + request.SiblingContactNum + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Updated Sibling Information");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        public static DataTable UpdateWorkExperience(RequestUpdateWorkExperience request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateWorkExperience '" + request.WorkExperienceID + "','" + request.Username + "','" + request.YearStarted + "','" + request.YearEnded + "','" + request.Company + "','" + request.ExpPosition + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Updated Work Experience");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        //public static DataTable UpdateCompanyInfo()
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("SP_UpdateWorkExperience '" + request.Username + "','" + request.FatherLName + "','" + request.FatherFName + "','" + request.MotherLName + "','" + request.MotherFName + "','" + request.FatherContactNum + "','" + request.MotherContactNum + "','" + request.SiblingLName + "','" + request.SiblingFName + "','" + request.SiblingContactNum + "'", cs);
        //    da.Fill(dt);
        //    return dt;
        //}

        //public static void UpdatePassword(RequestUpdatePassword request)
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("SP_UpdatePassword " + request.UserID + ", " + request.Password, cs);
        //    da.Fill(dt);
        //}
        
        #endregion

        #region AuditTrail

        public static DataTable AuditTrail(RequestAuditTrail request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_AuditTrail '" + request.Username + "','" + request.Action + "'", cs);
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region Search
        public static DataTable SearchEmployees(RequestSearchEmployees request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_SearchEmployees '" + request.Username + "%" + request.LName + "%" + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Searched Employee");
            DAT.AuditTrail(requestaudit);
            
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Requests

        public static DataTable ViewAllRequest()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewAllRequest ", cs);
            //RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed All Request");
            //DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static void VerifyRequest(RequestVerifyRequests request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_VerifyRequests '" + request.RequestID + "','" + request.UserID + "','" + request.Status + "','" + request.Remarks + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Verified Request");
            DAT.AuditTrail(requestaudit);

            da.Fill(dt);
        }

        #region Leaves
        public static void LeaveRequest(RequestLeaveRequest request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_LeaveRequest '" + request.Username + "','" + request.RequestType + "','" + request.DateApplied + "','" + request.StartDate + "','" + request.EndDate + "','" + request.LeaveType + "','" + request.Reason + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Applied for Leave Request");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        public static DataTable ViewLeaveRequest(RequestViewLeaveRequest request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewLeaveRequest '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Leave Request");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static void UpdateLeaveRequest(RequestUpdateLeaveRequest request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateLeaveRequest '" + request.RequestID + "','" + request.Username + "','" + request.DateApplied + "','" + request.StartDate + "','" + request.EndDate + "','" + request.LeaveType + "','" + request.Reason + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Updated Leave Request");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }
        #endregion

        #region Time Change
        public static DataTable ViewTimeChangeRequest(RequestViewTimeChangeRequest request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewTimeChangeRequest '" + request.Username + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Viewed Time Change Request");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
            return dt;
        }

        public static void TimeChangeRequest(RequestTimeChangeRequest request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_TimeChangeRequest '" + request.Username + "','" + request.RequestType + "','" + request.DateApplied + "','" + request.AttendanceDateChange + "','" + request.TimeInChange + "','" + request.TimeOutChange + "','" + request.Reason + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Applied for Time Change Request");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }

        public static void UpdateTimeChangeRequest(RequestUpdateTimeChangeRequest request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateTimeChangeRequest '" + request.RequestID + "','" + request.Username + "','" + request.DateApplied + "','" + request.AttendanceDateChange + "','" + request.TimeChangeIn + "','" + request.TimeChangeOut + "','" + request.Reason + "'", cs);
            RequestAuditTrail requestaudit = new RequestAuditTrail(request.Username, "Updated Time Change Request");
            DAT.AuditTrail(requestaudit);
            da.Fill(dt);
        }
        #endregion

        #endregion

        #region Encryption
        private static string ComputeHash(string password)
        {
            string SHA512 = "";

            SHA512 hash3 = System.Security.Cryptography.SHA512.Create();
            ASCIIEncoding encoder3 = new ASCIIEncoding();
            byte[] combined3 = encoder3.GetBytes(password);
            hash3.ComputeHash(combined3);
            SHA512 = Convert.ToBase64String(hash3.Hash);

            return SHA512;
        }
        #endregion

        #region Timekeeping
        public static DataTable RetrieveDTR(RequestRetrieveAttendanceRecords request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_DailyTimeReport '" + request.Username + "'", cs);
            da.Fill(dt);
            return dt;
        }

        #region Tasks
        public static DataTable AddTask(RequestAddTask request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_AddTask '" + request.UserID + "','" +
            request.Task + "','" + request.TaskDate + "'", cs);
            da.Fill(dt);
            return dt;
        }

        public static DataTable UpdateTask(RequestUpdateTask request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_UpdateTask '" + request.NotifID + "','" +
            request.UserID + "','" + request.Task + "','" + request.TaskDate + "'", cs);
            da.Fill(dt);
            return dt;
        }

        public static DataTable ViewTask()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ViewTask ", cs);
            da.Fill(dt);
            return dt;
        }
        #endregion
        #endregion

        #region Payroll
        public static DataTable ComputePayroll(RequestComputePayroll request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_ComputePayroll '" +
                request.UserID + "','" +
                request.BasicPay + "','" +
                request.DailyRate + "','" +
                request.WorkingHrs + "','" +
                request.PerHrRate + "','" +
                request.NoofMinuteLate + "','" +
                request.LateDeductions + "','" +
                request.NoDaysAbsent + "','" +
                request.AbsentDeductions + "','" +
                request.NoofMinuteUndertime + "','" +
                request.UndertimeDeductions + "','" +
                request.NightDifferentialHrs + "','" +
                request.TotalNightDifferential + "','" +
                request.NightDifferential + "','" +
                request.TransportAllowance + "','" +
                request.MealAllowance + "','" +
                request.Ricesubsidy + "','" +
                request.Laundry + "','" +
                request.HolidayPay + "','" +
                request.Bonus + "','" +
                request.MonthlyIncentive + "','" +
                request.GrossPay + "','" +
                request.TaxSSS + "','" +
                request.SSSContribution + "','" +
                request.SSSTotalContribution + "','" +
                request.TaxPhilHealth + "','" +
                request.PhilHealthContribution + "','" +
                request.PhilHealthTotalContribution + "','" +
                request.TaxSSSLoan + "','" +
                request.TaxHDMF + "','" +
                request.HDMFContribution + "','" +
                request.HDMFTotalContribution + "','" +
                request.TaxPagibigLoan + "','" +
                request.WithHoldTax + "','" +
                request.PayrollDate + "','" +
                request.NetPay + "'", cs);
            da.Fill(dt);
            return dt;
        }

        public static DataTable GetCompensation(RequestGetCompensation request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_GetEmployeeCompensation '" + request.UserID + "'", cs);
            da.Fill(dt);
            return dt;
        }

        public static void RegisterEmployeeCompensation(RequestAddEmployeeCompensation request)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SP_RegisterEmployeeCompensation'" + request.UserID + "','" + request.BasicPay + "'", cs);
            da.Fill(dt);
        }

        public static string GetCivilStatus(string UserID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select CivilStatus From tblUsers where UserID='" + UserID + "'", cs);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        #endregion
    }
}
 