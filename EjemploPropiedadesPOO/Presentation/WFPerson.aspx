﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFPerson.aspx.cs" Inherits="Presentation.WFPerson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Desde persona"></asp:Label><br />
             <asp:Label ID="Lblmsj31" runat="server" Text=""></asp:Label><br />


            <%--Cajas de texto para ingresar los datos--%>
            <asp:Label ID="Label12" runat="server" Text="Ojos: "></asp:Label>
            <asp:TextBox ID="TBEyes" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Edad: "></asp:Label>
            <asp:TextBox ID="TBEge" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Documento: "></asp:Label>
            <asp:TextBox ID="TBDocument" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label16" runat="server" Text="Estatura: "></asp:Label>
            <asp:TextBox ID="TBHeight" runat="server"></asp:TextBox><br />

            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

        </div>
    </form>
</body>
</html>
