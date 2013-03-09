using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DPSDKOPSLib;
using System.Collections.Generic;
namespace MEIP_System.BiometricRegistration
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private FPRegisterTemplateClass rgs = new FPRegisterTemplateClass();
        public object pRegTmplate = 0;
        int empid = 0, count = 0;
        private void SampleReady(object obj)
        {
            DpSdkEngLib.FPSample pic = (DpSdkEngLib.FPSample)obj;
            pic.PictureOrientation = DpSdkEngLib.AIOrientation.Or_Portrait;
            pic.PictureWidth = Microsoft.VisualBasic.Compatibility.VB6.Support.PixelsToTwipsX(pictureBox1.Width) / Microsoft.VisualBasic.Compatibility.VB6.Support.TwipsPerPixelX();
            pic.PictureHeight = Microsoft.VisualBasic.Compatibility.VB6.Support.PixelsToTwipsY(pictureBox1.Height) / Microsoft.VisualBasic.Compatibility.VB6.Support.TwipsPerPixelY();
            if (count == 0)
            {
                pictureBox1.Image = Microsoft.VisualBasic.Compatibility.VB6.Support.IPictureDispToImage(pic.Picture);
                pictureBox1.Refresh();
                labelStatus.Text = "Enter 2nd fingerprint";
                labelStatus.Refresh();
            }
            if (count == 1)
            {
                pictureBox2.Image = Microsoft.VisualBasic.Compatibility.VB6.Support.IPictureDispToImage(pic.Picture);
                pictureBox2.Refresh();
                labelStatus.Text = "Enter 3rd fingerprint";
                labelStatus.Refresh();
            }
            if (count == 2)
            {
                pictureBox3.Image = Microsoft.VisualBasic.Compatibility.VB6.Support.IPictureDispToImage(pic.Picture);
                pictureBox3.Refresh();
                labelStatus.Text = "Enter 4th fingerprint";
                labelStatus.Refresh();
            }
            if (count == 3)
            {
                pictureBox4.Image = Microsoft.VisualBasic.Compatibility.VB6.Support.IPictureDispToImage(pic.Picture);
                pictureBox4.Refresh();
                labelStatus.Text = "Remove finger from device";
                labelStatus.Refresh();
            }
            count++;
        }
        private void RegDone(object obj)
        {
            DpSdkEngLib.FPTemplate tmplate = (DpSdkEngLib.FPTemplate)obj;
            tmplate.Export(ref pRegTmplate);
            MessageBox.Show("Finger Print Completed");
            buttonRegister.Enabled = true;
        }
        private void buttonStartBiometric_Click(object sender, EventArgs e)
        {
            rgs.SampleReady += new DPSDKOPSLib._IFPRegisterTemplateEvents_SampleReadyEventHandler(SampleReady);
            rgs.Done += new DPSDKOPSLib._IFPRegisterTemplateEvents_DoneEventHandler(RegDone);
            buttonStartBiometric.Enabled = false;
            rgs.Run(1);
            labelStatus.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonRegister.Enabled = false;
            List<string> UID = DAT_Biometric.ViewUsers();
            foreach (string userID in UID)
            {
                comboBox1.Items.Add(userID);
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (DAT_Biometric.Register(comboBox1.Text) == 0)
                {
                    MessageBox.Show("Please input a valid Employee ID.");
                }
                else
                {
                    if (DAT_Biometric.ValidationOfExistingFingerprints(comboBox1.Text) == 4)
                    {
                        MessageBox.Show("Your fingerprint is already registered!");
                        pictureBox1.Image.Dispose(); pictureBox1.Update();
                    }
                    else
                    {
                        empid = int.Parse(comboBox1.Text);
                        //insert record
                        byte[] data1 = ConvertToBytes(pictureBox1);
                        DAT_Biometric.RegisterFirstFingerprint(comboBox1.Text, data1, pRegTmplate);

                        byte[] data2 = ConvertToBytes(pictureBox2);
                        DAT_Biometric.RegisterFirstFingerprint(comboBox1.Text, data2, pRegTmplate);
                        
                        byte[] data3 = ConvertToBytes(pictureBox3);
                        DAT_Biometric.RegisterFirstFingerprint(comboBox1.Text, data3, pRegTmplate);
                        
                        byte[] data4 = ConvertToBytes(pictureBox4);
                        DAT_Biometric.RegisterFirstFingerprint(comboBox1.Text, data4, pRegTmplate);

                        MessageBox.Show("Registration Completed");
                        pictureBox1.Image.Dispose();
                        pictureBox2.Image.Dispose();
                        pictureBox3.Image.Dispose();
                        pictureBox4.Image.Dispose();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                pictureBox1.Image.Dispose();
                pictureBox2.Image.Dispose();
                pictureBox3.Image.Dispose();
                pictureBox4.Image.Dispose();
            }
        }
        public byte[] ConvertToBytes(PictureBox pic)
        {
            MemoryStream ms = new MemoryStream();
            pic.Image.Save(ms, ImageFormat.Bmp);
            byte[] data;
            data = ms.ToArray();
            ms.Close();
            return data;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}