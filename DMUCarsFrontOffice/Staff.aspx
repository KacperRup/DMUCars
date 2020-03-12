<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="LblFirstName" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TxtLastName" runat="server" ></asp:TextBox>
        </div>
        <asp:Label ID="LblStart" runat="server" Text="Start Date"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LblStaffNo" runat="server" Text="Staff Phone Number"></asp:Label>
        <asp:TextBox ID="TxtStaffNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffID" runat="server" Text="StaffID"></asp:Label>
        <asp:TextBox ID="TxtboxStaffID" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="LblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="OK" />
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
