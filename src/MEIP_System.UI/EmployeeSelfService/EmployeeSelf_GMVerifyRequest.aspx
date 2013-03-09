<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeSelf_GMVerifyRequest.aspx.cs" Inherits="MEIP_System.UI.EmployeeSelfService.EmployeeSelf_GMVerifyRequest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <asp:GridView ID="GridViewAllRequests" runat="server" 
            onselectedindexchanged="GridViewAllRequests_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    <br />
        <br />
        <table>
        <tr>
        <td>Request ID:</td>
        <td><asp:TextBox ID="txtRequestID" runat="server" Width="38px" ReadOnly="True"></asp:TextBox></td>
        </tr>
                <tr>
        <td>User ID:</td>
        <td><asp:TextBox ID="txtUserID" runat="server" Width="38px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Request Type:</td>
        <td><asp:TextBox ID="txtRequestType" runat="server" Width="160px"></asp:TextBox></td>
        </tr>
                <tr>
        <td>Date Applied:</td>
        <td><asp:TextBox ID="txtDateApplied" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>From:</td>
        <td><asp:TextBox ID="txtStartDate" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>To:</td>
        <td><asp:TextBox ID="txtEndDate" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr
        <tr>
        <td>Attendance Date Change:</td>
        <td><asp:TextBox ID="txtAttendanceDateChange" runat="server" Width="160px" 
                ReadOnly="True"></asp:TextBox></td>
        </tr>
                <tr>
        <td>Time Change In:</td>
        <td><asp:TextBox ID="txtTimeChangeIn" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Time Change Out:</td>
        <td><asp:TextBox ID="txtTimeChangeOut" runat="server" Width="160px" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Leave Type:</td>
        <td><asp:TextBox ID="txtLeaveType" runat="server" Height="22px" Width="160px" 
                ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Reason:</td>
        <td><asp:TextBox ID="txtReason" runat="server" Height="50px" Width="135px" 
                TextMode="MultiLine" ReadOnly="True"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Remarks:</td>
        <td>
            <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" Width="135px"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>Status:</td>
        <td><asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>APPROVED</asp:ListItem>
            <asp:ListItem>DECLINED</asp:ListItem>
            </asp:DropDownList>
        </td></tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Verify Request" 
            onclick="Button1_Click" />
        <br />
        </center>
    </div>
    </form>
</body>
</html>
