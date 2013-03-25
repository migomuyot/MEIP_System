using System;
using System.Data;

namespace MEIP_System.UI.EmployeeSelfService
{
    public partial class EmployeeSelf_EmployeeTimeChangeRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestRetrieveAttendanceRecords request = new RequestRetrieveAttendanceRecords();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.RetrieveDTR(request);
            GridViewDTR.DataSource = dt;
            GridViewDTR.DataBind();

            RequestViewTimeChangeRequest request2 = new RequestViewTimeChangeRequest();
            request2.Username = Session["Username"].ToString();
            DataTable dt2 = DAT.ViewTimeChangeRequest(request2);
            GridViewTimeChange.DataSource = dt2;
            GridViewTimeChange.DataBind();
        }

        protected void GridViewTimeChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRequestID.Text = GridViewTimeChange.SelectedRow.Cells[1].Text;
            txtDateApplied.Text = GridViewTimeChange.SelectedRow.Cells[2].Text;
            txtAttendanceDateChange.Text = GridViewTimeChange.SelectedRow.Cells[3].Text;
            txtTimeInChange.Text = GridViewTimeChange.SelectedRow.Cells[4].Text;
            txtTimeChangeOut.Text = GridViewTimeChange.SelectedRow.Cells[5].Text;
            txtReason.Text = GridViewTimeChange.SelectedRow.Cells[6].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestTimeChangeRequest request = new RequestTimeChangeRequest();
            request.Username = Session["Username"].ToString();
            request.AttendanceDateChange = txtAttendanceDateChange.Text;
            request.TimeInChange = txtTimeInChange.Text;
            request.TimeOutChange = txtTimeChangeOut.Text;
            request.Reason = txtReason.Text;

            DAT.TimeChangeRequest(request);
            Response.Write("<script language='javascript'>alert('Successfully Added Request!.')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RequestUpdateTimeChangeRequest request = new RequestUpdateTimeChangeRequest();
            request.Username = Session["Username"].ToString();
            request.RequestID = int.Parse(txtRequestID.Text);
            request.AttendanceDateChange = txtAttendanceDateChange.Text;
            request.TimeChangeIn = txtTimeInChange.Text;
            request.TimeChangeOut = txtTimeChangeOut.Text;
            request.Reason = txtReason.Text;

            DAT.UpdateTimeChangeRequest(request);
            Response.Write("<script language='javascript'>alert('Successfully Updated Request!.')</script>");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
}
}