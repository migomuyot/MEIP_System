<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employee_ViewFamilyInfo.aspx.cs" Inherits="MEIP_System.UI.Employee.Employee_ViewFamilyInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html >
<link href="../CSS/Style.css" rel="stylesheet" type="text/css" />
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    < <div id="wrapper">
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
     <div style="height:700px; overflow:auto;" >
    <br />
    <center>
    <div class="divider"></div>
    </center>

    <center>
    <br />
    <b>PARENTS</b>
    <br />
         <asp:GridView ID="GridViewFamilyInfo" runat="server"  width="590px" 
            onselectedindexchanged="GridViewFamilyInfo_SelectedIndexChanged"
             GridLines="None"    
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
        <table>
        <tr>
        <td><img src="../Images/Father.ico" width="30" height="30" /></a></td>
        <td>Father</td>
        <td><img src="../Images/Mother.ico" width="30" height="30"></a></td>
        <td>Mother</td>
        </tr>
        <tr>
        <td>Family Info ID:</td>
        <td><asp:TextBox ID="txtFamilyInfoID" CssClass="tb" runat="server" Width="46px" ReadOnly="True"></asp:TextBox></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td>First Name:</td>
        <td><asp:TextBox ID="txtFatherFName" CssClass="tb" runat="server"></asp:TextBox></td>
        <td>First Name:</td>
        <td><asp:TextBox ID="txtMotherFName" CssClass="tb" runat="server" ontextchanged="txtMotherFName_TextChanged"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Last Name:</td>
        <td><asp:TextBox ID="txtFatherLName" CssClass="tb" runat="server"></asp:TextBox></td>
        <td>Last Name:</td>
        <td><asp:TextBox ID="txtMotherLName" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Contact Number:</td>
        <td><asp:TextBox ID="txtFatherCNum" CssClass="tb" runat="server"></asp:TextBox></td>
        <td>Contact Number:</td>
        <td><asp:TextBox ID="txtMotherCNum" CssClass="tb" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td></td>
        <td></td>
        <td></td>
        <td>
            <asp:Button ID="Button1" runat="server" CssClass="BlueButton" Text="Save Changes" 
                Width="152px" onclick="Button1_Click" />
            </td>
        </tr>
        </table>
    <br />
    <b>SIBLING</b>
    <br />
        <asp:GridView ID="GridViewSiblingInfo" runat="server" 
            onselectedindexchanged="GridViewSiblingInfo_SelectedIndexChanged"
            GridLines="None"    
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
        <table>
        <tr>
        <td><img src="../Images/siblings.ico" width="30" height="30"></a></td>
        <td>Sibling</td>
        <tr>
        <td>Sibling ID:</td>
        <td><asp:TextBox ID="txtSiblingID" CssClass="tb" runat="server" ReadOnly="True" Width="38px"></asp:TextBox></td>
        </tr>
        </tr>
        <tr>
        <td>First Name:</td>
        <td>
            <asp:TextBox ID="txtSiblingFName" CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>Last Name:</td>
        <td>
            <asp:TextBox ID="txtSiblingLName" CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>Contact Number:</td>
        <td>
            <asp:TextBox ID="txtSiblingContactNum" CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td></td>
        <td>
            <asp:Button ID="Button2" runat="server" CssClass="BlueButton" Text="Save Changes" 
                Width="176px" onclick="Button2_Click" />
            </td>
        </tr>
        <tr>
        <td></td>
        <td>
            <asp:Button ID="Button3" runat="server" CssClass="BlueButton" Text="Add Information" 
                onclick="Button3_Click" Width="176px" /></td></tr>
        </table>
    <br />
    </center>
    <center>
    <div class="button"></div></center>
    </div><!--end of wokring Area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
