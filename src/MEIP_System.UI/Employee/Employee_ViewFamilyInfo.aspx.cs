using System;
using System.Data;

namespace MEIP_System.UI.Employee
{
    public partial class Employee_ViewFamilyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewFamilyInfo request = new RequestViewFamilyInfo();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewFamilyInfo(request);
            GridViewFamilyInfo.DataSource = dt;
            GridViewFamilyInfo.DataBind();

            RequestViewSiblingInfo request2 = new RequestViewSiblingInfo();
            request2.Username = Session["Username"].ToString();
            DataTable dt2 = DAT.ViewSiblingInfo(request2);
            GridViewSiblingInfo.DataSource = dt2;
            GridViewSiblingInfo.DataBind();
        }

        protected void GridViewFamilyInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFamilyInfoID.Text = GridViewFamilyInfo.SelectedRow.Cells[1].Text;
            txtFatherFName.Text = GridViewFamilyInfo.SelectedRow.Cells[2].Text;
            txtFatherLName.Text = GridViewFamilyInfo.SelectedRow.Cells[3].Text;
            txtFatherCNum.Text = GridViewFamilyInfo.SelectedRow.Cells[4].Text;
            txtMotherFName.Text = GridViewFamilyInfo.SelectedRow.Cells[5].Text;
            txtMotherLName.Text = GridViewFamilyInfo.SelectedRow.Cells[6].Text;
            txtMotherCNum.Text = GridViewFamilyInfo.SelectedRow.Cells[7].Text;
        }

        protected void GridViewSiblingInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSiblingID.Text = GridViewSiblingInfo.SelectedRow.Cells[1].Text;
            txtSiblingFName.Text = GridViewSiblingInfo.SelectedRow.Cells[2].Text;
            txtSiblingLName.Text = GridViewSiblingInfo.SelectedRow.Cells[3].Text;
            txtSiblingContactNum.Text = GridViewSiblingInfo.SelectedRow.Cells[4].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestUpdateFamilyInfo request = new RequestUpdateFamilyInfo();
            request.Username = Session["Username"].ToString();
            request.FamilyInfoID = int.Parse(txtFamilyInfoID.Text);
            request.FatherFName = txtFatherFName.Text;
            request.FatherLName = txtFatherLName.Text;
            request.FatherContactNum = txtFatherCNum.Text;
            request.MotherFName = txtMotherFName.Text;
            request.MotherLName = txtMotherLName.Text;
            request.MotherContactNum = txtMotherCNum.Text;

            DAT.UpdateFamilyInfo(request);
            Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            RequestUpdateSiblingInfo request = new RequestUpdateSiblingInfo();
            request.Username = Session["Username"].ToString();
            request.SiblingID = int.Parse(txtSiblingID.Text);
            request.SiblingFName = txtSiblingFName.Text;
            request.SiblingLName = txtSiblingLName.Text;
            request.SiblingContactNum = txtSiblingContactNum.Text;

            DAT.UpdateSiblingInfo(request);
            Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            RequestAddSiblingInfo request = new RequestAddSiblingInfo();
            request.Username = Session["Username"].ToString();
            request.SiblingFName = txtSiblingFName.Text;
            request.SiblingLName = txtSiblingLName.Text;
            request.SiblingContactNum = txtSiblingContactNum.Text;

            DAT.AddSiblingInfo(request);
            Response.Write("<script language='javascript'>alert('Added Successful!.')</script>");
        }
        protected void txtMotherFName_TextChanged(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}