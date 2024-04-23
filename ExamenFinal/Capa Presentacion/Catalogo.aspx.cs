using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinal.Capa_Presentacion
{
    public partial class Venta_View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BCatalogoA_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=examenfinal;Integrated Security=True";
            string query = "SELECT * FROM agentes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                GridViewReporte.DataSource = reader;
                GridViewReporte.DataBind();
                GridViewReporte.HeaderRow.Cells[0].Text = " ID Agente ";
                GridViewReporte.HeaderRow.Cells[1].Text = "Nombre";
                GridViewReporte.HeaderRow.Cells[2].Text = "Email";
                GridViewReporte.HeaderRow.Cells[3].Text = " Telefono ";

            }
        }

        protected void BCatalogoC_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=examenfinal;Integrated Security=True";
            string query = "SELECT * FROM Clientes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                GridViewReporte.DataSource = reader;
                GridViewReporte.DataBind();
                GridViewReporte.HeaderRow.Cells[0].Text = " ID Cliente ";
                GridViewReporte.HeaderRow.Cells[1].Text = "Nombre";
                GridViewReporte.HeaderRow.Cells[2].Text = "Email";
                GridViewReporte.HeaderRow.Cells[3].Text = " Telefono ";

            }
        }

        protected void BCatalogoV_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=examenfinal;Integrated Security=True";
            string query = "SELECT * FROM Ventas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                GridViewReporte.DataSource = reader;
                GridViewReporte.DataBind();
                GridViewReporte.HeaderRow.Cells[0].Text = " ID ";
                GridViewReporte.HeaderRow.Cells[1].Text = "ID Agente";
                GridViewReporte.HeaderRow.Cells[2].Text = "ID Cliente";
                GridViewReporte.HeaderRow.Cells[3].Text = " ID Casa ";
                GridViewReporte.HeaderRow.Cells[4].Text = " Fecha ";

            }
        }

        protected void BCatalogoCa_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=examenfinal;Integrated Security=True";
            string query = "SELECT * FROM Casas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                GridViewReporte.DataSource = reader;
                GridViewReporte.DataBind();
                GridViewReporte.HeaderRow.Cells[0].Text = " ID ";
                GridViewReporte.HeaderRow.Cells[1].Text = "Direccion";
                GridViewReporte.HeaderRow.Cells[2].Text = "Ciudad";
                GridViewReporte.HeaderRow.Cells[3].Text = " Precio ";

            }
        }

        protected void bback_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MenuP.aspx");
        }
    }
}