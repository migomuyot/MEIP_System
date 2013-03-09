<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_ViewAuditTrail.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_ViewAuditTrail" %>

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
    <div class="Side_bar"></div><!--end of side bar (leftside)-->
    <div class="Working_Area">
    
        <asp:Label ID="Label1" runat="server" Text="Audit Trail"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
            onpageindexchanging="GridView2_PageIndexChanging" PageIndex="5">
        </asp:GridView>
       <center>
    <div class="divider"></div>
    </center>
    
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->

    </form>
</body>
</html>
