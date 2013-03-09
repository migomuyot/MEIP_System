using System;
using System.Data;

namespace MEIP_System.UI.Employee
{
    public partial class Employee_ViewGovtInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewGovtInfo request = new RequestViewGovtInfo();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewGovtInfo(request);

            if (dt.Rows.Count > 0)
            {
                LabelTIN.Text = dt.Rows[0]["TIN"].ToString();
                LabelSSS.Text = dt.Rows[0]["SSS"].ToString();
                LabelPhilHealth.Text = dt.Rows[0]["PhilHealth"].ToString();
                LabelPagibig.Text = dt.Rows[0]["Pagibig"].ToString();
            }
            else
            {
                Response.Write("<script>alert('Hello');</script>");
                Response.Redirect("Employee_UpdateGovtInfo.aspx");
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}