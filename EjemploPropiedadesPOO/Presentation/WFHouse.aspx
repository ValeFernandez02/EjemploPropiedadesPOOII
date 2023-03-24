<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFHouse.aspx.cs" Inherits="Presentation.WFHouse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Desde House"></asp:Label><br />
            <asp:Label ID="Lblmsj37" runat="server" Text=""></asp:Label><br />

             <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="Habitaciones: "></asp:Label>
            <asp:TextBox ID="TBHabitaciones" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Barrio: "></asp:Label>
            <asp:TextBox ID="TBBarrio" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Baños: "></asp:Label>
            <asp:TextBox ID="TBBaños" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Pisos: "></asp:Label>
            <asp:TextBox ID="TBPisos" runat="server"></asp:TextBox><br />

            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

        </div>
    </form>
</body>
</html>
