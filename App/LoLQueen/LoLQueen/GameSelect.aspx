<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameSelect.aspx.cs" Inherits="LoLQueen.GameSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="align-content:center">
        <div>
        </div>
        <asp:ImageButton ID="LoL" runat="server" ImageUrl="~/Images/LoL.png" OnClick="RedirectLoL" Height="211px" Width="525px" ImageAlign="Middle"/>
        <p>
            <asp:ImageButton ID="OverWatch" ImageUrl="~/Images/OW.png" runat="server" OnClick="RedirectOW" Height="213px" Width="522px" ImageAlign="Middle"/>
        </p>
    </form>
</body>
</html>
