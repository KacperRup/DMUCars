<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #0000FF">
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="lblConfirmation" runat="server" Text="Are you sure you want to delete this record?" style="font-weight: 700; font-style: italic"></asp:Label>
        </div>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" Text="No" Width="59px" OnClick="BtnNo_Click" />
    </form>
</body>
</html>
