using System;
using System.Data;
using MEIP_System;

namespace MEIP_System.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable d12 = new DataTable();
            RequestLogin requestlogin = new RequestLogin(TextBoxUsername.Text.Trim(), TextBoxPassword.Text.Trim());
            DataTable dt = DAT.Login(requestlogin);

            if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.GeneralManager).ToString() && dt.Rows[0]["AccountStatus"].ToString() != "Deactivated")
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("GeneralManager/GM_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.Employee).ToString() && dt.Rows[0]["AccountStatus"].ToString() != "Deactivated")
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("Employee/Employee_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.ExternalAccountant).ToString() && dt.Rows[0]["AccountStatus"].ToString() != "Deactivated")
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("ExternalAccountant/EA_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.Administrator).ToString() && dt.Rows[0]["AccountStatus"].ToString() != "Deactivated")
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("/SystemAdmin/SystemsAdmin_Home.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.Programmer).ToString() && dt.Rows[0]["AccountStatus"].ToString() != "Deactivated")
            {
                Session.Add("Username", TextBoxUsername.Text.Trim());
                Response.Redirect("gumagana/yay.aspx");
            }
            else if (dt.Rows.Count == 1 && dt.Rows[0]["UserTypeID"].ToString() == ((int)Enum.UserType.Programmer).ToString() && dt.Rows[0]["AccountStatus"].ToString() == "Deactivated")
            {
                Label1.Text = "The status of your account is Deactivated.";
                Label1.Visible = true;
            }
            else
            {
                if (dt.Rows.Count == 1 && dt.Rows[0]["AccountStatus"].ToString() == "Deactivated")
                {
                    Label1.Text = "The status of your account is Deactivated.";
                    Label1.Visible = true;
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
}