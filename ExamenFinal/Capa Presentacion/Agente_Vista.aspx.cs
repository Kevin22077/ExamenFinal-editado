using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ExamenFinal.Capa_Presentacion
{
    public partial class Agente_Vista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            string nombre = Request.Form["nombre"].ToUpper();
            string email = Request.Form["email"].ToLower();
            string telefono = Request.Form["telefono"];
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=examenfinal;Integrated Security=True";
            string query = "INSERT INTO Agentes (Nombre, Email, Telefono) VALUES (@Nombre, @Email, @Telefono)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefono", telefono);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('Agente creado correctamente')", true);
        }

        protected void bregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menuprincipal.aspx");
        }

        protected void BotonBorrar_Click(object sender, EventArgs e)
        {
            
            int id =int.Parse(Request.Form["idBorrarA"]);
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=examenfinal;Integrated Security=True";
            string query = "DELETE FROM agentes WHERE ID = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}