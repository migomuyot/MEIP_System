using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_UpdateContactInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewContactInfo requestViewContactInfo = new RequestViewContactInfo(Session["Username"].ToString());
            DataTable dt = DAT.ViewContactInfo(requestViewContactInfo);

            if (!IsPostBack)
            {
                if (dt.Rows.Count == 0)
                {
                    Response.Redirect("GM_ViewContactInfo.aspx");
                }
                else
                {
                    txtHomeNum.Text = dt.Rows[0]["HomeNum"].ToString();
                    txtCellphoneNum.Text = dt.Rows[0]["CellphoneNum"].ToString();
                    txtHomeAddress.Text = dt.Rows[0]["HomeAddress"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                }
            }

        }

        protected void ButtonUpdateContactInfo_Click(object sender, EventArgs e)
        {

            RequestUpdateContactInfo requestUpdateContactInfo = new RequestUpdateContactInfo();
            requestUpdateContactInfo.Username = Session["Username"].ToString();
            requestUpdateContactInfo.HomeNum = txtHomeNum.Text;
            requestUpdateContactInfo.CellphoneNum = txtCellphoneNum.Text;
            requestUpdateContactInfo.HomeAddress = txtHomeAddress.Text;
            requestUpdateContactInfo.Email = txtEmail.Text;

            try
            {
                DAT.UpdateContactInfo(requestUpdateContactInfo);
                Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
                Response.Redirect("GM_ViewContactInfo.aspx");
            }
            catch
            {
                Response.Write("Update Failed!");
            }
            finally
            {
                txtHomeNum.Text = ""; txtCellphoneNum.Text = ""; txtHomeAddress.Text = ""; txtEmail.Text = "";
            }
        }

        protected void GridViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHomeNum.Text = GridViewUsers.SelectedRow.Cells[16].Text.Trim();
            txtCellphoneNum.Text = GridViewUsers.SelectedRow.Cells[17].Text.Trim();
            txtHomeAddress.Text = GridViewUsers.SelectedRow.Cells[15].Text.Trim();
            txtEmail.Text = GridViewUsers.SelectedRow.Cells[18].Text.Trim();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}