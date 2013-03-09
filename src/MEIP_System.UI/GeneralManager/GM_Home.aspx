<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.GeneralManager.GM_Home" CodeFile="GM_Home.aspx.cs" %>

<!DOCTYPE html >
<link href="../CSS/Style.css" rel="stylesheet" type="text/css" />
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
    <div class="borderline">
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
    
    
  
</div><!--end of side bar (leftside)-->
    <div class="Working_Area">
    <br />
     <br />
    <center>
    <div class="divider"></div>
    </center>
    <center>
    <table>
    <tr>
    <td></td>
    <td align="center">&nbsp;</td>
    <td></td>
    </tr>
    <tr>
    <td>First Name:</td>
    <td><asp:Label ID="LabelFName" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td>Last Name:</td>
    <td> <asp:Label ID="LabelLName" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td>Middle Name:</td>
    <td><asp:Label ID="LabelMName" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td>Nickname:</td>
    <td><asp:Label ID="LabelNickname" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td>Gender:</td>
    <td><asp:Label ID="LabelGender" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td>Birthday:</td>
    <td><asp:Label ID="LabelDOB" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    <tr>
    <td>Civil Status:</td>
    <td><asp:Label ID="LabelCivilStatus" runat="server" Text="Label"></asp:Label></td>
    <td></td>
    </tr>
    </table>
    <br />
 PROFILE<br />
    <a href="GM_Home.aspx">General Information</a><br />
    <a href="GM_ViewCompanyInfo.aspx">Company Information</a><br />
    <a href="GM_ViewFamilyInfo.aspx">Family Background</a><br />
    <a href="GM_ViewGovtInfo.aspx">Government Numbers</a><br />
    <a href="GM_ViewContactInfo.aspx">Contact Information</a> <br />
    <a href="GM_ViewEducInfo.aspx">Educational Background</a> <br />
    <a href="GM_ViewWorkExperience.aspx">Work Experience</a><br />
TIME KEEPING<br />
   <a href="#">Attendance</a><br />
   <a href="../EmployeeSelfService/EmployeeSelf_GMVerifyRequest.aspx">Requests</a><br />
   <a href="#">Schedule</a><br />
   <a href="#">Reports</a><br />
ACCOUNT<br />
<a href="GM_SearchEmployees.aspx">Search Accounts</a><br />
 <a href="GM_AddUsers.aspx">Create New Account</a><br />
   PAYROLL<br />
 <a href="#">View Payroll</a><br />
 <a href="#">Reports</a><br />
BENEFITS<br />
<a href="#">Generate Benefits</a><br />
 <a href="#">View Benefits</a> <br />
  ADMINISTRATION<br />
    <a href="GM_ViewAuditTrail.aspx">View Audit Trail</a><br />
    <a href="GM_DeactivateAccount.aspx">Control Accounts</a><br />
    </center>
     <center>
    <div class="divider"></div>
    </center>
    </div><!--end of working area-->
    </div><!--end of container-->
    </div>
    </div><!--end of wrapper-->
    </form>
</body>
</html>
