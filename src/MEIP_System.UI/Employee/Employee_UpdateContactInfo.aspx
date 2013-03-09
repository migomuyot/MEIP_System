<%@ Page Language="C#" AutoEventWireup="true" Inherits="MEIP_System.UI.Employee.Employee_UpdateContactInfo" CodeFile="Employee_UpdateContactInfo.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html >
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
</div><!--end of navigation-->
    </div><!--end of side bar (leftside)-->
    <div class="Working_Area">
    <br />
    <center>
    <div class="divider"></div>
        <center>
        <asp:GridView ID="GridViewUsers" runat="server" 
            onselectedindexchanged="GridViewUsers_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>

        <br />

     <table>
    <tr>
    <td>Telephone Number:</td>
    <td><asp:TextBox ID="txtHomeNum" runat="server" CssClass="tb" required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Cellphone Number:</td>
    <td><asp:TextBox ID="txtCellphoneNum" runat="server" CssClass="tb" type='tel' pattern='[\+]\d{2}[\(]\d{2}[\)]\d{4}[\-]\d{4}' title='Phone Number (Format: +99(99)9999-9999)' required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Address:</td>
    <td><asp:TextBox ID="txtHomeAddress" runat="server" CssClass="tb" required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Email:</td>
    <td><asp:TextBox ID="txtEmail" runat="server" CssClass="tb" size="35" placeholder="Enter a valid email address" type="email" required></asp:TextBox></td>
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
