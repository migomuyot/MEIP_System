using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_ViewContactInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewContactInfo request = new RequestViewContactInfo();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewContactInfo(request);

            if (dt.Rows.Count > 0)
            {
                LabelHomeNum.Text = dt.Rows[0]["HomeNum"].ToString();
                LabelCellphoneNum.Text = dt.Rows[0]["CellphoneNum"].ToString();
                LabelHomeAddress.Text = dt.Rows[0]["HomeAddress"].ToString();
                LabelEmail.Text = dt.Rows[0]["Email"].ToString();
            }
            else
            {
                Response.Redirect("GM_UpdateContactInfo.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GM_UpdateContactInfo.aspx");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}