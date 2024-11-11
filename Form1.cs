using Microsoft.Data.SqlClient;

namespace FelixManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProbarConexion();
        }

        private void ProbarConexion()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["FelixElectronicsDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open(); MessageBox.Show("Conexión exitosa.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
    }
}
