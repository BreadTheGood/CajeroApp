using Microsoft.Data.SqlClient;

namespace CapaDAL

{
    public class Conexion
    {
        private readonly string cadenaConexion = "data source=DESKTOP-OP8M32M\\SQLEXPRESS; initial catalog=CAJEROAPP_DB; integrated security=sspi";
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();

        public List<Producto>
    }
}
