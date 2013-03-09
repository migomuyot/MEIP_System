<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GM_SearchEmployees.aspx.cs" Inherits="MEIP_System.UI.GeneralManager.GM_SearchEmployees" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Search Employee"></asp:Label>
    <div>
    
        <asp:TextBox ID="txtSearchEmployee" runat="server" EnableTheming="True"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSearchEmployee" runat="server" 
            onclick="btnSearchEmployee_Click" Text="Search Employee" Width="123px" />
        <br />
        <asp:GridView ID="grdSearchEmployee" runat="server" AllowPaging="True" 
            onpageindexchanging="grdSearchEmployee_PageIndexChanging" >
        </asp:GridView>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
