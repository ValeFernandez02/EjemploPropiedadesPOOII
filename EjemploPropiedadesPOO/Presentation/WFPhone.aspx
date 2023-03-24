<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFPhone.aspx.cs" Inherits="Presentation.WFPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Desde Phone"></asp:Label><br />

            <asp:Label ID="Lblmsj30" runat="server" Text=""></asp:Label><br />

             <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="Marca: "></asp:Label>
            <asp:TextBox ID="TBBrand" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Color: "></asp:Label>
            <asp:TextBox ID="TBColor" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Serial: "></asp:Label>
            <asp:TextBox ID="TBSeries1" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Modelo: "></asp:Label>
            <asp:TextBox ID="TBModelo" runat="server"></asp:TextBox><br />

            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />
        </div>
    </form>
</body>
</html>
