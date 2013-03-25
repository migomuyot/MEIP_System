using System;

namespace MEIP_System.UI.ExternalAccountant
{
    public partial class EA_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ExternalAccountant/EA_ComputePayroll.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ExternalAccountant/EA_RegisterEmployeeCompensation.aspx");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx"); 
        }
}
}