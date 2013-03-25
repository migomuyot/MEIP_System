using System;
using System.Data;
using System.Web.UI.WebControls;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_SearchEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            RequestSearchEmployees requestSearch = new RequestSearchEmployees();
            requestSearch.LName = txtSearchEmployee.Text;
            DataTable dt = DAT.SearchEmployees(requestSearch);
            grdSearchEmployee.DataSource = dt;
            grdSearchEmployee.DataBind();
        }

        protected void grdSearchEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdSearchEmployee.PageIndex = e.NewPageIndex;
            grdSearchEmployee.DataBind();

        }
        protected void grdSearchEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
}
}