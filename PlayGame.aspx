<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayGame.aspx.cs" Inherits="TTT.PlayGame" %>

<!DOCTYPE html>

<style>

    table {
        width: 200px; min-height: 50px; line-height: 50px; text-align: center; border-collapse: collapse;
    }
</style>

<script>


</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tic-Tac-Toe</title>
</head>
<body>
    <form id="form1" runat="server" method="get" style="text-align:center">
    <div>
        <h1>Welcome to Tic-Tac-Toe</h1>
        <h2>Turn: <asp:literal id="DisplayTurn" runat="server"></asp:literal></h2>
        <br />
        <h3><asp:literal id="result" runat="server"></asp:literal></h3><br />
    </div>
        <table align="center" runat="server">
            <tr>
                <td>
                    <asp:Button ID="btn11" runat="server" Text="-" onclick="btn11_OnClick"/>
                    <asp:literal id="literal11" runat="server"></asp:literal>
                </td>
                <td>
                    <asp:Button ID="btn12" runat="server" Text="-" onclick="btn12_OnClick" />
                    <asp:literal id="literal12" runat="server"></asp:literal>
                </td>
                <td>
                    <asp:Button ID="btn13" runat="server" Text="-" onclick="btn13_OnClick" />
                    <asp:literal id="literal13" runat="server"></asp:literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn21" runat="server" Text="-" onclick="btn21_OnClick" />
                    <asp:literal id="literal21" runat="server"></asp:literal>
                </td>
                <td>
                    <asp:Button ID="btn22" runat="server" Text="-" onclick="btn22_OnClick" />
                    <asp:literal id="literal22" runat="server"></asp:literal>
                </td>
                <td>
                    <asp:Button ID="btn23" runat="server" Text="-" onclick="btn23_OnClick" />
                    <asp:literal id="literal23" runat="server"></asp:literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn31" runat="server" Text="-" onclick="btn31_OnClick" />
                    <asp:literal id="literal31" runat="server"></asp:literal>
                </td>
                <td>
                    <asp:Button ID="btn32" runat="server" Text="-" onclick="btn32_OnClick" />
                    <asp:literal id="literal32" runat="server"></asp:literal>
                </td>
                <td>
                    <asp:Button ID="btn33" runat="server" Text="-" onclick="btn33_OnClick" />
                    <asp:literal id="literal33" runat="server"></asp:literal>
                </td>
            </tr>
            <tr>
                <td colspan ="3">
                    <br />
                    <asp:Button ID="resetbtn" runat="server" Text="RESET" onclick="reset_OnClick" />
                </td>
            </tr>
        </table>
        <br />
    </form>
</body>
</html>
