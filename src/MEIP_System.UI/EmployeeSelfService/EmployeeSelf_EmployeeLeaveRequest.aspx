<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeSelf_EmployeeLeaveRequest.aspx.cs" Inherits="MEIP_System.UI.EmployeeSelfService.EmployeeSelf_ViewLeaveRequest" %>

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
    <div class="Side_bar">
           <div id="navigation">
<ul>
   <li><a class="nav_profile" href="#"></a>
	  <ul class="sub-level">
		 <li><a href="../Employee/Employee_Home.aspx"><span>General Information</span></a></li>
		 <li><a href="../Employee/Employee_ViewGovtInfo.aspx"<span>Government Related</span></a></li>
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
                        <li><a href="../EmployeeSelf_EmployeeTimeChangeRequest.aspx"><span>Time Change</span></a></li>
                        <li><a href="../EmployeeSelfService/EmployeeSelf_EmployeeLeaveRequest.aspx">Leave Request</a></li>
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
    <div style="height:700px; overflow:auto;" >
    <br />
    <center>
        <asp:GridView ID="GridView1" runat="server" 
            onselectedindexchanged="GridView1_SelectedIndexChanged1" GridLines="None"    
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
        <td><asp:TextBox ID="txtRequestID" runat="server" Width="38px"></asp:TextBox></td>
        </tr>
        <tr>
        <td>From:</td>
        <td><asp:TextBox ID="txtStartDate" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        <td></td>
        </tr>
        <tr>
        <td></td>
        <td><asp:Calendar ID="CalendarStartDate" runat="server"></asp:Calendar></td>
        <td></td>
        </tr>
        <tr>
        <td>To:</td>
        <td><asp:TextBox ID="txtEndDate" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        <td></td>
        </tr>
        <tr>
        <td></td>
        <td><asp:Calendar ID="CalendarEndDate" runat="server"></asp:Calendar></td>
        <td></td>
        </tr>
        <tr>
        <td>Leave Type:</td>
        <td><asp:TextBox ID="txtLeaveType" runat="server" Height="22px" Width="135px" 
                ReadOnly="True"></asp:TextBox></td>
        <td></td>
        </tr>
        <tr>
        <td></td>
        <td><asp:DropDownList ID="DropDownLeaveTypes" runat="server">
        <asp:ListItem>Sick</asp:ListItem>
        <asp:ListItem>Vacation</asp:ListItem>
        </asp:DropDownList></td>
        <td></td>
        </tr>
        <tr>
        <td>Reason:</td>
        <td><asp:TextBox ID="txtReason" runat="server" Height="50px" Width="135px" 
                TextMode="MultiLine"></asp:TextBox></td>
        <td></td>
        </tr>
        </table>
        <br />
        <asp:Button ID="Button4" CssClass="BlueButton" runat="server" onclick="Button4_Click" 
            Text="Add New Request" />
            <br />
            <br />
        <asp:Button ID="Button2" CssClass="BlueButton" runat="server" Text="Update Request" 
            onclick="Button2_Click" Width="157px" />
            <br />
        <br />
&nbsp;<asp:Button ID="Button3" CssClass="BlueButton" runat="server" Text="Back" onclick="Button3_Click" />
            </center>
         <center>
    <div class="divider"></div>
    </center>
    </div>
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->


    </form>
</body>
</html>
