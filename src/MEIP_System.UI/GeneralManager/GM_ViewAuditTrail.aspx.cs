using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_ViewAuditTrail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewAuditTrail requestviewaudit = new RequestViewAuditTrail();
            DataTable dt = DAT.ViewAuditTrail(requestviewaudit);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
    
        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();
        }
}
}