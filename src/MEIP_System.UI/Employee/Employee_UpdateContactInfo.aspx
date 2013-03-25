<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.Employee.Employee_UpdateContactInfo" CodeFile="Employee_UpdateContactInfo.aspx.cs" %>


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
                        <li><a href="../EmployeeSelfService/EmployeeSelf_EmployeeTimeChangeRequest.aspx"><span>Time Change</span></a></li>
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
    <div class="Content_Header"><img src="../Images/ContactInformation.png" /></div>
    <center>
    <div class="divider"></div>
    </center>
        <center>
        <asp:GridView ID="GridViewUsers" runat="server" 
            onselectedindexchanged="GridViewUsers_SelectedIndexChanged"  GridLines="None"    
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

     <table  style="font-family: Arial, Helvetica, sans-serif" cellspacing="0">
    <tr>
    <td>Telephone No. :</td>
    <td><asp:TextBox ID="txtHomeNum" runat="server" CssClass="tb" MaxLength="7" placeholder="XXX-XXXX" Width="213px" required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Cellphone No. :</td>
    <td><asp:TextBox ID="txtCellphoneNum" placeholder="+63 XXX XXX XXXXX" runat="server" CssClass="tb" Width="212px" MaxLength="12" required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Address:</td>
    <td><asp:TextBox ID="txtHomeAddress" runat="server" CssClass="tb"
   Height="85px" MaxLength="50" TextMode="MultiLine" Width="211px" required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Email:</td>
    <td><asp:TextBox ID="txtEmail" runat="server" CssClass="tb" size="35" 
            placeholder="Enter a valid email address" type="email" required MaxLength="50"></asp:TextBox></td>
    </tr>
    </table>
    
    <asp:Button ID="ButtonUpdateContactInfo" runat="server" 
            Text="Save Changes" onclick="ButtonUpdateContactInfo_Click " CssClass="BlueButton"/>

    
      <center>
    <div class="divider"></div>
    </center>
    </div><!--end of wroking A
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
