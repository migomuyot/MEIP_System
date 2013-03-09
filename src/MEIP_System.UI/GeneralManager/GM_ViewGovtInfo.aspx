<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_ViewGovtInfo.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_ViewGovtInfo" %>

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
    <b>Government Identification Numbers</b>
    <table>
    <tr>
    <td>TIN:</td>
    <td><asp:Label ID="LabelTIN" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>SSS:</td>
    <td><asp:Label ID="LabelSSS" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>PhilHealth:</td>
    <td><asp:Label ID="LabelPhilHealth" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Pag-ibig:</td>
    <td><asp:Label ID="LabelPagibig" runat="server" Text="Label"></asp:Label></td>
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
