<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptProductID.aspx.cs" Inherits="WebForms30thSeptPS.AcceptProductID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Accept Product ID</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            Enter Product ID:<asp:TextBox ID="txtprodid" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btngetprods" runat="server" OnClick="btngetprods_Click" Text="Get Details" />
        </p>
        <p>
            Product Name:
            <asp:TextBox ID="txtprodname" runat="server"></asp:TextBox>
        </p>
        <p>
            Product Price:<asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
        </p>
        <p>
            Supplier ID:<asp:TextBox ID="txtsupplierid" runat="server"></asp:TextBox>
            </p>
        <p>
            Category ID:<asp:TextBox ID="txtcategoryid" runat="server"></asp:TextBox>
            </p>

    </form>
</body>
</html>
