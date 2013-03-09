<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.GeneralManager.GM_ViewCompanyInfo" CodeFile="GM_ViewCompanyInfo.aspx.cs" %>
<!DOCTYPE html >
<link href="../CSS/Style.css" rel="stylesheet" type="text/css" />
<head>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
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
    <div class="Side_bar"></div><!--end of side bar (leftside)-->
    <div class="Working_Area">
     <br />
    <center>
    <div class="divider"></div>
    </center>

<center>
    <table>
    <tr>
    <td>Date Hired:</td>
    <td><asp:Label ID="LabelDateHired" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td>Position:</td>
    <td><asp:Label ID="LabelPosition" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td></td>
    <td></td>
    <td></td>
    </tr>
    </table>
    </center>
           <center>
    <div class="divider"></div>
    </center>
    
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
