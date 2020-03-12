<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="LstStaff" runat="server" Height="162px" Width="430px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <div>
            <asp:Label ID="LblError" runat="server" Text="[lblError]"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="LblPhoneNumber" runat="server" Text="Enter Your Phone Number"></asp:Label>
        <br />
        <asp:TextBox ID="TxtPhoneNo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnApply" runat="server" Text="Apply" />
        <asp:Button ID="BtnDisplay" runat="server" Text="Display All" />
        <br />
        <br />
        <asp:Button ID="BtnAdd" runat="server" Text="Add" OnClick="BtnAdd_Click" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" />
        <asp:Button ID="BtnDelete" runat="server" Text="Delete" />
    </form>
</body>
</html>
