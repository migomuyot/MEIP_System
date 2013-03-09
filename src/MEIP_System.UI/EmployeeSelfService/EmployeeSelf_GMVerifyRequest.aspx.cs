using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MEIP_System.UI.EmployeeSelfService
{
    public partial class EmployeeSelf_GMVerifyRequest : System.Web.UI.Page
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


            //RequestViewAllRequest request = new RequestViewAllRequest();
            //request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewAllRequest();
            GridViewAllRequests.DataSource = dt;
            GridViewAllRequests.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestVerifyRequests request = new RequestVerifyRequests();
            request.RequestID = int.Parse(txtRequestID.Text);
            request.Username = Session["Username"].ToString();
            request.UserID = int.Parse(txtUserID.Text);
            request.Status = DropDownList1.SelectedItem.ToString();
            request.Remarks = txtRemarks.Text;

            DAT.VerifyRequest(request);
            Response.Write("<script language='javascript'>alert('Verified Request Successfully!.')</script>");
        }

        protected void GridViewAllRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRequestID.Text = GridViewAllRequests.SelectedRow.Cells[1].Text;
            txtUserID.Text = GridViewAllRequests.SelectedRow.Cells[10].Text;
            txtRequestType.Text = GridViewAllRequests.SelectedRow.Cells[2].Text;
            txtDateApplied.Text = GridViewAllRequests.SelectedRow.Cells[3].Text;
            txtStartDate.Text = GridViewAllRequests.SelectedRow.Cells[4].Text;
            txtEndDate.Text = GridViewAllRequests.SelectedRow.Cells[5].Text;
            txtAttendanceDateChange.Text = GridViewAllRequests.SelectedRow.Cells[6].Text;
            txtTimeChangeIn.Text = GridViewAllRequests.SelectedRow.Cells[7].Text;
            txtTimeChangeOut.Text = GridViewAllRequests.SelectedRow.Cells[8].Text;
            txtLeaveType.Text = GridViewAllRequests.SelectedRow.Cells[2].Text;
            txtReason.Text = GridViewAllRequests.SelectedRow.Cells[11].Text;
        }
}
}