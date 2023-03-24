<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFBook.aspx.cs" Inherits="Presentation.WFBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Desde Book"></asp:Label><br />

            <asp:Label ID="Lblmsj35" runat="server" Text=""></asp:Label><br />

                         <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="Nombre del libro: "></asp:Label>
            <asp:TextBox ID="TBNameB" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Paginas del libro: "></asp:Label>
            <asp:TextBox ID="TBPag" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Capitulos del libro: "></asp:Label>
            <asp:TextBox ID="TBChapeters" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Fecha de lanzamiento: "></asp:Label>
            <asp:TextBox ID="TBDate_lounch" runat="server"></asp:TextBox><br />

             <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

        </div>
    </form>
</body>
</html>
