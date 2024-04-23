<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes_View.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Clientes_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style>
        
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title><link href="../CSS/Clientes.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <h1>Gestión de Clientes</h1>

    <form id="formAgregarCliente" onsubmit="agregarCliente(); return false;">
        <label for="nombre">Nombre:</label>
        <input type="text" id="nombre" name="nombre" required><br>
        <label for="email">Email:</label>
        <input type="email" id="email" name="email" required><br>
        <label for="telefono">Teléfono:</label>
        <input type="tel" id="telefono" name="telefono" required><br>
        <button type="submit">Agregar Cliente</button>
    </form>

    <form id="formEliminarCliente" onsubmit="borrarCliente(); return false;">
        <label for="idBorrar">ID del Cliente:</label>
        <input type="number" id="idBorrarC" name="idBorrar" required><br>
        <button type="submit">Borrar Cliente</button>
    </form>

    <form id="formModificarCliente" onsubmit="modificarCliente(); return false;">
        <label for="idModificar">ID del Cliente:</label>
        <input type="number" id="idModificar" name="idModificar" required><br>
        <label for="nombreModificar">Nuevo Nombre:</label>
        <input type="text" id="nombreModificar" name="nombreModificar"><br>
        <label for="emailModificar">Nuevo Email:</label>
        <input type="email" id="emailModificar" name="emailModificar"><br>
        <label for="telefonoModificar">Nuevo Teléfono:</label>
        <input type="tel" id="telefonoModificar" name="telefonoModificar"><br>
        <button type="submit">Modificar Cliente</button>
    </form>

    <script>
        function agregarCliente() {
            var nombre = document.getElementById("nombre").value;
            var email = document.getElementById("email").value;
            var telefono = document.getElementById("telefono").value;

            // Aquí enviar la información del nuevo cliente al servidor para agregarlo a la base de datos
            console.log("Nuevo cliente:");
            console.log("Nombre: " + nombre);
            console.log("Email: " + email);
            console.log("Teléfono: " + telefono);

            // Limpiar el formulario después de agregar el cliente
            document.getElementById("formAgregarCliente").reset();
        }

        function borrarCliente() {
            var idBorrar = document.getElementById("idBorrar").value;

            // Aquí enviar la solicitud al servidor para borrar el cliente con el ID proporcionado
            console.log("Borrar cliente con ID: " + idBorrar);

            // Limpiar el formulario después de borrar el cliente
            document.getElementById("formBorrarCliente").reset();
        }

        function modificarCliente() {
            var idModificar = document.getElementById("idModificar").value;
            var nombre = document.getElementById("nombreModificar").value;
            var email = document.getElementById("emailModificar").value;
            var telefono = document.getElementById("telefonoModificar").value;
    </form>
</body>
</html>
