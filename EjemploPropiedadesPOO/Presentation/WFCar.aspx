<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFCar.aspx.cs" Inherits="Presentation.WFCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Desde Car"></asp:Label><br />

            <asp:Label ID="Lblmsj10" runat="server" Text=""></asp:Label><br />

            
            <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="Color: "></asp:Label>
            <asp:TextBox ID="TBColor" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Modelo: "></asp:Label>
            <asp:TextBox ID="TBModelo" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Galones: "></asp:Label>
            <asp:TextBox ID="TBGallons" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Brand: "></asp:Label>
            <asp:TextBox ID="TBBrand" runat="server"></asp:TextBox><br />

            
          
            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

        </div>
    </form>
</body>
</html>
