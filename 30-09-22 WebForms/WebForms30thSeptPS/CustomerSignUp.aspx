<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerSignUp.aspx.cs" Inherits="WebForms30thSeptPS.CustomerSignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer SignUp</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Customer Personal Details:<br />
            <br />
            Enter First Name:<asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            <br />
            Enter Last Name:<asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            <br />
            Enter Date of Birth:<asp:TextBox ID="dateDOB" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            Enter State:<asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
            <br />
            Enter City:<asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
        <asp:Label ID="lbl1" runat="server" ForeColor="#00CC00"></asp:Label>
    </form>
</body>
</html>
