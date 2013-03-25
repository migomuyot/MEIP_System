<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SystemsAdmin_Home.aspx.cs" Inherits="MEIP_System.UI.SystemAdministrator.SystemsAdmin_Home" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="../CSS/Style.css" rel="stylesheet" type="text/css" />
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
    <div id="header"></div>
        <div id="nav_bar">
			 <ul>
				<li><a href="#">Home</a></li>
				<li><a href="#">Need Help</a></li>
               <li style="float:right;"><asp:LinkButton ID="LinkButton1" runat="server" 
                       onclick="LinkButton1_Click">LOGOUT</asp:LinkButton></li>
                  </ul>
			</div><!--end of nav-->
            <div id="container">
            <div id="Container_Admin">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <center>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="True"
                    onpageindexchanging="GridView1_PageIndexChanging1" GridLines="None" 
CssClass="mGrid" 
PagerStyle-CssClass="pgr" 
AlternatingRowStyle-CssClass="alt" Height="228px" Width="370px">
                </asp:GridView>
                </center>
                
            </div><!--end of Admin_container-->
     </div><!--end of container-->
      <div id="footer">Medmar copyright 2013 Development Team: AAFP</div><!--end of footer-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
