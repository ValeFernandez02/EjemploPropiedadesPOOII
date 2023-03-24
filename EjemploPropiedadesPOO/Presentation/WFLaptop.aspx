<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFLaptop.aspx.cs" Inherits="Presentation.WFLaptop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Desde Laptop"></asp:Label><br />
            <asp:Label ID="Lblmsj36" runat="server" Text=""></asp:Label><br />

             <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="Marca: "></asp:Label>
            <asp:TextBox ID="TBMarca" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Procesador: "></asp:Label>
            <asp:TextBox ID="TBProcesador" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Tamaño: "></asp:Label>
            <asp:TextBox ID="TBTamaño" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Ram: "></asp:Label>
            <asp:TextBox ID="TBRam" runat="server"></asp:TextBox><br />

            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

        </div>
    </form>
</body>
</html>
