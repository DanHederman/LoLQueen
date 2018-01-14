<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoLQueen.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 232px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Insert Summoner Name"></asp:Label>
            <asp:TextBox ID="SummonerName"  runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Go" OnClick="SubmitSummonerName" />
        </div>
        <p>
            Summoner Name:
            <asp:Label ID="summonerNameLabel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            Summoner Level:
            <asp:Label ID="summonerLevelLabel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            Summoner ID:
            <asp:Label ID="summonerAccIdLabel" runat="server" Text=""></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="RedirectOW" Text="OverWatch" />
    </form>
</body>
</html>
