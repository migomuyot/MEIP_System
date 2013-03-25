<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EA_Home.aspx.cs" Inherits="MEIP_System.UI.ExternalAccountant.EA_Home" %>

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
            <table>
            <tr><td>
                <asp:Button ID="Button1" CssClass="BlueButton" runat="server" Text="Compute Payroll" 
                    Width="132px" onclick="Button1_Click" /></td>
            <td></td>
            <td></td>
            <td><asp:Button ID="Button2" CssClass="BlueButton" runat="server" 
                    Text="Register Employee Compensation" onclick="Button2_Click" Width="279px" /></td>
                    </tr>

                    </table>
            </center>
            <br />
    </center>
    </div><!--end of wokring Area-->
    </div><!--end of container-->
    </form>
</body>
</html>
