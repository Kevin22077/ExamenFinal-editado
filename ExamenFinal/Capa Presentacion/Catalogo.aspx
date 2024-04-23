<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Venta_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../CSS/MCircular.css" rel="stylesheet" />
    <link href="../CSS/Gridview.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h2>Catalogos:</h2>

        <div>
            <h2>Catalogode Agentes:
            <asp:Button ID="BCatalogoA" runat="server" Text="Generar" OnClick="BCatalogoA_Click" /><br />
                Catalogo de Clientes:
            <asp:Button ID="BCatalogoC" runat="server" Text="Generar" OnClick="BCatalogoC_Click" /><br />
                Catalogo de Ventas:
            <asp:Button ID="BCatalogoV" runat="server" Text="Generar" OnClick="BCatalogoV_Click" /><br />
                Catalogo de Casas:
            <asp:Button ID="BCatalogoCa" runat="server" Text="Generar" OnClick="BCatalogoCa_Click" /><br />
                <br />
                <asp:Button ID="bback" runat="server" Text="Regresar" OnClick="bback_Click" />
                <asp:GridView ID="GridViewReporte" class="myGridClass" runat="server"></asp:GridView>
            </h2>
        </div>
    </form>
</body>
</html>
