<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.Login" CodeFile="Login.aspx.cs" %>

<!DOCTYPE html /><!--HTML 5 version-->
<link href="CSS/Style.css" rel="stylesheet" type="text/css" />
<head><title>Employee Information Portal</title></head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
    <div id="container">
 <div id="LoginForm">
     <table align="center" cellspacing="3">
         <div align="center"><img src="Images/logo.png"  style="height: 78px; width: 217px;" /></div>
     <tr>
    <td><label>Username:</label><asp:TextBox ID="TextBoxUsername" CssClass="tb_login" runat="server" required/></asp:TextBox></td>
    </tr>
    <tr>
    <td><label>Password:</label><asp:TextBox ID="TextBoxPassword" CssClass="tb_login" runat="server" TextMode="Password" required/></asp:TextBox></td>
    </tr>
    </table>
    <div align="center">
    <asp:Button ID="Button1" runat="server" CssClass="BlueButton" onclick="Button1_Click" Text="Login" 
            Width="112px" />
            <br />
    <a href="#">Forgot Password?</a>
        <asp:Label ID="Label1" runat="server" ForeColor="#990000"></asp:Label>
        </div>
    </div><!--end of login form-->   
    <div id="footer">Medmar copyright 2013 Development Team: AAFP</div><!--end of footer-->
    </div>
    </div><!--end of wrapper-->
    </form>
</body>
</html>
