using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_UpdateContactInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewContactInfo request = new RequestViewContactInfo(Session["Username"].ToString());
            DataTable dt = DAT.ViewContactInfo(request);

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

            RequestUpdateContactInfo request = new RequestUpdateContactInfo();
            request.Username = Session["Username"].ToString();
            request.HomeNum = txtHomeNum.Text;
            request.CellphoneNum = txtCellphoneNum.Text;
            request.HomeAddress = txtHomeAddress.Text;
            request.Email = txtEmail.Text;

            try
            {
                DAT.UpdateContactInfo(request);
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