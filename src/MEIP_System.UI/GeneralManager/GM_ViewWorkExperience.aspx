<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_ViewWorkExperience.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_ViewWorkExperience" %>



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
		 <li><a href='#'><span>Reports</span></a></li>
		
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
         <asp:GridView ID="GridView1" runat="server" 
             onselectedindexchanged="GridView1_SelectedIndexChanged" GridLines="None"    
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
         q<br />
    <asp:Button ID="Button1" runat="server" CssClass="BlueButton" Text="Update Work Experience" 
             onclick="Button1_Click" Width="197px" />
         <br />
         <br />
         <asp:Button ID="Button3" CssClass="BlueButton" runat="server" onclick="Button3_Click" 
             Text="Add Work Experience" Width="199px" />
         <br />
         <br />
         <br />
    </center>
               <center>
    <div class="divider"></div>
    </center>
    
    </div><!--end of working area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
