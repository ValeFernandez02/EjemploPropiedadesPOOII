<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFCard.aspx.cs" Inherits="Presentation.WFCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Desde Card"></asp:Label><BR />
            <asp:Label ID="Lblmsj34" runat="server" Text=""></asp:Label><br />

             <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="Banco: "></asp:Label>
            <asp:TextBox ID="TBBank" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Numero de tarjeta: "></asp:Label>
            <asp:TextBox ID="TBNumber" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="A nombre de : "></asp:Label>
            <asp:TextBox ID="TBOwner" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Fecha de vencimiento: "></asp:Label>
            <asp:TextBox ID="TBData" runat="server"></asp:TextBox><br />

            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

        </div>
    </form>
</body>
</html>
