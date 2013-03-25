<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_DeactivateAccount.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_DeactivateAccount" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
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
    <div class="Side_bar">
     <div id="navigation">
<ul>
   <li><a class="nav_profile" href="#"></a>
	  <ul class="sub-level">
		 <li><a href="GM_Home.aspx"><span>General Information</span></a></li>
		 <li><a href="GM_ViewGovtInfo.aspx"><span>Government Related</span></a></li>
		 <li><a href="GM_ViewContactInfo.aspx"><span>Contact Information</span></a></li>
         <li><a href="GM_ViewFamilyInfo.aspx"><span>Family Background</span></a></li>
         <li><a href="GM_ViewEducInfo.aspx"><span>Educational Background</span></a></li>
      </ul>
   </li>
    <li><a class="nav_time" href="#"></a>
		<ul class="sub-level">
         <li><span>Attendance</span></li>
		 <li><a href="../EmployeeSelfService/EmployeeSelf_GMVerifyRequest.aspx"><span>Requests</span></a></li>
		 <li><a href="../Timekeeping/Timekeeping_AddTask.aspx"><span>Scehudule</span></a></li>
          <li><span>Reports</span></a></li>
      </ul>
   </li>
     <li><a class="nav_accounts" href="#"></a>
		<ul class="sub-level">
         <li><a href="GM_SearchEmployees.aspx"><span>Search Accounts</span></a></li>
		 <li><a href="GM_AddUsers.aspx"><span>Add New Employee Profile</span></a></li>
		
      </ul>
   </li>
   <li><a class="nav_benefits" href="#"></a>
		<ul class="sub-level">
         <li><a href='#'><span>View Benefits</span></a></li>
		 <li><a href='#'><span>Generate Benefits</span></a></li>
		
      </ul>
      </li>
 
 <li><a class="nav_management" href="#"></a>
		<ul class="sub-level">
         <li><a href='#'><span>Payroll </span></a></li>
		 <li><a href="GM_ViewReports.aspx"><span>Reports</span></a></li>
		
      </ul>
      </li>
      </ul>
    </div><!--end of navigation-->
  </div><!--end of side bar (leftside)-->
    <div class="Working_Area">
    <br />
    <center>
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
            onselectedindexchanged="GridView1_SelectedIndexChanged1"  GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt">
                    <AlternatingRowStyle CssClass="alt" />
                    <PagerSettings FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" 
                        NextPageText="&gt;" PreviousPageText="&lt;" />
                    <PagerStyle CssClass="pgr" />
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
        <table>
        <tr>
        <td>UserID:</td>
        <td><asp:TextBox ID="txtID" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Name:</td>
        <td><asp:TextBox ID="txtFullName" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td></td>
           <td> <asp:Label ID="Label2" runat="server" ForeColor="#990000" Visible="False">
     </asp:Label></td>
     </tr>
        <tr>
        <td></td>
        <td><asp:Button ID="btnDeactivate" CssClass="BlueButton" runat="server" onclick="Button1_Click" 
            Text="Deactivate Account" Width="140px" /></td>
        </tr>
        <tr>
        <td></td>
        <td><asp:Button ID="Button1" CssClass="BlueButton" runat="server" onclick="Button1_Click1" 
            Text="Activate Account" Width="142px" /></td>
            </tr>   
    </table>
    </center>
    <br />
    <center>
    <div class="divider"></div>
    </center>
    
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
