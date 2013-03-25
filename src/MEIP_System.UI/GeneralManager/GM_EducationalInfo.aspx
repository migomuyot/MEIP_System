<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_EducationalInfo.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_EducationalInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .tb
        {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <asp:GridView ID="GridViewEducInfo" runat="server" 
                onselectedindexchanged="GridViewEducInfo_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
        <br />
        </center>
        <center>
     <table  style="font-family: Arial, Helvetica, sans-serif" cellspacing="0">
    <tr>
    <td>Educational Info ID:</td>
    <td><asp:TextBox ID="txtEducInfoID" CssClass="tb" runat="server" required 
            ReadOnly="True" Width="46px"></asp:TextBox></td>
    </tr>
    <tr>
    <td>School:</td>
    <td><asp:TextBox ID="txtGraduateSchool" CssClass="tb" runat="server" required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Degree:</td>
    <td>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="123px">
            <asp:ListItem>Bachelors</asp:ListItem>
            <asp:ListItem>Masters</asp:ListItem>
            <asp:ListItem>PhD</asp:ListItem>
            <asp:ListItem>Doctorate</asp:ListItem>
        </asp:DropDownList>
    </td>
    <tr>
    <td></td>
    <td>
        <asp:TextBox ID="txtDegree" runat="server" ReadOnly="True"></asp:TextBox></td>
    </tr>
    </tr>
    <tr>
    <td>Course Taken:</td>
    <td><asp:TextBox ID="txtCourseTaken" CssClass="tb" runat="server" required></asp:TextBox></td>
    </tr>
    <tr>
    <td>Year Graduated:</td>
    <td><asp:TextBox ID="txtYearGraduated" CssClass="tb" runat="server" required></asp:TextBox></td>
    </tr>
    <tr>
    <td></td>
    <td><asp:Button ID="ButtonAddEducInfo" runat="server" CssClass="BlueButton" Text="Add Information" 
            onclick="ButtonAddEducInfo_Click" Width="128px" /></td>
    </tr>
    <tr>
    <td></td>
    <td>    
        <asp:Button ID="ButtonUpdateEducInfo" runat="server" CssClass="BlueButton" Text="Edit Information" 
            onclick="ButtonUpdateEducInfo_Click" Width="128px" /></td></td></tr>
   </table>
   </center>
    </div>
    </form>
</body>
</html>
