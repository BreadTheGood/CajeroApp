using CapaDAL;
using CapaMOD;
using System.Collections.Generic;
using System.Text;

namespace CapaBLL
{
    public class LogicaSolicitudes
    {

        public readonly StringBuilder stringBuilder = new StringBuilder();
        Conexion Conexion = new Conexion();

        //PRODUCTO

        public List<Producto> LeerProducto()
        {
            if (Conexion.LeerProducto() != null)
            {
                return Conexion.LeerProducto();
            }
            return null;
        }

        public void AgregarProducto(Producto nuevo)
        {
            Conexion.AgregarProducto(nuevo);
        }

        public void EliminarProducto(Producto eliminado)
        {
            Conexion.EliminarProducto(eliminado);
        }

        public void ModificarProducto(Producto modificado)
        {
            Conexion.ModificarProducto(modificado);
        }

        public List<Producto> BuscarProducto(string buscado)
        {

            return Conexion.BuscarProducto(buscado);

        }

        //PROVEEDOR

        public List<Proveedor> LeerProveedor()
        {
            if (Conexion.LeerProveedor() != null)
            {
                return Conexion.LeerProveedor();
            }

            return null;
        }

        public void AgregarProveedor(Proveedor nuevo)
        {
            Conexion.AgregarProveedor(nuevo);
        }

        public void EliminarProveedor(Proveedor eliminado)
        {
            Conexion.EliminarProveedor(eliminado);
        }

        public void ModificarProveedor(Proveedor modificado)
        {
            Conexion.ModificarProveedor(modificado);
        }

        public List<Proveedor> BuscarProveedor(string buscado)
        {
            return Conexion.BuscarProveedor(buscado);
        }

        //EMPLEADO

        public List<Empleado> LeerEmpleado()
        {
            if (Conexion.LeerEmpleado() != null)
            {
                return Conexion.LeerEmpleado();
            }

            return null;
        }

        public void AgregarEmpleado(Empleado nuevo)
        {
            Conexion.AgregarEmpleado(nuevo);
        }

        public void EliminarEmpleado(Empleado eliminado)
        {
            Conexion.EliminarEmpleado(eliminado);
        }

        public void ModificarEmpleado(Empleado modificado)
        {
            Conexion.ModificarEmpleado(modificado);
        }

        public List<Empleado> BuscarEmpleado(string buscado)
        {
            return Conexion.BuscarEmpleado(buscado);
        }

        //USUARIO

        public List<Usuario> LeerUsuario()
        {
            if (Conexion.LeerUsuario() != null)
            {
                return Conexion.LeerUsuario();
            }

            return null;
        }

        public void AgregarUsuario(Usuario nuevo)
        {
            Conexion.AgregarUsuario(nuevo);
        }

        public void EliminarUsuario(Usuario eliminado)
        {
            Conexion.EliminarUsuario(eliminado);
        }

        public void ModificarUsuario(Usuario modificado)
        {
            Conexion.ModificarUsuario(modificado);
        }

        public List<Usuario> BuscarUsuario(string buscado)
        {
            return Conexion.BuscarUsuario(buscado);
        }


    }
}
