using Microsoft.Data.SqlClient;

namespace Api_CRUD_GestionTareas.Data
{
    public class Connection
    {
        SqlConnection cn = new SqlConnection(@"server=LAPTOP-HUANR20J\SQLEXPRESS; database=GestionTareas_Prueba;Integrated Security=True;TrustServerCertificate=True;");

        public SqlConnection getConnection
        {
            get { return cn; }
        }
    }
}
