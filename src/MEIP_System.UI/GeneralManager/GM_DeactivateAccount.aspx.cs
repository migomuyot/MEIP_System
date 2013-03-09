using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_DeactivateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DAT.ViewUsers();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestDeactivateAccount requestDeactivate = new RequestDeactivateAccount();
            requestDeactivate.UserID = int.Parse(txtID.Text);
            requestDeactivate.Username = Session["Username"].ToString();
            DataTable dt = DAT.DeactivateAccount(requestDeactivate);

            DataTable UpdateGrid = DAT.ViewUsers();
            GridView1.DataSource = UpdateGrid;
            GridView1.DataBind();

            Label2.Text = "*Account Deactivated*";
            Label2.Visible = true;
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txtID.Text = GridView1.SelectedRow.Cells[2].Text;
            txtFullName.Text = GridView1.SelectedRow.Cells[3].Text;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            RequestActivateAccount requestActivate = new RequestActivateAccount();
            requestActivate.UserID = int.Parse(txtID.Text);
            requestActivate.Username = Session["Username"].ToString();
            DataTable dt = DAT.ActivateAccount(requestActivate);

            DataTable UpdateGrid = DAT.ViewUsers();
            GridView1.DataSource = UpdateGrid;
            GridView1.DataBind();

            Label2.Text = "*Account Activated*";
            Label2.Visible = true;
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}