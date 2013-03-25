using System;

namespace MEIP_System.UI.Employee
{
    public partial class Employee_AddWorkExperience : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddWorkExperience_Click(object sender, EventArgs e)
        {
            RequestAddWorkExperience request = new RequestAddWorkExperience();
            request.Username = Session["Username"].ToString();
            request.YearStarted = int.Parse(txtYearStarted.Text);
            request.YearEnded = int.Parse(txtYearEnded.Text);
            request.Company = txtCompany.Text;
            request.ExpPosition = txtExpPosition.Text;

            try
            {
                DAT.AddWorkExperience(request);
                Response.Write("<script language='javascript'>alert('Successfully Added Work Experience Information!.')</script>");
                Response.Redirect("Employee_ViewWorkExperience.aspx");
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('Failed to Add!.')</script>");
            }
        }
    }
}