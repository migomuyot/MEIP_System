using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_AddUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTable dt = DAT.ViewUsers();
            //GridViewAddEmployee.DataSource = dt;
            GridViewAddEmployee.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RequestAddUser request = new RequestAddUser();
            request.LName = txtLName.Text;
            request.FName = txtFName.Text;
            request.Nickname = txtNickname.Text;
            request.MName = txtMName.Text;
            request.DOB = CalendarDOB.SelectedDate.ToString();
            request.CivilStatus = DropDownListCivilStatus.Text;
            request.Gender = DropDownListGender.Text;
            request.Username = txtUsername.Text;
            request.Password = txtPassword.Text;
            
            try
            {
                DAT.AddUser(request);
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
}
}