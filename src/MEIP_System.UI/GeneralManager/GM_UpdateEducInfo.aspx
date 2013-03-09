<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.GeneralManager.GM_UpdateEducInfo" CodeFile="GM_UpdateEducInfo.aspx.cs" %>

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
        <asp:GridView ID="GridViewEducInfo" runat="server" 
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
    <td>Graduate School:</td>
    <td><asp:TextBox ID="txtGraduateSchool" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Course Taken:</td>
    <td><asp:TextBox ID="txtCourseTaken" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Year Graduated:</td>
    <td><asp:TextBox ID="txtYearGraduated" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
   </table>
    <asp:Button ID="ButtonUpdateEducInfo" runat="server" CssClass="BlueButton" Text="Edit Information" 
            onclick="ButtonUpdateEducInfo_Click" /></td>
 

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