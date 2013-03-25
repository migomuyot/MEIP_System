using System;

namespace MEIP_System.UI.ExternalAccountant
{
    public partial class EA_RegisterEmployeeCompensation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddEmployeeCompensation_Click(object sender, EventArgs e)
        {
            RequestAddEmployeeCompensation request = new RequestAddEmployeeCompensation();
            request.UserID = int.Parse(txtUserID.Text);
            request.BasicPay = Convert.ToDouble(txtBasicPay.Text);

            DAT.RegisterEmployeeCompensation(request);
            Response.Write("<script language='javascript'>alert('Successfully Added Compensation!.')</script>");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
     }
}