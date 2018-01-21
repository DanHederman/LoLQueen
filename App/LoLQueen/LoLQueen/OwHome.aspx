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
        &nbsp;<asp:TextBox ID="HeroName" runat="server"></asp:TextBox>
        <p>
        &nbsp;&nbsp;&nbsp;Hero Tag:
            <asp:TextBox ID="HeroTag" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Image ID="Image1" ImageUrl="" runat="server" Width="16px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        </p>
        <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Rank"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="LoLQueen" OnClick="RedirectToLoL" />
            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="RedirectHome" />
        </p>
        <p>
        <asp:Button ID="Button3" runat="server" Text="GenerateData" OnClick="DataGen" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label4" runat="server" Text="won"></asp:Label>
            <asp:Image ID="Image2" ImageUrl="" runat="server" />
        </p>
    </form>
</body>
</html>
