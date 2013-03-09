using System;
using System.Data;

namespace MEIP_System.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            //LOL
            DataTable d12 = new DataTable();
            RequestLogin request = new RequestLogin(TextBoxUsername.Text.Trim(), TextBoxPassword.Text.Trim());
            DataTable dt = DAT.Login(request);
            
            /*((int)Enum.UserType.______) converts the string into INT*/
            /*ENUM = */
            if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.GeneralManager).ToString())
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("GeneralManager/GM_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.Employee).ToString())
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("Employee/Employee_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.ExternalAccountant).ToString())
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("ExternalAccountant/EA_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.Administrator).ToString())
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("Administrator/Admin_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.Programmer).ToString())
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("gumagana/yay.aspx");
            }
            else
            {
                Label1.Text = "Invalid Login";
                Label1.Visible = true;
                //Response.Write("<script language='javascript'>alert('Invalid Login')</script>");
            }
        }
    }
}
