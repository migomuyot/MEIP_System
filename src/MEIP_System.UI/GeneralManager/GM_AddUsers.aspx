<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_AddUsers.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_AddUsers" %>

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
        <p class="style3">REGISTER</p>
            <asp:GridView ID="GridViewAddEmployee" runat="server"  GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt">
                    <AlternatingRowStyle CssClass="alt" />
                    <PagerSettings FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" 
                        NextPageText="&gt;" PreviousPageText="&lt;" />
                    <PagerStyle CssClass="pgr"/>

        </asp:GridView>
            <br />
            </center>
        <table style="width: 33%; margin-left: 371px; height: 477px; margin-right: 38px;">
            <tr>
                <td class="style1">
                    Last Name</td>
                <td class="style2">
                    <asp:TextBox ID="txtLName" CssClass="tb" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    First Name</td>
                <td class="style2">
                    <asp:TextBox ID="txtFName" CssClass="tb" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Middle Name</td>
                <td class="style2">
                    <asp:TextBox ID="txtMName" CssClass="tb" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Nickname</td>
                <td class="style2">
                    <asp:TextBox ID="txtNickname" CssClass="tb" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Date of Birth</td>
                <td class="style2">
                    <asp:Calendar ID="CalendarDOB" runat="server"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Civil Status</td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownListCivilStatus" CssClass="tb" runat="server" Height="25px" 
                        Width="157px">
                        <asp:ListItem>Single</asp:ListItem>
                        <asp:ListItem>Married</asp:ListItem>
                        <asp:ListItem>Widowed</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Gender</td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownListGender" CssClass="tb" runat="server" Height="25px" 
                        Width="158px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Username</td>
                <td class="style2">
                    <asp:TextBox ID="txtUsername" CssClass="tb" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Password</td>
                <td class="style5">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="tb" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p style="margin-left: 440px">
            <asp:Button ID="Button1" runat="server" CssClass="BlueButton" onclick="Button1_Click" 
                Text="Add User" />
        </p>
        <p style="margin-left: 440px">
            &nbsp;</p>
        <div style="margin-left: 360px">
        </div>
        <p style="margin-left: 440px">
            &nbsp;</p>
        &nbsp;&nbsp;&nbsp;
      <center>
    <div class="divider"></div>
    </center>
    
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->

    </form>
</body>
</html>
