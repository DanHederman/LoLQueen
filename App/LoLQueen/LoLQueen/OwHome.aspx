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
&nbsp;&nbsp;Hero Name: &nbsp;
        &nbsp;<asp:TextBox ID="HeroNameBox" runat="server"></asp:TextBox>
        <p>
        &nbsp;&nbsp;&nbsp;Hero Tag:
            <asp:TextBox ID="HeroTag" runat="server"></asp:TextBox>
        </p>
        <p style="width: 141px">
            <asp:Image ID="PlayerImg" ImageUrl="" runat="server" Height="123px" Width="127px" />
        &nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Heros Name"></asp:Label>
            :
        <asp:Label ID="HeroName" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Hero Level"></asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="HeroLevel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="LoLQueen" OnClick="RedirectToLoL" />
            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="RedirectHome" />
        </p>
        <p>
        <asp:Button ID="Button3" runat="server" Text="GenerateData" OnClick="DataGen" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="CompWin" runat="server" Text="won"></asp:Label>
            <asp:Image ID="RankImg" ImageUrl="" runat="server" Height="145px" Width="152px" />
        </p>
    </form>
</body>
</html>
