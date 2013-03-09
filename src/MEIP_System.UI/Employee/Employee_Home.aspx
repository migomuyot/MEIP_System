<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employee_Home.aspx.cs" Inherits="MEIP_System.UI.Employee.Employee_Home" %>

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
		 <li><a href="Employee_Home.aspx"><span>General Information</span></a></li>
		 <li><a href="Employee_ViewGovtInfo.aspx"><span>Government Related</span></a></li>
		 <li><a href="Employee_ViewContactInfo.aspx"><span>Contact Information</span></a></li>
         <li><a href="Employee_ViewFamilyInfo.aspx"><span>Family Background</span></a></li>
         <li><a href="Employee_ViewEducInfo.aspx"><span>Educational Background</span></a></li>
      </ul>
   </li>

   <li><a class="nav_time" href="#"></a>
		<ul class="sub-level">
         <li><span>Attendance</span></a></li>
		 <li><a href="../EmployeeSelfService/EmployeeSelf_EmployeeLeaveRequest.aspx"><span>Requests</span></a></li>
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
    <div class="Content_Header"><img src="../Images/Profile.ico" 
            style="height: 30px; width: 30px" ><p>PROFILE</p></div>
    <center>
    <div class="divider"></div>
    </center>
    <center>
        <br />
        MY PROFILE<br />
         </b
    <br />
    <table>
    <tr>
    <td>First Name:</td>
    <td><asp:Label ID="LabelFName" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Last Name:</td>
    <td> <asp:Label ID="LabelLName" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Middle Name:</td>
    <td><asp:Label ID="LabelMName" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Nickname:</td>
    <td><asp:Label ID="LabelNickname" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Gender:</td>
    <td><asp:Label ID="LabelGender" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Birthday:</td>
    <td><asp:Label ID="LabelDOB" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Civil Status:</td>
    <td><asp:Label ID="LabelCivilStatus" runat="server" Text="Label"></asp:Label></td>
    </tr>
    </table>
     <br />
     <center>
     <div class="divider"></div>
     </center>
    <b>
        <br />
        EMPLOYEE SELF-SERVICE</b>
    <br />
    <a href="../EmployeeSelfService/EmployeeSelf_AddLeaveRequest.aspx">Leave Request</a><br />
    <a href="../EmployeeSelfService/EmployeeSelf_ViewLeaveRequest.aspx">View Leave Requests</a><br />
    <a href="">Time Change Request</a>
    <br />
    </center>
    </div><!--end of Working_Area (rightside)-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>