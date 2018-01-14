<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OwHome.aspx.cs" Inherits="LoLQueen.OwHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="HeroName" runat="server"></asp:TextBox>
&nbsp;<p>
        <asp:Label ID="Label2" runat="server" Text="Rank"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="HeroTag" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="LoLQueen" OnClick="RedirectToLoL" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="RedirectHome" />
        </p>
        <asp:Button ID="Button3" runat="server" Text="GenerateData" OnClick="DataGen" />
    </form>
</body>
</html>
