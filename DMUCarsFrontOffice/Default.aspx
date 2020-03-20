<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            background-color: #99CCFF;
        }
    </style>
</head>
<body style="width: 478px; height: 418px">
    <form id="form1" runat="server">
        <div>
            <body Default = "" style="width: 478px; height: 418px">
        </div>
        <asp:ListBox ID="lstStaff" runat="server" Height="162px" Width="430px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="background-color: #66FF99"></asp:ListBox>
        <div>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Enter Your Phone Number"></asp:Label>
        <br />
        <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplay" runat="server" Text="Display All" OnClick="btnDisplay_Click" />
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="BtnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
    </form>
</body>
</html>