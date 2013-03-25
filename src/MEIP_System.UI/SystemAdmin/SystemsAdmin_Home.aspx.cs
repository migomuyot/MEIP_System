using System;
using System.Data;
using System.Web.UI.WebControls;

namespace MEIP_System.UI.SystemAdministrator
{
    public partial class SystemsAdmin_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewAuditTrail requestviewaudit = new RequestViewAuditTrail();
            DataTable dt = DAT.ViewAuditTrail(requestviewaudit);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {

        }
}
}