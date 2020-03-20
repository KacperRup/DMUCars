<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 408px;
            height: 326px;
            background-color: #99CCFF;
        }
        .auto-style1 {
            width: 409px;
            background-color: #99FF99;
        }
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1 class="auto-style2">Edit Staff Page</h1>
        </div>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
        </div>
        <asp:Label ID="lblStart" runat="server" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffNo" runat="server" Text="Staff Phone Number"></asp:Label>
        <asp:TextBox ID="txtStaffNo" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffID" runat="server" Text="StaffID"></asp:Label>
        <asp:TextBox ID="txtboxStaffID" runat="server" ></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="BtnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
