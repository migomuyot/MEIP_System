<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Timekeeping_AddTask.aspx.cs" Inherits="MEIP_System.UI.Timekeeping.Timekeeping_AddTask" %>

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
          <li><span>Reports</span></li>
      </ul>
   </li>
     <li><a class="nav_accounts" href="#"></a>
		<ul class="sub-level">
         <li><a href="../GeneralManager/GM_SearchEmployees.aspx"><span>Search Accounts</span></a></li>
		 <li><a href="../GeneralManager/GM_AddUsers.aspx"><span>Add New Profile</span></a></li>
		
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
		 <li><a href="../GeneralManager/GM_ViewReports.aspx"><span>Reports</span></a></li>
		
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
    <center>
    <center>
    <asp:GridView ID="GridView1" runat="server" 
                           onselectedindexchanged="GridView1_SelectedIndexChanged"  GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt" Height="118px" 
            Width="244px">
                    <AlternatingRowStyle CssClass="alt" />
                    <PagerSettings FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" 
                        NextPageText="&gt;" PreviousPageText="&lt;" />
                           <Columns>
                               <asp:CommandField ShowSelectButton="True" />
                           </Columns>
                       </asp:GridView>
                    </center>
              <table  style="font-family: Arial, Helvetica, sans-serif" cellspacing="0">
            <tr>
            <td>Notification ID</td>
            <td><asp:TextBox ID="txtNotificationID" CssClass="tb" runat="server" ReadOnly="True" Width="40px"></asp:TextBox></td>
            </tr>
            <tr>
                <td  >
                    Employee</td>
                <td  >
                    <asp:DropDownList ID="DropDownListEmployee" runat="server" Height="30px" Width="236px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
            <td></td>
            <td><asp:TextBox ID="txtEmployee" CssClass="tb" runat="server" ReadOnly="True" Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td  >
                    Task</td>
                <td  >
                    <asp:TextBox ID="txtTasks" CssClass="tb" runat="server" Width="229px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td  >
                    Task Date</td>
                <td  >
                    <asp:Calendar ID="CalendarTaskDate" runat="server"  />
                        <TodayDayStyle BackColor="#CCCCCC" />
                    </asp:Calendar>
                </td>
            </tr>
                    <tr>
        <td></td>
        <td>
            <asp:TextBox ID="txtDate" CssClass="tb" runat="server" ReadOnly="True" Width="238px"></asp:TextBox></td>
        </tr>
        <tr>
        <td></td>
         <td><asp:Button ID="ButtonTask" CssClass="BlueButton" runat="server" onclick="ButtonTask_Click" 
                    Text="Add Task" Width="123px" /></td>
                    </tr>
                    <tr>
                    <td></td>
             <td><asp:Button ID="Button1" CssClass="BlueButton" runat="server" Text="Edit Task" Width="121px" 
                    onclick="Button1_Click" />
            </td>
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
