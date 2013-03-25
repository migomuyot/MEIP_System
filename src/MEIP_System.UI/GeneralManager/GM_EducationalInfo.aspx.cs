using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_EducationalInfo : System.Web.UI.Page
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

            RequestViewEducInfo requestViewEducInfo = new RequestViewEducInfo();
            requestViewEducInfo.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewEducInfo(requestViewEducInfo);

            GridViewEducInfo.DataSource = dt;
            GridViewEducInfo.DataBind();
        }

        protected void ButtonUpdateEducInfo_Click(object sender, EventArgs e)
        {
            RequestUpdateEducationalInfo requestUpdateEducInfo = new RequestUpdateEducationalInfo();
            requestUpdateEducInfo.Username = Session["Username"].ToString();
            requestUpdateEducInfo.EducInfoID = int.Parse(txtEducInfoID.Text);
            requestUpdateEducInfo.School = txtGraduateSchool.Text;
            requestUpdateEducInfo.Degree = DropDownList1.SelectedItem.ToString();
            requestUpdateEducInfo.Course = txtCourseTaken.Text;
            requestUpdateEducInfo.YearGraduated = int.Parse(txtYearGraduated.Text);

            DAT.UpdateEducInfo(requestUpdateEducInfo);
            Response.Write("<script language='javascript'>alert('Successfully Updated School!')</script>");
        }

        protected void ButtonAddEducInfo_Click(object sender, EventArgs e)
        {
            RequestAddEducInfo requestAddEducInfo = new RequestAddEducInfo();
            requestAddEducInfo.Username = Session["Username"].ToString();
            requestAddEducInfo.School = txtGraduateSchool.Text;
            requestAddEducInfo.Degree = DropDownList1.SelectedItem.ToString();
            requestAddEducInfo.Course = txtCourseTaken.Text;
            requestAddEducInfo.YearGraduated = int.Parse(txtYearGraduated.Text);

            DAT.AddEducInfo(requestAddEducInfo);
            Response.Write("<script language='javascript'>alert('Successfully Added School!')</script>");
        }
        protected void GridViewEducInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEducInfoID.Text = GridViewEducInfo.SelectedRow.Cells[1].Text;
            txtGraduateSchool.Text = GridViewEducInfo.SelectedRow.Cells[2].Text;
            txtDegree.Text = GridViewEducInfo.SelectedRow.Cells[3].Text;
            txtCourseTaken.Text = GridViewEducInfo.SelectedRow.Cells[4].Text;
            txtYearGraduated.Text = GridViewEducInfo.SelectedRow.Cells[5].Text;
        }
    }
}