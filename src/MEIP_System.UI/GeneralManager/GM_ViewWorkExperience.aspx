<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_ViewWorkExperience.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_ViewWorkExperience" %>


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
         <asp:GridView ID="GridView1" runat="server" 
             onselectedindexchanged="GridView1_SelectedIndexChanged" GridLines="None"    
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
    <td>Work Experience ID:</td>
    <td><asp:TextBox ID="txtWorkExperienceID" CssClass="tb" runat="server" ReadOnly="True" 
            Width="39px"></asp:TextBox></td>
    </tr>
    <tr>
    <td>Year Started:</td>
    <td><asp:TextBox ID="txtYearStarted" CssClass="tb" runat="server"></asp:TextBox></td>
    <td></td>
    </tr> 
    <tr>
    <td>Year Ended:</td>
    <td><asp:TextBox ID="txtYearEnded" CssClass="tb" runat="server"></asp:TextBox></td>
    <td></td>
    </tr>
    <tr>
    <td>Company:</td>
    <td><asp:TextBox ID="txtCompany" CssClass="tb" runat="server"></asp:TextBox></td>
    <td></td>
    </tr>
    <tr>
    <td>Position:</td>
    <td><asp:TextBox ID="txtExpPosition" CssClass="tb" runat="server"></asp:TextBox></td>
    <td></td>
    </tr>
    </table>
         <br />
    <asp:Button ID="Button1" runat="server" CssClass="BlueButton" Text="Update Work Experience" 
             onclick="Button1_Click" />
         <br />
         <br />
         <asp:Button ID="Button3" CssClass="BlueButton" runat="server" onclick="Button3_Click" 
             Text="Add Work Experience" Width="218px" />
         <br />
         <br />
         <br />
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
