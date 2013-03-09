<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_ViewFamilyInfo.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_ViewFamilyInfo" %>
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
 <div style="height:700px; overflow:auto;" >
     <br />
    <center>
    <div class="divider"></div>
    </center>
   <center>
    <br />
    <b>PARENTS</b>
    <br />
        <asp:GridView ID="GridViewFamilyInfo" runat="server" 
            onselectedindexchanged="GridViewFamilyInfo_SelectedIndexChanged" GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt" Height="128px" 
           Width="330px">
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
        <td><h2>&nbsp;</h2></td>
        <td>Father</td>
        <td><h2>&nbsp;</h2></td>
        <td>Mother</td>
        </tr>
        <tr>
        <td>Family Info ID:</td>
        <td><asp:TextBox ID="txtFamilyInfoID" CssClass="tb" runat="server" Width="46px" ReadOnly="True"></asp:TextBox></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td>First Name:</td>
        <td><asp:TextBox ID="txtFatherFName" CssClass="tb" runat="server"></asp:TextBox></td>
        <td>First Name:</td>
        <td><asp:TextBox ID="txtMotherFName" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Last Name:</td>
        <td><asp:TextBox ID="txtFatherLName" CssClass="tb" runat="server"></asp:TextBox></td>
        <td>Last Name:</td>
        <td><asp:TextBox ID="txtMotherLName" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Contact Number:</td>
        <td><asp:TextBox ID="txtFatherCNum" CssClass="tb" runat="server"></asp:TextBox>
        <td>Contact Number:</td>
        <td><asp:TextBox ID="txtMotherCNum" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td></td>
        <td></td>
        <td></td>
        <td>
            <asp:Button ID="Button1" runat="server" CssClass="BlueButton" Text="Save Changes" 
                Width="152px" onclick="Button1_Click" />
            </td>
        </tr>
        </table>
    <br />
    <b>SIBLING</b>
    <br />
        <asp:GridView ID="GridViewSiblingInfo" runat="server" 
            onselectedindexchanged="GridViewSiblingInfo_SelectedIndexChanged" GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt" Height="116px" 
           Width="358px">
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
        <td><h2>&nbsp;</h2></td>
        <td>Sibling</td>
        <tr>
        <td>Sibling ID:</td>
        <td><asp:TextBox ID="txtSiblingID" CssClass="tb" runat="server" ReadOnly="True" Width="38px"></asp:TextBox></td>
        </tr>
        </tr>
        <tr>
        <td>First Name:</td>
        <td>
            <asp:TextBox ID="txtSiblingFName" CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>Last Name:</td>
        <td>
            <asp:TextBox ID="txtSiblingLName" CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>Contact Number:</td>
        <td>
            <asp:TextBox ID="txtSiblingContactNum" CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td></td>
        <td>
            <asp:Button ID="Button2" runat="server" CssClass="BlueButton" Text="Save Changes" 
                Width="176px" onclick="Button2_Click" />
            </td>
        </tr>
        <tr>
        <td></td>
        <td>
            <asp:Button ID="Button3" runat="server" CssClass="BlueButton" Text="Add Sibling" 
                onclick="Button3_Click" Width="176px" /></td></tr>
        </table>
        <center>
    <div class="divider"></div>
    </center>
    
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
