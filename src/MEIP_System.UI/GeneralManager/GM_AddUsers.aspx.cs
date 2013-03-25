using System;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_AddUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DAT.ViewUsers();
            GridViewAddEmployee.DataSource = dt;
            GridViewAddEmployee.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestAddUser requestAddUser = new RequestAddUser();
            requestAddUser.LName = txtLName.Text;
            requestAddUser.FName = txtFName.Text;
            requestAddUser.Nickname = txtNickname.Text;
            requestAddUser.MName = txtMName.Text;
            requestAddUser.DOB = CalendarDOB.SelectedDate.ToString();
            requestAddUser.CivilStatus = DropDownListCivilStatus.Text;
            requestAddUser.Gender = DropDownListGender.Text;
            requestAddUser.Username = txtUsername.Text;
            requestAddUser.Password = txtPassword.Text;

            try
            {
                DAT.AddUser(requestAddUser);
            }
            catch
            {
                Response.Write("Adding User Failed!");
            }
        }

        protected void ButtonAddUserBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("GM_Home.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }

        protected void CalendarDOB_SelectionChanged(object sender, EventArgs e)
        {

        }
}
}