using System;
using System.Data;

namespace MEIP_System.UI.Timekeeping
{
    public partial class Timekeeping_AddTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DAT.ViewTask();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void ButtonTask_Click(object sender, EventArgs e)
        {
            RequestAddTask request = new RequestAddTask();
            DataTable dt = new DataTable();

            request.UserID = DropDownListEmployee.Text;
            request.Task = txtTasks.Text;
            request.TaskDate = CalendarTaskDate.SelectedDate.ToString();

            try
            {
                DAT.AddTask(request);
                Response.Write("<script language='javascript'>alert('Added Task Successfully!.')</script>");
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('Added Task Failed!.')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestUpdateTask request = new RequestUpdateTask();
            request.NotifID = txtNotificationID.Text;
            request.UserID = int.Parse(txtEmployee.Text);
            request.Task = txtTasks.Text;
            request.TaskDate = txtDate.Text;

                DAT.UpdateTask(request);
                Response.Write("<script language='javascript'>alert('Update Successful!.')</script>");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNotificationID.Text = GridView1.SelectedRow.Cells[1].Text;
            txtEmployee.Text = GridView1.SelectedRow.Cells[2].Text;
            txtTasks.Text = GridView1.SelectedRow.Cells[3].Text;
            txtDate.Text = GridView1.SelectedRow.Cells[4].Text;
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
}
}