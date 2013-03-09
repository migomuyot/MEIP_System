using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DPSDKOPSLib;
using System.Data.SqlClient;
using DpSdkEngLib;
using Microsoft.VisualBasic.Compatibility.VB6;
using System.IO;
using System.Collections;

namespace MEIP_System.BiometricAttendance
{
    public partial class Form1 : Form
    {
        FPGetTemplateClass verifyTemple = new FPGetTemplateClass();
        DateTime current = new DateTime();

        public Form1()
        {
            InitializeComponent();
        }

        private void VerifyDone(object obj)
        {
            DpSdkEngLib.AISecureModeMask nullSecureModeMask = new DpSdkEngLib.AISecureModeMask();

            bool notMatched = false;
            bool verifyOK = false;

            object nullObject = 0;
            bool nullBool = true;

            
            {
                DataTable dt = DAT_Biometric.ViewFingerPrintTemplate();

                if (dt.Rows.Count <= 0)
                {
                    this.lblStatus.Text = "No fingerprint template in databse";
                }

                foreach (DataRow dataRow in dt.Rows)
                {
                    FPTemplate verifyTemplate = (FPTemplate)obj;
                    FPTemplateClass RegTemplate = new FPTemplateClass();


                    RegTemplate.Import(dataRow["FingerprintTemplate"]);

                    FPVerifyClass verify = new FPVerifyClass();
                    verify.Compare(RegTemplate,
                        verifyTemplate,
                        ref verifyOK,
                        ref nullObject,
                        ref nullObject,
                        ref nullBool,
                        ref nullSecureModeMask);

                    if (verifyOK)
                    {
                        this.txtUserID.Text = dataRow["UserID"].ToString();
                        this.lblStatus.Text = "Fingerprint Verified";

                        #region Show Employee Information
                        SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT * FROM tblUsers WHERE UserID = '" + dataRow["UserID"] + "'", DAT_Biometric.cs);
                        DataTable dataTable2 = new DataTable();
                        sqlDataAdapter2.Fill(dataTable2);

                        txtUsername.Text = dataTable2.Rows[0]["Username"].ToString();
                        txtFName.Text = dataTable2.Rows[0]["FName"].ToString();
                        txtLName.Text = dataTable2.Rows[0]["LName"].ToString();

                        //if (dataTable2.Rows[0]["Picture"] == null)
                        //{
                        //    byte[] numArray = new byte[0];
                        //    this.pictureBoxImage.Image = Image.FromStream((Stream)new MemoryStream((byte[])dataTable2.Rows[0]["Picture"]));
                        //}
                        #endregion

                        notMatched = true;
                        string userID = dataRow["UserID"].ToString();

                        //TODO: Note that in your users table you should have
                        //      a userStatus to know if the user is in or out
                        //      when creating a new user make the userStatus Out
                        string userStatus = DAT_Biometric.GetUserStatus(userID);
                        
                        current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                        if (userStatus == "Out")
                        {
                            DAT_Biometric.InsertAttendance(userID, "In");
                            lblTime.Visible = true;
                            lblTime.Text = this.current.ToString();
                            lblSaveSuccess.Visible = true;
                            lblSaveSuccess.Text = "Save Successful";
                            MessageBox.Show("Welcome");
                        }
                        else if (userStatus == "In")
                        {
                            DAT_Biometric.InsertAttendance(userID, "Out");
                            lblTime.Visible = true;
                            lblTime.Text = this.current.ToString();
                            lblSaveSuccess.Visible = true;
                            lblSaveSuccess.Text = "Save Successful";
                            MessageBox.Show("Goodbye");
                        }
                        break;
                    }
                    else
                    {
                        notMatched = false;
                    }
                }
                if (!notMatched)
                {
                    this.txtUserID.Text = "";
                    this.lblStatus.Text = "Fingerprint not in Record";
                }

                verifyTemple.Run(0);
            }
        }

        private void SampleReady(object obj)
        {
            DpSdkEngLib.FPSample pic = (DpSdkEngLib.FPSample)obj;
            pic.PictureOrientation = DpSdkEngLib.AIOrientation.Or_Portrait;
            pic.PictureWidth = Microsoft.VisualBasic.Compatibility.VB6.Support.PixelsToTwipsX(pictureBox1.Width) / Microsoft.VisualBasic.Compatibility.VB6.Support.TwipsPerPixelX();
            pic.PictureHeight = Microsoft.VisualBasic.Compatibility.VB6.Support.PixelsToTwipsY(pictureBox1.Height) / Microsoft.VisualBasic.Compatibility.VB6.Support.TwipsPerPixelY();
            pictureBox1.Image = Microsoft.VisualBasic.Compatibility.VB6.Support.IPictureDispToImage(pic.Picture);
            pictureBox1.Refresh();
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            verifyTemple.Cancel();
            verifyTemple = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verifyTemple.Done += new DPSDKOPSLib._IFPGetTemplateEvents_DoneEventHandler(VerifyDone);
            verifyTemple.SampleReady += new DPSDKOPSLib._IFPGetTemplateEvents_SampleReadyEventHandler(SampleReady);
            verifyTemple.Run(0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}