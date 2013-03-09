<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.GeneralManager.GM_UpdateContactInfo" CodeFile="GM_UpdateContactInfo.aspx.cs" %>

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
        <asp:GridView ID="GridViewUsers" runat="server" 
            onselectedindexchanged="GridViewUsers_SelectedIndexChanged" GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt">
                    <AlternatingRowStyle CssClass="alt" />
                    <PagerSettings FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" 
                        NextPageText="&gt;" PreviousPageText="&lt;" />
                    <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>

        <br />

    <table>
    <tr>
    <td>Telephone Number:</td>
    <td><asp:TextBox ID="txtHomeNum" CssClass="tb" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Cellphone Number:</td>
    <td><asp:TextBox ID="txtCellphoneNum" CssClass="tb" title='Phone Number (Format: +99(99)9999-9999)' required runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Address:</td>
    <td><asp:TextBox ID="txtHomeAddress" CssClass="tb" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Email:</td>
    <td><asp:TextBox ID="txtEmail" CssClass="tb" size="35" placeholder="Enter a valid email address" type="email" required runat="server"></asp:TextBox></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="ButtonUpdateContactInfo" runat="server" 
            Text="Edit Information" CssClass="BlueButton" onclick="ButtonUpdateContactInfo_Click" /></td>
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

