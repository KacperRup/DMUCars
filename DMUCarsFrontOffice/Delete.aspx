<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 449px;
            height: 72px;
            background-color: #99CCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirmation" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="BtnYes" runat="server" Text="Yes" OnClick="BtnYes_Click" />
        <asp:Button ID="BtnNo" runat="server" Text="No" Width="59px" />
    </form>
</body>
</html>
