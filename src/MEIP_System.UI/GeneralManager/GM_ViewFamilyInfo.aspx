<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_ViewFamilyInfo.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_ViewFamilyInfo" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="../CSS/Style.css" rel="stylesheet" type="text/css" />
<head>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
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
         <li><a href="GM_ViewEducInfo.aspx"><span>Education</span></a></li>
      </ul>
   </li>
    <li><a class="nav_time" href="#"></a>
		<ul class="sub-level">
         <li><span>Attendance</span></li>
		 <li><a href="../EmployeeSelfService/EmployeeSelf_GMVerifyRequest.aspx"><span>Requests</span></a></li>
		 <li><a href="../Timekeeping/Timekeeping_AddTask.aspx"><span>Scehudule</span></a></li>
          <li><span>Reports</span></a></li>
      </ul>
   </li>
     <li><a class="nav_accounts" href="#"></a>
		<ul class="sub-level">
         <li><a href="GM_SearchEmployees.aspx"><span>Search Accounts</span></a></li>
		 <li><a href="GM_AddUsers.aspx"><span>Add New Employee Profile</span></a></li>
		
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
		 <li><a href="GM_ViewReports.aspx"></a><span>Reports</span></a></li>
		
      </ul>
      </li>
      </ul>
    </div><!--end of navigation-->
    </div><!--end of side bar (leftside)-->
  <div class="Working_Area">
  <div style="height:700px; overflow:auto;" >
     <br />
         <div class="Content_Header"><img src="../Images/FamilyInformation.png" /></div>
    <center>
    <div class="divider"></div>
    </center>
   <center>
    <br />
        <asp:GridView ID="GridViewFamilyInfo" runat="server" 
            onselectedindexchanged="GridViewFamilyInfo_SelectedIndexChanged" GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt" Height="128px" 
           Width="330px">
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
        <td><h2>&nbsp;</h2></td>
        <td>Father</td>
        <td><h2>&nbsp;</h2></td>
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
        <td><asp:TextBox ID="txtMotherFName" CssClass="tb" runat="server"></asp:TextBox></td>
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
            onselectedindexchanged="GridViewSiblingInfo_SelectedIndexChanged" GridLines="None"    
                            CssClass="mGrid"  
                            PagerStyle-CssClass="pgr"  
                            AlternatingRowStyle-CssClass="alt" Height="116px" 
           Width="358px">
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
        <td><h2>&nbsp;</h2></td>
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
            <asp:Button ID="Button3" runat="server" CssClass="BlueButton" Text="Add Sibling" 
                onclick="Button3_Click" Width="176px" /></td></tr>
        </table>
        <center>
    <div class="divider"></div>
    </center>
    </center>
    </div>
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
