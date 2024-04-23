<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ExamenFinal.Presentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../CSS/Login.css" rel="stylesheet" />
     <style>
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
                <label for="username">Usuario:</label>
                <input type="text" id="username" name="username" required>
            </div>
            <div class="form-group">
                <label for="password">Contraseña:</label>
                <input type="password" id="password" name="password" required>
            </div>
            <asp:Button ID="Button1" class="btn-submit" runat="server" Text="Iniciar Sesión" OnClick="Button1_Click" />
     </form>
</body>
</html>
