using System;
using System.Data;

namespace MEIP_System.UI.Timekeeping
{
    public partial class Timekeeping_SearchEmployeeAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestRetrieveAttendanceRecords request = new RequestRetrieveAttendanceRecords();
            request.Username = txtUsername.Text;
            DataTable dt =  DAT.RetrieveDTR(request);
            GridViewDTR.DataSource = dt;
            GridViewDTR.DataBind();
        }
    }
}