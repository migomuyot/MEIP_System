﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employee_AddWorkExperience.aspx.cs" Inherits="MEIP_System.UI.Employee.Employee_AddWorkExperience" %>

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
		 <li><a href="Employee_Home.aspx"><span>General Information</span></a></li>
		 <li><a href="Employee_ViewGovtInfo.aspx"><span>Government Related</span></a></li>
		 <li><a href="Employee_ViewContactInfo.aspx"><span>Contact Information</span></a></li>
         <li><a href="Employee_ViewFamilyInfo.aspx"><span>Family Background</span></a></li>
         <li><a href="Employee_ViewEducInfo.aspx"><span>Education</span></a></li>
      </ul>
   </li>
    <li><a class="nav_time" href="#"></a>
		<ul class="sub-level">
        <li><a href="#"><span>Attendance</span></a></li>
        <ul>
		 <li><a href="#">Request</a>
                 <ul class="sub-level">
                        <li><a href="../EmployeeSelf_EmployeeTimeChangeRequest.aspx"><span>Time Change</span></a></li>
                        <li><a href="../EmployeeSelfService/EmployeeSelf_EmployeeLeaveRequest.aspx"><span>Leave Request</a></span></li>
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
    <center>
    <table  style="font-family: Arial, Helvetica, sans-serif" cellspacing="0">
    <tr>
    <td>Date Started:</td>
    <td><asp:TextBox ID="txtYearStarted" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Date Ended:</td>
    <td><asp:TextBox ID="txtYearEnded" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Company:</td>
    <td><asp:TextBox ID="txtCompany" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td>Position:</td>
    <td><asp:TextBox ID="txtExpPosition" CssClass="tb" runat="server"></asp:TextBox></td>
    <td>VALIDATION MESSAGE</td>
    </tr>
    <tr>
    <td></td>
    <td>
        <asp:Button ID="ButtonAddWorkExperience" runat="server" CssClass="BlueButton" Text="Save Information" 
            onclick="ButtonAddWorkExperience_Click" Width="132px" />
        </td>
    <td></td>
    </tr>
    </table>
    </center>
    <br />
     <center>
     <div class="divider"></div>
     </center>
    </div>
    </div>
    </form>
</body>
</html>
