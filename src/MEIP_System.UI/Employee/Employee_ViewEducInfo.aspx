<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.Employee.Employee_ViewEducInfo" CodeFile="Employee_ViewEducInfo.aspx.cs" %>

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
    <div class="Side_bar">  <div id="navigation">
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
		 <li><a href="../EmployeeSelfService/EmployeeSelf_AddLeaveRequest.aspx"><span>Requests</span></a></li>
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
</div><!--end of navigation--></div><!--end of side bar (leftside)-->
    <div class="Working_Area">
    <br />
    <center>
    <div class="divider"></div>
    </center>
    <br />
    <center>
    <table>
    <tr>
    <td>School:</td>
    <td><asp:Label ID="LabelGraduateSchool" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Course:</td>
    <td><asp:Label ID="LabelCourseTaken" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td>Year Graduated:</td>
    <td><asp:Label ID="LabelYearGraduated" runat="server" Text="Label"></asp:Label></td>
    </tr>
    </table>
    <br /> <asp:Button ID="Button1" runat="server" CssClass="BlueButton" 
            Text="Edit Information" onclick="Button1_Click" />
   
    </center>
    <center>
    <div class="divider"></div></center>
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of Wrapper-->
    </form>
</body>
</html>
