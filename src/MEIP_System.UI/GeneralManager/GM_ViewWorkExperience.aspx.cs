using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_ViewWorkExperience : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session["Username"].ToString();
            }
            catch
            {
                Response.Redirect("../Login.aspx");
            }

            RequestViewWorkExperience requestViewWorkExperience = new RequestViewWorkExperience();
            requestViewWorkExperience.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewWorkExperience(requestViewWorkExperience);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtWorkExperienceID.Text = GridView1.SelectedRow.Cells[1].Text;
            txtYearStarted.Text = GridView1.SelectedRow.Cells[2].Text;
            txtYearEnded.Text = GridView1.SelectedRow.Cells[3].Text;
            txtCompany.Text = GridView1.SelectedRow.Cells[4].Text;
            txtExpPosition.Text = GridView1.SelectedRow.Cells[5].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestUpdateWorkExperience requestUpdateWorkExperience = new RequestUpdateWorkExperience();
            requestUpdateWorkExperience.Username = Session["Username"].ToString();
            requestUpdateWorkExperience.WorkExperienceID = int.Parse(txtWorkExperienceID.Text);
            requestUpdateWorkExperience.YearStarted = int.Parse(txtYearStarted.Text);
            requestUpdateWorkExperience.YearEnded = int.Parse(txtYearEnded.Text);
            requestUpdateWorkExperience.Company = txtCompany.Text;
            requestUpdateWorkExperience.ExpPosition = txtExpPosition.Text;

            DAT.UpdateWorkExperience(requestUpdateWorkExperience);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../GeneralManager/GM_Home.aspx");
            Response.Write("Update Successful");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            RequestAddWorkExperience requestAddWorkExperience = new RequestAddWorkExperience();
            requestAddWorkExperience.Username = Session["Username"].ToString();
            requestAddWorkExperience.YearStarted = int.Parse(txtYearStarted.Text);
            requestAddWorkExperience.YearEnded = int.Parse(txtYearEnded.Text);
            requestAddWorkExperience.Company = txtCompany.Text;
            requestAddWorkExperience.ExpPosition = txtExpPosition.Text;

            DAT.AddWorkExperience(requestAddWorkExperience);

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}