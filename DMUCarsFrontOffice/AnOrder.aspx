<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 409px;
        }
        #form3 {
            height: 382px;
        }
        .auto-style1 {
            background-color: #00CC00;
        }
        .auto-style2 {
            background-color: #33CC33;
        }
        .auto-style3 {
            text-decoration: underline;
            font-weight: 700;
        }
    </style>
</head>
<body style="background-color: #0000FF">
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID" CssClass="auto-style3"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 28px" CssClass="auto-style1"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" CssClass="auto-style3"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="margin-left: 34px" CssClass="auto-style1"></asp:TextBox>
        <p>
            <asp:Label ID="lblDeliveryDate" runat="server" Text="Delivery Date" CssClass="auto-style3"></asp:Label>
            <asp:TextBox ID="txtDeliveryDate" runat="server" style="margin-left: 18px" CssClass="auto-style2"></asp:TextBox>
        </p>
        <asp:Label ID="lblCarID" runat="server" Text="Car ID" CssClass="auto-style3"></asp:Label>
        <asp:TextBox ID="txtCarID" runat="server" style="margin-left: 32px" Width="147px" CssClass="auto-style2"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaff" runat="server" Text="StaffID" CssClass="auto-style3"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" CssClass="auto-style2"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" style="margin-left: 26px" Text="Ok" Width="77px" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="79px" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
