<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Propiedades POO"></asp:Label><br />
            <asp:LinkButton ID="LBCar" runat="server" OnClick="LBCar_Click">Car</asp:LinkButton><br />
            <asp:LinkButton ID="LBPhone" runat="server" OnClick="LBPhone_Click">Phone</asp:LinkButton><br />
            <asp:LinkButton ID="LBPerson" runat="server" OnClick="LBPerson_Click">Person</asp:LinkButton><br />
            <asp:LinkButton ID="LBScoccer" runat="server" OnClick="LBScoccer_Click">Soccer</asp:LinkButton><br />
            <asp:LinkButton ID="LBCard" runat="server" OnClick="LBCard_Click">Card</asp:LinkButton><br />
            <asp:LinkButton ID="LBBook" runat="server" OnClick="LBBook_Click">Book</asp:LinkButton><br />
            <asp:LinkButton ID="LBLaptop" runat="server" OnClick="LBLaptop_Click">Laptop</asp:LinkButton><br />
            <asp:LinkButton ID="LBHouse" runat="server" OnClick="LBHouse_Click1">House</asp:LinkButton><br />
 />



            
            <asp:Label ID="LblMsj1" runat="server" Text=""></asp:Label><br />

            
            

            
            <asp:Label ID="Lblmsj9" runat="server" Text=""></asp:Label><br />
            

            <asp:Label ID="Label2" runat="server" Text="">"---Objeto phone1---"</asp:Label><br />
            <asp:Label ID="Lblmsj2" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label10" runat="server" Text="">"---Objeto phone2---"</asp:Label><br />
            <asp:Label ID="Lblmsj11" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label13" runat="server" Text="">"---Objeto phone3---"</asp:Label><br />
            <asp:Label ID="Lblmsj12" runat="server" Text=""></asp:Label><br />


            <asp:Label ID="Label3" runat="server" Text="---objeto soccer---"></asp:Label><br />
            <asp:Label ID="Lblmsj20" runat="server" Text=""></asp:Label><br />


            <asp:Label ID="Label4" runat="server" Text="---objeto laptop---"></asp:Label><br />
            <asp:Label ID="Lblmsj4" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label5" runat="server" Text="---objeto card---"></asp:Label><br />
            <asp:Label ID="Lblmsj5" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label6" runat="server" Text="---objeto book---"></asp:Label><br />
            <asp:Label ID="Lblsmj6" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label7" runat="server" Text="---objeto persona---"></asp:Label><br />
            <asp:Label ID="Lblmsj7" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label8" runat="server" Text="---objeto house---"></asp:Label><br />
            <asp:Label ID="Lblmsj8" runat="server" Text=""></asp:Label><br />


        </div>
    </form>
</body>
</html>
