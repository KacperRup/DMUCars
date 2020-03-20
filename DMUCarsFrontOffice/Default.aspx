<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 588px;
            background-color: #0000FF;
        }
        .auto-style1 {
            background-color: #33CC33;
        }
    </style>
</head>
<body style="height: 482px; background-color: #0000FF;">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large; text-decoration: underline; font-style: italic; font-weight: 700" Text="Order Details Page"></asp:Label>
        <br />
        <br />
        <br />
        <asp:ListBox ID="lstOrders" runat="server" Height="214px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged1" Width="123px" CssClass="auto-style1"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerNo" runat="server" Text="Please Enter a CarID" style="font-weight: 700; font-style: italic; text-decoration: underline"></asp:Label>
        <br />
        <asp:ListBox ID="txtCarID" runat="server" Height="40px" Width="126px" OnSelectedIndexChanged="lstCustomerNo_SelectedIndexChanged" CssClass="auto-style1"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" Width="140px" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="margin-left: 21px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="80px" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="margin-left: 21px" Text="Edit" Width="79px" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="margin-left: 26px" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
