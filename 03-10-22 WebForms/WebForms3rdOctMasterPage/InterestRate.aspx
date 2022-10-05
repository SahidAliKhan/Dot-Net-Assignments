<%@ Page Title="" Language="C#" MasterPageFile="~/BankApp.Master" AutoEventWireup="true" CodeBehind="InterestRate.aspx.cs" Inherits="_3rdOctMasterPage.InterestRate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Select to get
    Interest Rates:
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Select</asp:ListItem>
        <asp:ListItem>25Days</asp:ListItem>
        <asp:ListItem>50Days</asp:ListItem>
        <asp:ListItem>365Days</asp:ListItem>
        <asp:ListItem>2Years</asp:ListItem>
    </asp:DropDownList>
</p>
    <p>
        Interest Rate:<asp:TextBox ID="txtinterest" runat="server" OnTextChanged="txtinterest_TextChanged"></asp:TextBox>
</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </p>
    p>
        Select Account Type :
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;Rate </p>
    <p>
        Enter Principal<asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
&nbsp; Enter tenure:
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Calculated Amount" />
    </p>
    <p>
        Calculate Interest : <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
    </p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
