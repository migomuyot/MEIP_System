<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employee_AddWorkExperience.aspx.cs" Inherits="MEIP_System.UI.Employee.Employee_AddWorkExperience" %>

<!DOCTYPE html >
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
    <div class="Side_bar">
    
    </div><!--end of side bar (leftside)-->
    <div class="Working_Area">
    <br />
    <b>Add Work Experience</b>   
    <table>
    <tr>
    <td>Date Started:</td>
    <td><asp:TextBox ID="txtYearStarted" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Date Ended:</td>
    <td><asp:TextBox ID="txtYearEnded" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Company:</td>
    <td><asp:TextBox ID="txtCompany" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Position:</td>
    <td><asp:TextBox ID="txtExpPosition" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td></td>
    <td>
        <asp:Button ID="ButtonAddWorkExperience" runat="server" CssClass="BlueButton" Text="Save Information" 
            onclick="ButtonAddWorkExperience_Click" />
        </td>
    <td></td>
    </tr>
    </table>
     <center>
     <div class="divider"></div>
     </center>
    </div>
    </div>
    </form>
</body>
</html>
