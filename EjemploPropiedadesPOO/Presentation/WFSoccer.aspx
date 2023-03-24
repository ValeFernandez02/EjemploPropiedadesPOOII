<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFSoccer.aspx.cs" Inherits="Presentation.WFSoccer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Desde Soccer"></asp:Label><br />

             <asp:Label ID="Lblmsj33" runat="server" Text=""></asp:Label><br />

             <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="N° Jugadores: "></asp:Label>
            <asp:TextBox ID="TBPlayers" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Tiempo de juego: "></asp:Label>
            <asp:TextBox ID="TBTime" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Equipos: "></asp:Label>
            <asp:TextBox ID="TBEquipamet" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Nombre de juego: "></asp:Label>
            <asp:TextBox ID="TBName" runat="server"></asp:TextBox><br />

            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

        </div>
    </form>
</body>
</html>
