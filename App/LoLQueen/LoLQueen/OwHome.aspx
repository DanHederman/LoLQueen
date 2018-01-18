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
&nbsp;&nbsp;&nbsp;
        &nbsp;<p>
        &nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" ImageUrl="" runat="server" />
        </p>
        <p>
        <asp:TextBox ID="HeroName" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="HeroTag" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        </p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Rank"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="LoLQueen" OnClick="RedirectToLoL" />
            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="RedirectHome" />
        </p>
        <p>
        <asp:Button ID="Button3" runat="server" Text="GenerateData" OnClick="DataGen" />
        </p>
    </form>
</body>
</html>
