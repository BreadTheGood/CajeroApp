using CapaMOD;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace CapaDAL

{
    public class Conexion
    {
        string cadenaConexion = "data source=DESKTOP-OP8M32M\\SQLEXPRESS; initial catalog=CAJEROAPP_DB; integrated security=sspi";
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();


        //PRODUCTO
        public List<Producto> LeerProducto()
        {
            List<Producto> listaProducto = new List<Producto>();

            SqlDataReader lector;

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Productos";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Producto aux = new Producto();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.Precio = lector.GetInt32(2);


                listaProducto.Add(aux);
            }
            conexion.Close();
            return listaProducto;
        }

        public void AgregarProducto(Producto nuevo)
        {

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "insert into Productos values (@nombre,@precio)";

            comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@precio", nuevo.Precio);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public void EliminarProducto(Producto eliminado)
        {

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "delete from Productos where Id= " + eliminado.Id;
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarProducto(Producto modificado)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "update Productos set Nombre=@nombre,Precio=@marca Where Id=" + modificado.Id;
            comando.Parameters.AddWithValue("@nombre", modificado.Nombre);
            comando.Parameters.AddWithValue("@precio", modificado.Precio);


            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();

        }
        public List<Producto> BuscarProducto(string buscado)
        {
            List<Producto> listaProducto = new List<Producto>();

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Productos WHERE Nombre LIKE @buscado";

            comando.Parameters.AddWithValue("@buscado", "%" + buscado + "%");
            comando.Connection = conexion;

            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Producto aux = new Producto();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.Precio = lector.GetInt32(2);


                listaProducto.Add(aux);
            }
            lector.Close();

            comando.Parameters.Clear();
            conexion.Close();
            return listaProducto;
        }

        // PROVEEDOR
        public List<Proveedor> LeerProveedor()
        {
            List<Proveedor> listaProveedor = new List<Proveedor>();

            SqlDataReader lector;

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Proveedores";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Proveedor aux = new Proveedor();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.Telefono = lector.GetString(2);
                aux.Mail = lector.GetString(3);


                listaProveedor.Add(aux);
            }
            conexion.Close();


            return listaProveedor;
        }

        public void AgregarProveedor(Proveedor nuevo)
        {

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "insert into Proveedores values (@nombre, @telefono, @mail)";

            comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@telefono", nuevo.Telefono);
            comando.Parameters.AddWithValue("@mail", nuevo.Mail);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public void EliminarProveedor(Proveedor eliminado)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Proveedores WHERE Id = @id";

            comando.Parameters.AddWithValue("@id", eliminado.Id);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public void ModificarProveedor(Proveedor modificado)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE Proveedores SET Nombre = @nombre, Telefono = @telefono, Mail = @mail WHERE Id = @id";

            comando.Parameters.AddWithValue("@nombre", modificado.Nombre);
            comando.Parameters.AddWithValue("@telefono", modificado.Telefono);
            comando.Parameters.AddWithValue("@mail", modificado.Mail);
            comando.Parameters.AddWithValue("@id", modificado.Id);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public List<Proveedor> BuscarProveedor(string buscado)
        {
            List<Proveedor> listaProveedor = new List<Proveedor>();

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Proveedores WHERE Nombre LIKE @buscado";

            comando.Parameters.AddWithValue("@buscado", "%" + buscado + "%");
            comando.Connection = conexion;

            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Proveedor aux = new Proveedor();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.Telefono = lector.GetString(2);
                aux.Mail = lector.GetString(3);

                listaProveedor.Add(aux);
            }
            lector.Close();

            comando.Parameters.Clear();
            conexion.Close();
            return listaProveedor;
        }


        // EMPLEADO
        public List<Empleado> LeerEmpleado()
        {
            List<Empleado> listaEmpleado = new List<Empleado>();

            SqlDataReader lector;

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Empleado aux = new Empleado();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.Cargo = lector.GetString(2);
                aux.Salario = lector.GetString(3);


                listaEmpleado.Add(aux);
            }
            conexion.Close();
            return listaEmpleado;
        }

        public void AgregarEmpleado(Empleado nuevo)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO Empleados (Nombre, Cargo, Salario) VALUES (@nombre, @cargo, @salario)";

            comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@cargo", nuevo.Cargo);
            comando.Parameters.AddWithValue("@salario", nuevo.Salario);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public void EliminarEmpleado(Empleado eliminado)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Empleados WHERE Id = @id";

            comando.Parameters.AddWithValue("@id", eliminado.Id);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public void ModificarEmpleado(Empleado modificado)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE Empleados SET Nombre = @nombre, Cargo = @cargo, Salario = @salario WHERE Id = @id";

            comando.Parameters.AddWithValue("@nombre", modificado.Nombre);
            comando.Parameters.AddWithValue("@cargo", modificado.Cargo);
            comando.Parameters.AddWithValue("@salario", modificado.Salario);
            comando.Parameters.AddWithValue("@id", modificado.Id);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public List<Empleado> BuscarEmpleado(string buscado)
        {
            List<Empleado> listaEmpleado = new List<Empleado>();

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Empleados WHERE Nombre LIKE @buscado";

            comando.Parameters.AddWithValue("@buscado", "%" + buscado + "%");
            comando.Connection = conexion;

            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleado aux = new Empleado();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.Cargo = lector.GetString(2);
                aux.Salario = lector.GetString(3);

                listaEmpleado.Add(aux);
            }
            lector.Close();

            comando.Parameters.Clear();
            conexion.Close();
            return listaEmpleado;
        }
        // USUARIO
        public List<Usuario> LeerUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            SqlDataReader lector;

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Usuarios";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Usuario aux = new Usuario();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.TipoUsuario = lector.GetString(2);



                listaUsuario.Add(aux);
            }
            conexion.Close();
            return listaUsuario;
        }

        public void AgregarUsuario(Usuario nuevo)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO Usuarios (Nombre, TipoUsuario) VALUES (@nombre, @tipo)";

            comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@tipo", nuevo.TipoUsuario);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public void EliminarUsuario(Usuario eliminado)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Usuarios WHERE Id = @id";

            comando.Parameters.AddWithValue("@id", eliminado.Id);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public void ModificarUsuario(Usuario modificado)
        {
            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE Usuarios SET Nombre = @nombre, TipoUsuario = @tipo WHERE Id = @id";

            comando.Parameters.AddWithValue("@id", modificado.Id);
            comando.Parameters.AddWithValue("@nombre", modificado.Nombre);
            comando.Parameters.AddWithValue("@tipo", modificado.TipoUsuario);


            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();
        }

        public List<Usuario> BuscarUsuario(string buscado)
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            conexion.ConnectionString = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Usuarios WHERE Nombre LIKE @buscado";

            comando.Parameters.AddWithValue("@buscado", "%" + buscado + "%");
            comando.Connection = conexion;

            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Usuario aux = new Usuario();
                aux.Id = lector.GetInt32(0);
                aux.Nombre = lector.GetString(1);
                aux.TipoUsuario = lector.GetString(2);

                listaUsuario.Add(aux);
            }
            lector.Close();

            comando.Parameters.Clear();
            conexion.Close();
            return listaUsuario;
        }
    }
}
