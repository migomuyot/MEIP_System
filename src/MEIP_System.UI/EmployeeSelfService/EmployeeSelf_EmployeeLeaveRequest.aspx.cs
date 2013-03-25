using System;
using System.Data;

namespace MEIP_System.UI.EmployeeSelfService
{
    public partial class EmployeeSelf_ViewLeaveRequest : System.Web.UI.Page
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

            RequestViewLeaveRequest request = new RequestViewLeaveRequest();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewLeaveRequest(request);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txtRequestID.Text = GridView1.SelectedRow.Cells[1].Text;
            txtStartDate.Text = GridView1.SelectedRow.Cells[3].Text;
            txtEndDate.Text = GridView1.SelectedRow.Cells[4].Text;
            txtLeaveType.Text = GridView1.SelectedRow.Cells[5].Text;
            txtReason.Text = GridView1.SelectedRow.Cells[6].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RequestUpdateLeaveRequest request = new RequestUpdateLeaveRequest();
            request.Username = Session["Username"].ToString();
            request.RequestID = int.Parse(txtRequestID.Text);
            request.StartDate = CalendarStartDate.SelectedDate.ToString();
            request.EndDate = CalendarEndDate.SelectedDate.ToString();
            request.LeaveType = DropDownLeaveTypes.SelectedItem.ToString();
            request.Reason = txtReason.Text;

            DAT.UpdateLeaveRequest(request);
            Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Employee/Employee_Home.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            RequestLeaveRequest request = new RequestLeaveRequest();
            request.Username = Session["Username"].ToString();
            request.StartDate = CalendarStartDate.SelectedDate.ToString();
            request.EndDate = CalendarEndDate.SelectedDate.ToString();
            request.LeaveType = DropDownLeaveTypes.SelectedItem.ToString();
            request.Reason = txtReason.Text;

            DAT.LeaveRequest(request);
            Response.Write("<script language='javascript'>alert('Successfully Added Request!.')</script>");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
}
}