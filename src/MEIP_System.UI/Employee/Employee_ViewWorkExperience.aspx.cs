﻿using System;
using System.Data;

namespace MEIP_System.UI.Employee
{
    public partial class Employee_ViewWorkExperience : System.Web.UI.Page
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

            RequestViewWorkExperience request = new RequestViewWorkExperience();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewWorkExperience(request);

            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                Response.Redirect("Employee_AddWorkExperience.aspx");
            }
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
            RequestUpdateWorkExperience request = new RequestUpdateWorkExperience();
            request.Username = Session["Username"].ToString();
            request.WorkExperienceID = int.Parse(txtWorkExperienceID.Text);
            request.YearStarted = int.Parse(txtYearStarted.Text);
            request.YearEnded = int.Parse(txtYearEnded.Text);
            request.Company = txtCompany.Text;
            request.ExpPosition = txtExpPosition.Text;

            DAT.UpdateWorkExperience(request);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Employee/Employee_Home.aspx");
            Response.Write("Update Successful");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee_AddWorkExperience.aspx");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}