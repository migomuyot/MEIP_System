using System;
using System.Data;

namespace MEIP_System.UI.Employee
{
    public partial class Employee_UpdateEducInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewEducInfo request = new RequestViewEducInfo(Session["Username"].ToString());
            DataTable dt = DAT.ViewEducInfo(request);

            if (!IsPostBack)
            {
                if (dt.Rows.Count == 0)
                {
                    Response.Redirect("GM_ViewEducInfo.aspx");
                }
                else
                {
                    txtGraduateSchool.Text = dt.Rows[0]["GraduateSchool"].ToString();
                    txtCourseTaken.Text = dt.Rows[0]["CourseTaken"].ToString();
                    txtYearGraduated.Text = dt.Rows[0]["YearGraduated"].ToString();
                }
            }
        }

        protected void ButtonUpdateEducInfo_Click(object sender, EventArgs e)
        {
            RequestUpdateEducationalInfo request = new RequestUpdateEducationalInfo();
            request.Username = Session["Username"].ToString();
            request.GraduateSchool = txtGraduateSchool.Text;
            request.CourseTaken = txtCourseTaken.Text;
            request.YearGraduated = txtYearGraduated.Text;

            try
            {
                DAT.UpdateEducInfo(request);
                Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
                Response.Redirect("Employee_ViewEducInfo.aspx");
            }
            catch
            {
                Response.Write("Update Failed!");
            }
            finally
            {
                txtGraduateSchool.Text = ""; txtCourseTaken.Text = ""; txtYearGraduated.Text = "";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGraduateSchool.Text = GridViewEducInfo.SelectedRow.Cells[12].Text.Trim();
            txtCourseTaken.Text = GridViewEducInfo.SelectedRow.Cells[13].Text.Trim();
            txtYearGraduated.Text = GridViewEducInfo.SelectedRow.Cells[14].Text.Trim();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GM_UpdateEducInfo.aspx");
        }
}
}