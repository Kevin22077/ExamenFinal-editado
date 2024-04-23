<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agente_Vista.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Agente_Vista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../CSS/Boton.css" rel="stylesheet" />
    <link href="../CSS/General.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" method="post" runat="server">
        <h1>Gestión de Agentes</h1>

    <form id="formAgregarAgente" onsubmit="agregarAgente(); return false;">
        <label for="nombre">Nombre:</label>
        <input type="text" id="nombre" name="nombre" required><br>
        <label for="email">Email:</label>
        <input type="email" id="email" name="email" required><br>
        <label for="telefono">Teléfono:</label>
        <input type="tel" id="telefono" name="telefono" required><br>
        <asp:Button ID="bagregar"  class="btn-submit" runat="server" Text="Agregar" OnClick="bagregar_Click" Width="301px" />
    </form>

    <form id="formBorrarAgente" onsubmit="borrarAgente(); return false;">
        <label for="idBorrar">ID del Agente:</label>
        <input type="text" id="idBorrarA" name="idBorrar" required="required"><br><br>
        <asp:Button ID="BotonBorrar" class="btn-submit" runat="server" Text="Borrar" OnClick="BotonBorrar_Click" Width="301px" />
    </form>

    <form id="formModificarAgente" onsubmit="modificarAgente(); ">
        <label for="idModificar">ID del Agente:</label>
        <input type="number" id="idModificar" name="idModificar" required><br>
        <label for="nombreModificar">Nuevo Nombre:</label>
        <input type="text" id="nombreModificar" name="nombreModificar"><br>
        <label for="emailModificar">Nuevo Email:</label>
        <input type="email" id="emailModificar" name="emailModificar"><br>
        <label for="telefonoModificar">Nuevo Teléfono:</label>
        <input type="tel" id="telefonoModificar" name="telefonoModificar"><br>
        <button type="submit">Modificar Agente</button>
        <asp:Button ID="bmodificar" class="btn-submit" runat="server" Text="Modificar" OnClick="bmodificar_Click" Width="301px" />
    </form>

        <div>
<asp:Button ID="bregresar" class="btn-submit" runat="server" Text="Regresar" OnClick="bregresar_Click" />
        </div>
        
    </form>
</body>
</html>
