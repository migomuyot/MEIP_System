using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_ViewEducInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewEducInfo request = new RequestViewEducInfo();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewEducInfo(request);

            if (dt.Rows.Count > 0)
            {
                LabelGraduateSchool.Text = dt.Rows[0]["GraduateSchool"].ToString();
                LabelCourseTaken.Text = dt.Rows[0]["CourseTaken"].ToString();
                LabelYearGraduated.Text = dt.Rows[0]["YearGraduated"].ToString();
            }
            else
            {
                Response.Redirect("GM_UpdateEducInfo.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GM_UpdateEducInfo.aspx");
            
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GM_UpdateEducInfo.aspx");
        }
}
}