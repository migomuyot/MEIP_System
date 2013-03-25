using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_ViewCompanyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewCompanyInfo requestViewCompanyInfo = new RequestViewCompanyInfo();
            requestViewCompanyInfo.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewCompanyInfo(requestViewCompanyInfo);

            if (dt.Rows.Count > 0)
            {
                LabelDateHired.Text = dt.Rows[0]["DateHired"].ToString();
                LabelPosition.Text = dt.Rows[0]["Position"].ToString();
            }
            else
            {
                Response.Write("Please Inform General Manager about your Company Information");
            }

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}