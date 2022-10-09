<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataSender.aspx.cs" Inherits="WebForms4thOctCachingDemo.DataSender" %>
<%@ OutputCache CacheProfile="cacheDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>SelectItem</asp:ListItem>
            <asp:ListItem Value="10">Purchase</asp:ListItem>
            <asp:ListItem Value="20">Sales</asp:ListItem>
            <asp:ListItem Value="30">Training</asp:ListItem>
            <asp:ListItem Value="40">Development</asp:ListItem>
            <asp:ListItem Value="50">HR</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:TextBox ID="txtid" runat="server" AutoPostBack="True" OnTextChanged="txtid_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
