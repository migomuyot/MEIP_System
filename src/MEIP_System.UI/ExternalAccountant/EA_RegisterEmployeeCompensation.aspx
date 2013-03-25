<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EA_RegisterEmployeeCompensation.aspx.cs" Inherits="MEIP_System.UI.ExternalAccountant.EA_RegisterEmployeeCompensation" %>

html xmlns="http://www.w3.org/1999/xhtml">
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
    <table  style="font-family: Arial, Helvetica, sans-serif" cellspacing="0">
    <tr>
        <td>User ID:</td>
        <td><asp:TextBox ID="txtUserID" CssClass="tb" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Basic Pay:</td>
        <td><asp:TextBox ID="txtBasicPay" CssClass="tb" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button ID="ButtonAddEmployeeCompensation" CssClass="BlueButton" runat="server" 
                Text="Register Compensation" onclick="ButtonAddEmployeeCompensation_Click" /></td>
    </tr>
    </table>
    <br />
    </div><!--end of wokring Area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
