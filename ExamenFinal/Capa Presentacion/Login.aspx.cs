using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = Request.Form["username"];
                string contrasena = Request.Form["password"];

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('Por favor, completa todos los campos.');", true);
                    return;
                }
                else if (!Regex.IsMatch(contrasena, @"^\d+$"))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('Por favor, ingresa únicamente números en el campo de contraseña.');", true);
                    return;
                }

                string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @username AND contrasena = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar parámetros a la consulta
                        command.Parameters.AddWithValue("@username", usuario);
                        command.Parameters.AddWithValue("@password", contrasena);

                        // Ejecutar la consulta y obtener el resultado
                        int count = (int)command.ExecuteScalar();

                        // Verificar si se encontró un usuario con las credenciales proporcionadas
                        if (count > 0)
                        {
                            // Credenciales válidas, redireccionar a la página principal o realizar alguna acción
                            Response.Redirect("/MenuP.aspx");
                        }
                        else
                        {
                            // Credenciales inválidas, mostrar un mensaje de error
                            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('Usuario o contraseña incorrectos. Intentelo nuevamente');", true);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Se produjo un error durante el proceso de inicio de sesión: " + ex.Message);
            }
        }
    }
    
}