using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MEIP_System
{
    public class DAT_Biometric
    {
        public static string cs = "SERVER =localhost; DATABASE=EmployeePortal; Integrated Security=true;";

        public static List<string> ViewUsers()
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UserID FROM tblUsers", cs);
            da.Fill(dt);
            foreach (DataRow userID in dt.Rows)
            {
                list.Add(userID[0].ToString());
            }
            return list;
        }

        [Obsolete]
        public static int ViewNoFingerprint(string UserID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select UserID from tblUsers where UserID = (select DISTINCT UserID from tblAttendance where UserID ='" + UserID + "')", cs);
            da.Fill(dt);
            return dt.Rows.Count;
        }

        public static int Register(string UserID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UserID FROM tblUsers WHERE UserID = " + UserID, cs);
            da.Fill(dt);
            return dt.Rows.Count;
        }

        public static int ValidationOfExistingFingerprints(string UserID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FingerScanID from tblFingerScan where UserID = " + UserID, cs);
            da.Fill(dt);
            return dt.Rows.Count;
        }

        public static void RegisterFirstFingerprint(string empid, object data, object pRegTmplate)
        {
            SqlConnection cs1 = new SqlConnection(cs);
            cs1.Open();
            SqlCommand da = new SqlCommand("INSERT INTO tblFingerScan(UserID,FingerprintImage,FingerprintTemplate) VALUES ('" + empid + "', @a, @b)", cs1);
            da.Parameters.Add("@a", SqlDbType.Image).Value = data;
            da.Parameters.Add("@b", SqlDbType.Image).Value = pRegTmplate;
            da.ExecuteNonQuery();
            cs1.Close();
        }

        #region Timekeeping

        public static DataTable ViewFingerPrintTemplate()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblFingerScan", cs);
            da.Fill(dt);
            return dt;
        }

        public static string GetUserStatus(string userID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UserStatus from tblUsers where UserID = '" + userID + "'", cs);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }
        }

        public static void InsertAttendance(string userID, string userStatus)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            DataTable today = new DataTable();

            int weekend = 0;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                weekend = -1;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                weekend = -2;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                weekend = -3;
            }

            if (userStatus == "In")
            {
                #region AWOL
                #region WEEKEND

                #endregion

                //Checks the weekend
                da = new SqlDataAdapter("select * from tblAttendance where (DATEPART(yy, TimeIn) = '" + DateTime.Now.Year + "' AND DATEPART(mm, TimeIn) = '" + DateTime.Now.Month + "'AND DATEPART(dd, TimeIn) = '" + DateTime.Now.AddDays(weekend).Day.ToString() + "') AND UserID = '" + userID + "'", cs);
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    //Checks if AWOL is PRESENT Today
                    da = new SqlDataAdapter("select * from tblAttendance where (DATEPART(yy, TimeIn) = '" + DateTime.Now.Year + "' AND DATEPART(mm, TimeIn) = '" + DateTime.Now.Month + "'AND DATEPART(dd, TimeIn) = '" + DateTime.Now.Day + "') AND UserID = " + userID + " AND AWOL = 1", cs);
                    da.Fill(today);

                    if (today.Rows.Count == 0)
                    {
                        string yesterday = "'" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.AddDays(weekend).Day.ToString() + "'";
                        //Inserts AWOL with Date of AWOL
                        da = new SqlDataAdapter("INSERT INTO tblAttendance (UserID, AWOL, TimeIn, TimeOut) values ('" + userID + "', 1.0, " + yesterday + "," + yesterday + ")", cs);
                        da.Fill(dt);
                    }
                }
                #endregion
                //Checks if there is an existing late record
                da = new SqlDataAdapter("select * from tblAttendance where (DATEPART(yy, TimeIn) = '" + DateTime.Now.Year + "' AND DATEPART(mm, TimeIn) = '" + DateTime.Now.Month + "'AND DATEPART(dd, TimeIn) = '" + DateTime.Now.Day + "') AND UserID = " + userID + " AND AWOL = 1", cs);
                da.Fill(today);
                //DateTime late = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
                if (today.Rows.Count == 0)
                {
                    #region LATE
                    DateTime late = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 10, 0);
                    if (DateTime.Now >= late)
                    {
                        da = new SqlDataAdapter("INSERT INTO tblAttendance (UserID, TimeIn, Late) values ('" + userID + "', GETDATE(), 1.0)", cs);
                    }
                    #endregion
                }
                else
                {
                    da = new SqlDataAdapter("INSERT INTO tblAttendance (UserID, TimeIn) values ('" + userID + "', GETDATE())", cs);
                }
            }
            else
            {
                DateTime day = DateTime.Now.AddDays(weekend);
                da = new SqlDataAdapter("select TimeOut from tblAttendance where '" + day.Day + " " + DateTime.Now.ToString("MMM") + " " + DateTime.Now.Year + "' <= TimeIn AND TimeIn < '" + DateTime.Now.Day + " " + DateTime.Now.ToString("MMM") + " " + DateTime.Now.Year + "' AND UserID = " + userID + " ORDER BY TimeOut ASC", cs);
                da.Fill(dt);
                if (dt.Rows.Count != 0 && dt.Rows[0][0] != null)
                {
                    da = new SqlDataAdapter("UPDATE tblUsers set UserStatus = 'Out' WHERE UserID = '" + userID + "'", cs);
                    da.Fill(dt);
                    InsertAttendance(userID, "In");
                }
                da = new SqlDataAdapter("UPDATE tblAttendance set TimeOut = GETDATE() where AttendanceID = (SELECT MAX(AttendanceID) from tblAttendance where UserID = '" + userID + "')", cs);
                
                //DateTime undertime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
                DateTime undertime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 30, 0);
                if (DateTime.Now <= undertime)
                {
                    da = new SqlDataAdapter("UPDATE tblAttendance set TimeOut = GETDATE(), Undertime = 1.0 where AttendanceID = (SELECT MAX(AttendanceID) from tblAttendance where UserID = '" + userID + "')", cs);
                }
            }
            da.Fill(dt);
            da = new SqlDataAdapter("UPDATE tblUsers set UserStatus = '" + userStatus + "' where UserID = '" + userID + "'", cs);
            da.Fill(dt);
            return;
        }
        #endregion
    }
}
