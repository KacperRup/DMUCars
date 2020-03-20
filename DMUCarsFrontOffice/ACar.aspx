<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACar.aspx.cs" Inherits="ACar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
        body {
         background-color:lightseagreen;
        }
    </style>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCarID" runat="server" Text="CarID:"></asp:Label>
            <asp:TextBox ID="txtCarID" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCarBrand" runat="server" Text="CarBrand:"></asp:Label>
            <asp:TextBox ID="txtCarBrand" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCarModel" runat="server" Text="CarModel:"></asp:Label>
            <asp:TextBox ID="txtCarModel" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCarColour" runat="server" Text="CarColour:"></asp:Label>
            <asp:TextBox ID="txtCarColour" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCarPrice" runat="server" Text="CarPrice:"></asp:Label>
            <asp:TextBox ID="txtCarPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="CarYearProduced" runat="server" Text="CarYearProduced:"></asp:Label>
            <asp:TextBox ID="txtCarYearProduced" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
