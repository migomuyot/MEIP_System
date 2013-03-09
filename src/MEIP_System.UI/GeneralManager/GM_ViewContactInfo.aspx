<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.GeneralManager.GM_ViewContactInfo" CodeFile="GM_ViewContactInfo.aspx.cs" %>

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
    <td>Telephone Number:</td>
    <td><asp:Label ID="LabelHomeNum" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Cellphone Number:</td>
    <td><asp:Label ID="LabelCellphoneNum" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Address:</td>
    <td><asp:Label ID="LabelHomeAddress" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Email:</td>
    <td><asp:Label ID="LabelEmail" runat="server" Text="Label"></asp:Label></td>
    </tr>
    </table>
    <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Edit Information" CssClass="BlueButton" />
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
