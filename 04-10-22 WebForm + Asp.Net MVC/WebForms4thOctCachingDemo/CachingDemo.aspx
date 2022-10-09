<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CachingDemo.aspx.cs" Inherits="WebForms4thOctCachingDemo.CachingDemo" %>
<%@ OutputCache Duration="10"  VaryByParam="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Time:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Name :<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;<p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" style="width: 56px" />
        </p>
    </form>
</html>
