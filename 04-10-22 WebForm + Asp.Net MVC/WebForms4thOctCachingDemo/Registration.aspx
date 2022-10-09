<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebForms4thOctCachingDemo.Registration" %>
<%@ Register src="CalculatorControl.aspx" tagname="CalculatorControl" tagprefix="uc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ener Name :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            Enter City:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <hr />
        <p>
            &nbsp;</p>
        <uc1:CalculatorControl ID="CalculatorControl1" runat="server" />
    </form>
</body>
</html>
