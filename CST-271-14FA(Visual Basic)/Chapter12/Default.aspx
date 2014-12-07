<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblName" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="#3399FF" Text="Market Foods" ToolTip="Hello world."></asp:Label>
        <br />
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Store Number:                                                                "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlStoreNumber" runat="server" Height="49px" Width="103px">
                <asp:ListItem>1001</asp:ListItem>
                <asp:ListItem>1002</asp:ListItem>
                <asp:ListItem>1003</asp:ListItem>
                <asp:ListItem>1004</asp:ListItem>
                <asp:ListItem>1005</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Manager:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblManager" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        Assistant:&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblAssistant" runat="server"></asp:Label>
    </form>
</body>
</html>
