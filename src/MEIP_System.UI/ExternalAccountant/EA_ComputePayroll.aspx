<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EA_ComputePayroll.aspx.cs" Inherits="MEIP_System.UI.ExternalAccountant.EA_ComputePayroll" %>

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
         <li><a href="#"><span>Requests</span></a></li>
		 <li><a href='#'><span>Scehudule</span></a></li>
         <li><a href='#'><span>Reports</span></a></li>
         <li><a href='#'><span>Task</span></a></li>
      </ul>
   </li>
     <li><a class="nav_accounts" href="#"></a>
		<ul class="sub-level">
         <li><a href='#'><span>Search Accounts</span></a></li>
		 <li><a href="GM_AddUsers.aspx"><span>Add New Employee Profile</span></a></li>
         	 <li><a href="GM_DeactivateAccount.aspx"><span>Control Accounts</span></a></li>
		
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
         <div style="height:700px; overflow:auto;" >
    <br />
    <center>
    <div class="divider"></div>
    </center>
    <table style="margin-left: 10px; margin-right: 200px;" align="right"/>
        <tr>
            <td >
                Holiday Pay</td>
            <td >
                <asp:TextBox ID="txtHolidayPay" CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Bonus</td>
            <td>
                <asp:TextBox ID="txtBonus"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Monthly Incentive</td>
            <td >
                <asp:TextBox ID="txtMonthlyIncentive"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Gross Pay</td>
            <td >
                <asp:TextBox ID="txtGrossPay"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Employee
                SSS</td>
            <td >
                <asp:TextBox ID="txtSSS"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Employer SSS</td>
            <td >
                <asp:TextBox ID="txtEmployerSSS"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Total SSS Contribution</td>
            <td >
                <asp:TextBox ID="txtTotalSSS"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Employee
                PhilHealth</td>
            <td >
                <asp:TextBox ID="txtPhilHealth"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Employer PhilHealth</td>
            <td >
                <asp:TextBox ID="txtEmployerPhilHealth"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Total PhilHealth Contribution</td>
            <td >
                <asp:TextBox ID="txtTotalPhilHealth"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                SSS Loan</td>
            <td >
                <asp:TextBox ID="txtSSSLoan"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Employee
                HDMF</td>
            <td >
                <asp:TextBox ID="txtHDMF"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Employer HDMF</td>
            <td >
                <asp:TextBox ID="txtEmployerHDMF"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Total HDMF Contribution</td>
            <td >
                <asp:TextBox ID="txtTotalHDMF"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Pag-ibig Loan</td>
            <td >
                <asp:TextBox ID="txtPagibigLoan"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                WithHoldTax</td>
            <td >
                <asp:TextBox ID="txtWithHoldTax"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Payroll Date</td>
            <td >
                <asp:TextBox ID="txtPayrollDate"  CssClass="tb" runat="server"></asp:TextBox>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="47px" NextPrevFormat="FullMonth" Width="225px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>
                Net Pay</td>
            <td>
                <asp:TextBox ID="txtNetPay"  CssClass="tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="ComputePayroll"  CssClass="tb" runat="server" onclick="ComputePayroll_Click" 
                    Text="Compute Payroll" />
            </td>
            <td>
                <asp:Button ID="CancelComputation" CssClass="BlueButton" runat="server" Text="Cancel Computation" 
                    onclick="CancelComputation_Click" />
            </td>
        </tr>
    </table>
            <table>
            <tr>
                <td style="font-family: Arial, Helvetica, sans-serif">
                User ID</td>
                <td><asp:TextBox ID="txtUserID"  CssClass="tb" runat="server" Width="47px"></asp:TextBox>
                </td>
            </tr>
                        <tr>
                <td>
                </td>
                <td><asp:Button ID="Button1" CssClass="BlueButton" runat="server" Text="Get Compensation" 
                        onclick="Button1_Click" Width="133px" />
                </td>
            </tr>
            <tr>
                <td style="font-family: Arial, Helvetica, sans-serif">
                    Basic Pay</td>
                <td>
                    <asp:TextBox ID="txtBasicPay"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Daily Rate</td>
                <td>
                    <asp:TextBox ID="txtDailyRate"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Working Hours</td>
                <td>
                    <asp:TextBox ID="txtWorkingHrs"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Per Hour Rate</td>
                <td>
                    <asp:TextBox ID="txtPerHrRate"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Per Minute Rate</td>
                <td>
                    <asp:TextBox ID="txtPerMinuteRate"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    No. of Minute Late</td>
                <td>
                    <asp:TextBox ID="txtNoOfLate"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Late Deductions</td>
                <td>
                    <asp:TextBox ID="txtLateDeductions"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    No. of Days Absent</td>
                <td >
                    <asp:TextBox ID="txtNoOfAbsent"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    Absent Deductions</td>
                <td >
                    <asp:TextBox ID="txtAbsentDeduction"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    No. of Minute Undertime</td>
                <td >
                    <asp:TextBox ID="txtNoOfUndertime"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    Undertime Deductions</td>
                <td >
                    <asp:TextBox ID="txtUndertimeDeduction"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    Night Differential Hours</td>
                <td >
                    <asp:TextBox ID="txtNightDiffHrs"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    Total Night Differential
                </td>
                <td >
                    <asp:TextBox ID="TextBox14"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    Night Differential</td>
                <td >
                    <asp:TextBox ID="txtNightDifferential"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                Transport Allowance</td>
                <td >
                    <asp:TextBox ID="txtTransportAllowance"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                Meal Allowance </td>
                <td >
                    <asp:TextBox ID="txtMealAllowance"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                Rice Subsidy</td>
                <td >
                    <asp:TextBox ID="txtRiceSubsidy"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                Laundry</td>
                <td >
                    <asp:TextBox ID="txtLaundry"  CssClass="tb" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            </table>
            </div>
  <center>
    <div class="button"></div></center>
    </div><!--end of wokring Area-->
    </div><!--end of container-->
    </div><!--end of wrapper-->
    </form>
</body>
</html>
