<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeSelf_EmployeeTimeChangeRequest.aspx.cs" Inherits="MEIP_System.UI.EmployeeSelfService.EmployeeSelf_EmployeeTimeChangeRequest" %>

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
                <li style="float:right; height: 25px;"><asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">LOGOUT</asp:LinkButton></li>
             </ul>
			</div><!--end of nav-->
    <div id="container">
    <div class="Side_bar">
          <div id="navigation">
<ul>
   <li><a class="nav_profile" href="#"></a>
	  <ul class="sub-level">
		 <li><a href="../Employee/Employee_Home.aspx"><span>General Information</span></a></li>
		 <li><a href="../Employee/Employee_ViewGovtInfo.aspx"><span>Government Related</span></a></li>
		 <li><a href="../Employee/Employee_ViewContactInfo.aspx"><span>Contact Information</span></a></li>
         <li><a href="../Employee/Employee_ViewFamilyInfo.aspx"><span>Family Background</span></a></li>
         <li><a href="../Employee/Employee_ViewEducInfo.aspx"><span>Education</span></a></li>
      </ul>
   </li>
    <li><a class="nav_time" href="#"></a>
		<ul class="sub-level">
        <li><a href="#"><span>Attendance</span></a></li>
        <ul>
		 <li><a href="#">Request</a>
                    <ul class="sub-level">
                        <li><a href="EmployeeSelf_EmployeeTimeChangeRequest.aspx"><span>Time Change</span></a></li>
                        <li><a href="EmployeeSelf_EmployeeLeaveRequest.aspx"><span>Leave Request</a></span></li>
                    </ul>
                </li>
          </ul>
		 <li><a href='#'><span>Scehudule</span></a></li>
      </ul>
   </li>
   <li><a class="nav_earning" href="#"></a>
		<ul class="sub-level">
         <li><a href='#'><span>Payroll</span></a></li>

      </ul>
   </li>
   <li><a class="nav_benefits" href="#"></a>
		<ul class="sub-level">
         <li><a href='#'><span>View Benefits</span></a></li>
		 <li><a href='#'><span>Generate Benefits</span></a></li>
		
      </ul>
   
   </li>
</ul>
</div><!--end of navigation-->
    </div><!--end of side bar (leftside)-->
    <div class="Working_Area">
    <br />
    <center>
    <div class="divider"></div>
    </center>
    <br />
    <center>
    <asp:GridView ID="GridViewDTR" runat="server"  GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt">
                    <AlternatingRowStyle CssClass="alt" />
                    <PagerSettings FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" 
                        NextPageText="&gt;" PreviousPageText="&lt;" />
                    <PagerStyle CssClass="pgr" /></asp:GridView>
        <br />
    <asp:GridView ID="GridViewTimeChange" runat="server" 
            onselectedindexchanged="GridViewTimeChange_SelectedIndexChanged"  GridLines="None"    
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
        <br />
        <table>
        <tr>
            <td>Request ID:</td>
            <td><asp:TextBox ID="txtRequestID" CssClass="tb" runat="server" ReadOnly="True" Width="49px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Date Applied:</td>
            <td><asp:TextBox ID="txtDateApplied" runat="server" CssClass="tb" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Attendance Date Change:</td>
            <td><asp:TextBox ID="txtAttendanceDateChange" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Time-In Change:</td>
            <td><asp:TextBox ID="txtTimeInChange" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Time-Out Change:</td>
            <td><asp:TextBox ID="txtTimeChangeOut" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Reason:</td>
            <td><asp:TextBox ID="txtReason" CssClass="tb" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="Button1"  runat="server" CssClass="BlueButton" Text="Add Request" Width="172px" 
                    onclick="Button1_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="Button2" runat="server" CssClass="BlueButton" Text="Update Request" Width="172px" 
                    onclick="Button2_Click" /></td>
        </tr>
        </table>
    </center>
    <center>
      <div class="divider"></div>
     </center>
    </div><!--end of Working_Area (rightside)-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
   
    </form>
</body>
</html>
