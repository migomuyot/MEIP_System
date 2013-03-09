using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_SearchEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            RequestSearchEmployees RequestSearch = new RequestSearchEmployees();
            RequestSearch.LName = txtSearchEmployee.Text;
            DataTable dt = DAT.SearchEmployees(RequestSearch);
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
    }
}