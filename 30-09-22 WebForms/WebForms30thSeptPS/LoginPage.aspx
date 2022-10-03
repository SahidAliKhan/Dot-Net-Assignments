<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebForms30thSeptPS.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoginPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter User ID:<asp:TextBox ID="txtuserid" runat="server"></asp:TextBox>
            <br />
            Enter Password:<asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnsubmit" runat="server" Text="Login" />
        <p>
            <asp:Label ID="lblcheck" runat="server" ForeColor="Lime"></asp:Label>
            <asp:Label ID="lblcheck2" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Customer SignUp Page to save Cookies:<asp:Button ID="btncustomer" runat="server" OnClick="btncustomer_Click" Text="Click!" />
        </p>
    </form>
</body>
</html>
