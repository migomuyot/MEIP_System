<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_DeactivateAccount.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_DeactivateAccount" %>

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
    <br />
     <br />
    <center>
    <div class="divider"></div>
    </center>
        <h1><asp:Label ID="Label1" runat="server" Text="Deactivate Account"></asp:Label></h1>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
            ForeColor="#333333" GridLines="None" 
            onselectedindexchanged="GridView1_SelectedIndexChanged1">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:TextBox ID="txtID" CssClass="tb" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtFullName" CssClass="tb" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDeactivate" CssClass="BlueButton" runat="server" onclick="Button1_Click" 
            Text="Deactivate Account" Width="127px" />
        <br />
        <br />
        <asp:Button ID="Button1" CssClass="BlueButton" runat="server" onclick="Button1_Click1" 
            Text="Activate Account" Width="126px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" ForeColor="#990000" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
    
    <center>
    <div class="divider"></div>
    </center>
    
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </div>
    </form>
</body>
</html>
