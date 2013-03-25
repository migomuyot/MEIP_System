using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewGeneralInfo requestViewGeneralInfo = new RequestViewGeneralInfo();
            requestViewGeneralInfo.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewGeneralInfo(requestViewGeneralInfo);

            LabelFName.Text = dt.Rows[0]["FName"].ToString();
            LabelLName.Text = dt.Rows[0]["LName"].ToString();
            LabelMName.Text = dt.Rows[0]["MName"].ToString();
            LabelNickname.Text = dt.Rows[0]["Nickname"].ToString();
            LabelGender.Text = dt.Rows[0]["Gender"].ToString();
            LabelDOB.Text = dt.Rows[0]["DOB"].ToString();
            LabelCivilStatus.Text = dt.Rows[0]["CivilStatus"].ToString();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}