<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeSelf_GMVerifyRequest.aspx.cs" Inherits="MEIP_System.UI.EmployeeSelfService.EmployeeSelf_GMVerifyRequest" %>

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
		 <li><a href="../GeneralManager/GM_Home.aspx"><span>General Information</span></a></li>
		 <li><a href="../GeneralManager/GM_ViewGovtInfo.aspx"><span>Government Related</span></a></li>
		 <li><a href="../GeneralManager/GM_UpdateContactInfo.aspx"><span>Contact Information</span></a></li>
         <li><a href="../GeneralManager/GM_ViewFamilyInfo.aspx"><span>Family Background</span></a></li>
         <li><a href="../GeneralManager/GM_ViewEducInfo.aspx"><span>Education</span></a></li>
      </ul>
   </li>
    <li><a class="nav_time" href="#"></a>
		<ul class="sub-level">
         <li><span>Attendance</span></li>
		 <li><a href="../EmployeeSelfService/EmployeeSelf_GMVerifyRequest.aspx"><span>Requests</span></a></li>
		 <li><a href="../Timekeeping/Timekeeping_AddTask.aspx"><span>Scehudule</span></a></li>
          <li><span>Reports</span></li>
      </ul>
   </li>
     <li><a class="nav_accounts" href="#"></a>
		<ul class="sub-level">
         <li><a href="../GeneralManager/GM_SearchEmployees.aspx"><span>Search Accounts</span></a></li>
		 <li><a href="../GeneralManager/GM_AddUsers.aspx"><span>Add New Employee Profile</span></a></li>
		
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
		 <li><a href='#'><span>Reports</span></a></li>
		
      </ul>
      </li>
      </ul>
    </div><!--end of navigation-->
    </div><!--end of side bar (leftside)-->
    <div class="Working_Area">
      <div style="height:700px; overflow:auto;" >
    <br />
    <center>
    <div class="divider"></div>
    </center>
    <center>
        <asp:GridView ID="GridViewAllRequests" runat="server" 
            onselectedindexchanged="GridViewAllRequests_SelectedIndexChanged"  CssClass="mGrid"  
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
        <br />
        <table  style="font-family: Arial, Helvetica, sans-serif" cellspacing="0">
        <tr>
        <td>Request ID:</td>
        <td><asp:TextBox ID="txtRequestID" CssClass="tb" runat="server" Width="38px" ReadOnly="True"></asp:TextBox></td>
        </tr>
                <tr>
        <td>User ID:</td>
        <td><asp:TextBox ID="txtUserID" CssClass="tb" runat="server" Width="38px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Request Type:</td>
        <td><asp:TextBox ID="txtRequestType" CssClass="tb" runat="server" Width="160px"></asp:TextBox></td>
        </tr>
                <tr>
        <td>Date Applied:</td>
        <td><asp:TextBox ID="txtDateApplied" CssClass="tb" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>From:</td>
        <td><asp:TextBox ID="txtStartDate" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>To:</td>
        <td><asp:TextBox ID="txtEndDate" CssClass="tb" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr
        <tr>
        <td>Attendance Date Change:</td>
        <td><asp:TextBox ID="txtAttendanceDateChange" runat="server" Width="160px" 
                ReadOnly="True"></asp:TextBox></td>
        </tr>
                <tr>
        <td>Time Change In:</td>
        <td><asp:TextBox ID="txtTimeChangeIn" CssClass="tb" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Time Change Out:</td>
        <td><asp:TextBox ID="txtTimeChangeOut" CssClass="tb" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Leave Type:</td>
        <td><asp:TextBox ID="txtLeaveType" CssClass="tb" runat="server" Height="22px" Width="160px" 
                ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Reason:</td>
        <td><asp:TextBox ID="txtReason" CssClass="tb" runat="server" Height="50px" Width="135px" 
                TextMode="MultiLine" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Remarks:</td>
        <td>
            <asp:TextBox ID="txtRemarks" CssClass="tb" runat="server" TextMode="MultiLine" Width="135px"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>Status:</td>
        <td><asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>APPROVED</asp:ListItem>
            <asp:ListItem>DECLINED</asp:ListItem>
            </asp:DropDownList>
        </td></tr>
        </table>
        <br />
        <asp:Button ID="Button1" CssClass="BlueButton" runat="server" Text="Verify Request" 
            onclick="Button1_Click" />
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
