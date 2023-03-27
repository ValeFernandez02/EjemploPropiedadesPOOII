<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFPerson.aspx.cs" Inherits="Presentation.WFPerson" %>

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
            <asp:Label ID="Label12" runat="server" Text="Nombres: "></asp:Label>
            <asp:TextBox ID="TBNombres" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label14" runat="server" Text="Apellidos: "></asp:Label>
            <asp:TextBox ID="TBApellidos" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label15" runat="server" Text="Documento: "></asp:Label>
            <asp:TextBox ID="TBDocument" runat="server"></asp:TextBox><br />

             <asp:Label ID="Label3" runat="server" Text="Sueldo: "></asp:Label>
            <asp:TextBox ID="TBSueldo" runat="server"></asp:TextBox><br />

             <%--<asp:Label ID="Label16" runat="server" Text="Estatura: "></asp:Label>
            <asp:TextBox ID="TBHeight" runat="server"></asp:TextBox><br />--%>

            <asp:Label ID="Label2" runat="server" Text="Seleccione tipo de Contrato"></asp:Label><br />
            <asp:DropDownList ID="DDLTipoContrato" runat="server"> 
                 <asp:ListItem Value = "0" >Seleccione</asp:ListItem>
            <asp:ListItem Value = "Fijo" >Fijo</asp:ListItem>
            <asp:ListItem Value = "Indefinido" >Indefinido</asp:ListItem>
            <asp:ListItem Value = "Obra o labor" >Obra o Labor</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Button ID="BTEnviar" runat="server" Text="Enviar" Height="29px" OnClick="BTEnviar_Click" Width="68px" />

            <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
