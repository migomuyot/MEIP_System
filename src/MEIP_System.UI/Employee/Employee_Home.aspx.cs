using System;
using System.Data;

namespace MEIP_System.UI.Employee
{
    public partial class Employee_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewGeneralInfo request = new RequestViewGeneralInfo();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewGeneralInfo(request);

            LabelFName.Text = dt.Rows[0]["FName"].ToString();
            LabelLName.Text = dt.Rows[0]["LName"].ToString();
            LabelMName.Text = dt.Rows[0]["MName"].ToString();
            LabelNickname.Text = dt.Rows[0]["Nickname"].ToString();
            LabelGender.Text = dt.Rows[0]["Gender"].ToString();
            LabelDOB.Text = dt.Rows[0]["DOB"].ToString();
            LabelCivilStatus.Text = dt.Rows[0]["CivilStatus"].ToString();
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("../Login.aspx");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");

        }
}
}