using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_ViewFamilyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewFamilyInfo requestViewFamilyInfo = new RequestViewFamilyInfo();
            requestViewFamilyInfo.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewFamilyInfo(requestViewFamilyInfo);
            GridViewFamilyInfo.DataSource = dt;
            GridViewFamilyInfo.DataBind();

            RequestViewSiblingInfo requestViewSiblingInfo = new RequestViewSiblingInfo();
            requestViewSiblingInfo.Username = Session["Username"].ToString();
            DataTable dt2 = DAT.ViewSiblingInfo(requestViewSiblingInfo);
            GridViewSiblingInfo.DataSource = dt2;
            GridViewSiblingInfo.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestUpdateFamilyInfo requestUpdateFamilyInfo = new RequestUpdateFamilyInfo();
            requestUpdateFamilyInfo.Username = Session["Username"].ToString();
            requestUpdateFamilyInfo.FamilyInfoID = int.Parse(txtFamilyInfoID.Text);
            requestUpdateFamilyInfo.FatherFName = txtFatherFName.Text;
            requestUpdateFamilyInfo.FatherLName = txtFatherLName.Text;
            requestUpdateFamilyInfo.FatherContactNum = txtFatherCNum.Text;
            requestUpdateFamilyInfo.MotherFName = txtMotherFName.Text;
            requestUpdateFamilyInfo.MotherLName = txtMotherLName.Text;
            requestUpdateFamilyInfo.MotherContactNum = txtMotherCNum.Text;

            DAT.UpdateFamilyInfo(requestUpdateFamilyInfo);
            Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            RequestUpdateSiblingInfo requestUpdateSiblingInfo = new RequestUpdateSiblingInfo();
            requestUpdateSiblingInfo.Username = Session["Username"].ToString();
            requestUpdateSiblingInfo.SiblingID = int.Parse(txtSiblingID.Text);
            requestUpdateSiblingInfo.SiblingFName = txtSiblingFName.Text;
            requestUpdateSiblingInfo.SiblingLName = txtSiblingLName.Text;
            requestUpdateSiblingInfo.SiblingContactNum = txtSiblingContactNum.Text;

            DAT.UpdateSiblingInfo(requestUpdateSiblingInfo);
            Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            RequestAddSiblingInfo requestAddSibling = new RequestAddSiblingInfo();
            requestAddSibling.Username = Session["Username"].ToString();
            requestAddSibling.SiblingFName = txtSiblingFName.Text;
            requestAddSibling.SiblingLName = txtSiblingLName.Text;
            requestAddSibling.SiblingContactNum = txtSiblingContactNum.Text;

            DAT.AddSiblingInfo(requestAddSibling);
            Response.Write("<script language='javascript'>alert('Added Successful!.')</script>");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}