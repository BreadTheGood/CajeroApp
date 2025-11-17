using CapaBLL;
using CapaMOD;
using System;
using System.Windows.Forms;


namespace CajeroApp
{
    public partial class VentanaPrincipal : Form
    {
        // Lista de productos provicional
        private string[] listaProductos;
        private string[] listaPrecios;
        public string vista = "vacio :)"; // Guarda la vista actual (venta, producto, proveedor, empleado, usuario)
        public bool nuevo = true;

        public VentanaPrincipal(string user)
        {
            InitializeComponent();

            OcultarControles();

            DeshabilitarBotones();

            // Mostrar interfaz en funcion del tipo de usuario
            switch (user)
            {
                case "Administrador":
                    label_USUARIO.Text = "   CajeroApp - Administrador";
                    break;
                case "Empleado":
                    label_USUARIO.Text = "   CajeroApp - Empleado";
                    button_EMPLEADO.Visible = false;
                    button_USUARIO.Visible = false;
                    break;

            }

            button_SALIR_VOLVER.Tag = "LOGOUT";
        }

        private void CrearDGV(string columna1, string columna2, string columna3)
        {
            if (columna3 == null)
            {
                columna3 = "";
            }
            if (dgv_ELEMENTOS.Columns.Count == 0)
            {
                dgv_ELEMENTOS.Columns.Add("Id", "Id");
                dgv_ELEMENTOS.Columns.Add(columna1, columna1);
                dgv_ELEMENTOS.Columns.Add(columna2, columna2);
                dgv_ELEMENTOS.Columns.Add(columna3, columna3);

                dgv_ELEMENTOS.Columns["Id"].DisplayIndex = 0;
                dgv_ELEMENTOS.Columns[columna1].DisplayIndex = 1;
                dgv_ELEMENTOS.Columns[columna2].DisplayIndex = 2;
                dgv_ELEMENTOS.Columns[columna3].DisplayIndex = 3;

            }
            else
            {
                dgv_ELEMENTOS.Columns.Clear();
                dgv_ELEMENTOS.Columns.Add("Id", "Id");
                dgv_ELEMENTOS.Columns.Add(columna1, columna1);
                dgv_ELEMENTOS.Columns.Add(columna2, columna2);
                dgv_ELEMENTOS.Columns.Add(columna3, columna3);
            }
            if (columna3 == "")
            {
                dgv_ELEMENTOS.Columns.RemoveAt(3);
            }
        }
        private void MostrarControlesBasicos()
        {
            dgv_ELEMENTOS.Visible = true;
            button_AGREGAR.Visible = true;
            button_ELIMINAR.Visible = true;

            if (vista != "venta")
            {

                button_MODIFICAR.Visible = true;
                button_BUSCAR.Visible = true;
            }
        }
        private void botonVolver()
        {
            button_SALIR_VOLVER.BackgroundImage = Properties.Resources.Back_Arrow;
            button_SALIR_VOLVER.Tag = "Back_Row";
        }

        private void OcultarControles()
        {
            textBox_DATO1.Visible = false;
            textBox_NOMBRE.Visible = false;
            dgv_ELEMENTOS.Visible = false;
            comboBox_PRODUCTOS.Visible = false;
            textBox_DATO2.Visible = false;
            textBox_DATO1.Visible = false;
            button_AGREGAR.Visible = false;
            textBox_BUSCAR.Visible = false;
            button_BUSCAR.Visible = false;
            button_ELIMINAR.Visible = false;
            label_TOTAL.Visible = false;
            textBox_TOTAL.Visible = false;
            button_MODIFICAR.Visible = false;
            LimpiarControles();

        }


        private void LimpiarControles()
        {

            switch (vista)
            {
                case "venta":
                    comboBox_PRODUCTOS.SelectedIndex = -1;
                    textBox_NOMBRE.Text = "NOMBRE";
                    textBox_DATO1.Text = "PRECIO";
                    textBox_DATO2.Text = "CANTIDAD";
                    break;
                case "productos":
                    textBox_NOMBRE.Text = "NOMBRE";
                    textBox_DATO1.Text = "PRECIO";
                    break;
                case "empleado":
                    textBox_NOMBRE.Text = "NOMBRE";
                    textBox_DATO1.Text = "CARGO";
                    textBox_DATO2.Text = "SALARIO";
                    break;
                case "usuario":
                    textBox_NOMBRE.Text = "NOMBRE";
                    textBox_DATO1.Text = "TIPO DE USUARIO";
                    break;
                case "proveedores":
                    textBox_NOMBRE.Text = "NOMBRE";
                    textBox_DATO1.Text = "TELEFONO";
                    textBox_DATO2.Text = "MAIL";
                    break;
            }


            textBox_BUSCAR.Text = "BUSCADOR";
            textBox_BUSCAR.ForeColor = System.Drawing.Color.Silver;
            textBox_NOMBRE.ForeColor = System.Drawing.Color.Silver;
            textBox_DATO2.ForeColor = System.Drawing.Color.Silver;
            textBox_DATO1.ForeColor = System.Drawing.Color.Silver;
            textBox_DATO2.Enabled = false;

            if (dgv_ELEMENTOS.Rows.Count != 0)
            {
                if (dgv_ELEMENTOS.Rows[0].IsNewRow)
                {
                    textBox_TOTAL.Text = "TOTAL";
                    textBox_TOTAL.ForeColor = System.Drawing.Color.Silver;
                }
            }
        }

        private void button_SALIR_VOLVER_Click(object sender, System.EventArgs e)
        {
            if (button_SALIR_VOLVER.Tag?.ToString() == "LOGOUT")
            {
                Application.Exit();
            }
            else
            {
                OcultarControles();
                LimpiarControles();
                button_SALIR_VOLVER.Tag = "LOGOUT";
                button_SALIR_VOLVER.BackgroundImage = Properties.Resources.LOGOUT;
            }
        }

        private void button_AGREGAR_Click(object sender, System.EventArgs e)
        {
            switch (vista)
            {
                case "venta":

                    if (comboBox_PRODUCTOS.Text != "" && textBox_DATO2.Text != "CANTIDAD" && textBox_DATO2.Text != "")
                    {

                        dgv_ELEMENTOS.Rows.Add(dgv_ELEMENTOS.Rows.Count, comboBox_PRODUCTOS.Text, textBox_DATO1.Text, textBox_DATO2.Text);

                        LimpiarControles();

                        dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

                        CalcularTotal();

                        DeshabilitarBotones();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un producto e indique la cantidad", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "productos":

                    if (textBox_NOMBRE.Text != "" && textBox_DATO1.Text != "")
                    {
                        agregarProducto();

                        LimpiarControles();

                        dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

                        DeshabilitarBotones();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "proveedores":

                    if (textBox_NOMBRE.Text != "" && textBox_DATO1.Text != "")
                    {
                        agregarProveedor();

                        LimpiarControles();

                        dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

                        DeshabilitarBotones();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "empleado":
                    if (textBox_NOMBRE.Text != "" && textBox_DATO1.Text != "" && textBox_DATO2.Text != "")
                    {
                        agregarEmpleado();
                        LimpiarControles();
                        dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;
                        DeshabilitarBotones();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "usuario":
                    if (textBox_NOMBRE.Text != "" && textBox_DATO1.Text != "")
                    {
                        agregarUsuario();
                        LimpiarControles();
                        dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;
                        DeshabilitarBotones();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;


            }


        }

        private void comboBox_PRODUCTOS_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            int idx = comboBox_PRODUCTOS.SelectedIndex;

            textBox_DATO1.ForeColor = System.Drawing.Color.Black;
            textBox_DATO1.Enabled = false;
            textBox_DATO2.Enabled = true;

            HabilitarBotones();

            if (listaPrecios != null && idx >= 0 && idx < listaPrecios.Length)
            {
                textBox_DATO1.Text = listaPrecios[idx];
            }
            else
            {
                textBox_DATO1.Text = string.Empty;
            }
        }

        private void HabilitarBotones()
        {




            if (vista == "venta" && comboBox_PRODUCTOS.SelectedIndex != -1)
            {
                button_AGREGAR.Enabled = true;
                button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));

                button_ELIMINAR.Enabled = true;
                button_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));

                button_MODIFICAR.Enabled = true;
                button_MODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            }


            else if (textBox_NOMBRE.Text != "NOMBRE" && label_USUARIO.Text == "   CajeroApp - Administrador")
            {
                button_AGREGAR.Enabled = true;
                button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));

                button_ELIMINAR.Enabled = true;
                button_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));

                button_MODIFICAR.Enabled = true;
                button_MODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            }
        }

        private void DeshabilitarBotones()
        {


            button_AGREGAR.Enabled = false;
            button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

            button_ELIMINAR.Enabled = false;
            button_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));

            button_MODIFICAR.Enabled = false;
            button_MODIFICAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));


        }

        private void dgv_ELEMENTOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgv_ELEMENTOS.CurrentCell != null && !dgv_ELEMENTOS.CurrentRow.IsNewRow)
            {
                nuevo = false;
                textBox_DATO1.ForeColor = System.Drawing.Color.Black;
                textBox_DATO2.ForeColor = System.Drawing.Color.Black;
                textBox_NOMBRE.ForeColor = System.Drawing.Color.Black;

                try
                {

                    switch (vista)
                    {
                        case "productos":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_DATO1.Text = dgv_ELEMENTOS.CurrentRow.Cells["Precio"].Value.ToString();

                            break;

                        case "venta":

                            comboBox_PRODUCTOS.Text = dgv_ELEMENTOS.CurrentRow.Cells["Producto"].Value.ToString();
                            textBox_DATO1.Text = dgv_ELEMENTOS.CurrentRow.Cells["Precio"].Value.ToString();
                            textBox_DATO2.Text = dgv_ELEMENTOS.CurrentRow.Cells["Cantidad"].Value.ToString();

                            break;
                        case "empleado":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_DATO1.Text = dgv_ELEMENTOS.CurrentRow.Cells["Cargo"].Value.ToString();
                            textBox_DATO2.Text = dgv_ELEMENTOS.CurrentRow.Cells["Salario"].Value.ToString();


                            break;
                        case "usuario":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_DATO1.Text = dgv_ELEMENTOS.CurrentRow.Cells["TipoUsuario"].Value.ToString();

                            break;
                        case "proveedores":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_DATO1.Text = dgv_ELEMENTOS.CurrentRow.Cells["Telefono"].Value.ToString();
                            textBox_DATO2.Text = dgv_ELEMENTOS.CurrentRow.Cells["MAIL"].Value.ToString();

                            break;


                    }
                    HabilitarBotones();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("El campo producto o nombre no existe", "Error");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                nuevo = true;
                LimpiarControles();
            }
        }
        private void button_BUSCAR_Click(object sender, EventArgs e)
        {

            string buscado = (textBox_BUSCAR.Text ?? "").Trim();

            if (buscado != "BUSCADOR")
            {

                switch (vista)
                {
                    case "productos":
                        cargarProductos(buscado);
                        break;
                    case "proveedores":
                        cargarProveedor(buscado);
                        break;

                    case "empleado":
                        cargarEmpleado(buscado);
                        break;
                    case "usuario":
                        cargarUsuario(buscado);
                        break;

                }

                return;
            }
        }

        private void button_MODIFICAR_Click(object sender, EventArgs e)
        {


            switch (vista)
            {
                case "productos":
                    modificarProducto();
                    cargarProductos(null);
                    break;
                case "proveedores":
                    modificarProveedor();
                    cargarProveedor(null);
                    break;

                case "empleado":
                    modificarEmpleado();
                    cargarEmpleado(null);
                    break;
                case "usuario":
                    modificarUsuario();
                    cargarUsuario(null);
                    break;

            }

            LimpiarControles();
            DeshabilitarBotones();
        }

        private void button_ELIMINAR_Click(object sender, System.EventArgs e)
        {


            if (MessageBox.Show("Quieres eliminar esta fila?", "Confirmación de Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                switch (vista)
                {
                    case "productos":
                        Producto aux = objetoAuxiliarProducto();
                        LogicaSolicitudes conexionProducto = new LogicaSolicitudes();
                        conexionProducto.EliminarProducto(aux);
                        cargarProductos(null);
                        break;
                    case "proveedores":
                        Proveedor aux2 = objetoAuxiliarProveedor();
                        LogicaSolicitudes conexionProveedor = new LogicaSolicitudes();
                        conexionProveedor.EliminarProveedor(aux2);
                        cargarProveedor(null);
                        break;
                    case "empleado":
                        Empleado aux3 = objetoAuxiliarEmpleado();
                        LogicaSolicitudes conexionEmpleado = new LogicaSolicitudes();
                        conexionEmpleado.EliminarEmpleado(aux3);
                        cargarEmpleado(null);
                        break;

                    case "usuario":
                        Usuario aux4 = objetoAuxiliarUsuario();
                        LogicaSolicitudes conexionUsuario = new LogicaSolicitudes();
                        conexionUsuario.EliminarUsuario(aux4);
                        cargarUsuario(null);
                        break;
                }

                MessageBox.Show("Registro eliminado correctamente");






                LimpiarControles();

                DeshabilitarBotones();
            }
        }

        private void CalcularTotal()
        {
            double total = 0;

            try
            {

                foreach (DataGridViewRow row in dgv_ELEMENTOS.Rows)
                {
                    if (row.IsNewRow) continue;

                    double precio = double.Parse(row.Cells["Precio"].Value.ToString());
                    double cantidad = double.Parse(row.Cells["Cantidad"].Value.ToString());

                    total += precio * cantidad;
                }

                textBox_TOTAL.Text = $"${total.ToString()}";

                textBox_TOTAL.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            { MessageBox.Show("No se pudo enviar", "Error"); }

        }

        private void textBox_NOMBRE_Enter(object sender, System.EventArgs e)
        {
            textBox_NOMBRE.Text = "";
            textBox_NOMBRE.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox_DATO1_Enter(object sender, System.EventArgs e)
        {
            textBox_DATO1.Text = "";
            textBox_DATO1.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox_BUSCAR_Enter(object sender, System.EventArgs e)
        {
            textBox_BUSCAR.Text = "";
            textBox_BUSCAR.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox_NOMBRE_Leave(object sender, System.EventArgs e)
        {
            if (textBox_NOMBRE.Text == "")
            {
                textBox_NOMBRE.Text = "NOMBRE";
                textBox_NOMBRE.ForeColor = System.Drawing.Color.Silver;
                DeshabilitarBotones();
            }
            else
            {
                HabilitarBotones();
            }


        }

        private void textBox_DATO1_Leave(object sender, System.EventArgs e)
        {
            if (textBox_DATO1.Text == "")
            {
                textBox_DATO1.Text = "PRECIO";
                textBox_DATO1.ForeColor = System.Drawing.Color.Silver;
            }

        }

        private void textBox_BUSCAR_Leave(object sender, System.EventArgs e)
        {
            if (textBox_BUSCAR.Text == "")
            {
                textBox_BUSCAR.Text = "BUSCADOR";
                textBox_BUSCAR.ForeColor = System.Drawing.Color.Silver;
                textBox_DATO2.DeselectAll();
            }
        }

        private void textBox_DATO2_Enter(object sender, System.EventArgs e)
        {
            textBox_DATO2.Text = "";
            textBox_DATO2.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox_DATO2_Leave(object sender, System.EventArgs e)
        {
            if (textBox_DATO2.Text == "")
            {
                textBox_DATO2.Text = "CANTIDAD";
                textBox_DATO2.ForeColor = System.Drawing.Color.Silver;

            }

        }



        private void resetDGV()
        {
            dgv_ELEMENTOS.DataSource = null;
            dgv_ELEMENTOS.Rows.Clear();
            dgv_ELEMENTOS.Columns.Clear();
            botonVolver();
            OcultarControles();
            LimpiarControles();
            HabilitarBotones();
            MostrarControlesBasicos();
        }


        //VISTA BOTON VENTA:::
        private void button_VENTA_Click(object sender, System.EventArgs e)
        {
            vista = "venta";
            resetDGV();
            LimpiarControles();
            cargarListaProductos();


            dgv_ELEMENTOS.DataSource = null;
            dgv_ELEMENTOS.Rows.Clear();
            dgv_ELEMENTOS.Columns.Clear();

            CrearDGV("Producto", "Precio", "Cantidad");

            botonVolver();

            textBox_DATO1.Visible = true;
            textBox_DATO2.Visible = true;
            comboBox_PRODUCTOS.Visible = true;
            label_TOTAL.Visible = true;
            textBox_TOTAL.Visible = true;
            textBox_NOMBRE.Visible = false;

            button_AGREGAR.Enabled = false;
            button_ELIMINAR.Enabled = false;


        }


        //VISTA BOTON PRODUCTOS:::
        private void button_PRODUCTOS_Click(object sender, System.EventArgs e)
        {
            vista = "productos";
            resetDGV();
            LimpiarControles();
            cargarProductos(null);

            dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;
            textBox_DATO1.Enabled = true;
            textBox_DATO1.Visible = true;


            DeshabilitarBotones();
        }

        private void agregarProducto()
        {
            Producto aux = objetoAuxiliarProducto();

            LogicaSolicitudes conexionProducto = new LogicaSolicitudes();

            conexionProducto.AgregarProducto(aux);
            MessageBox.Show("Los datos se agregaron correctamente", "Confirmación");
            LimpiarControles();
            cargarProductos(null);


        }

        private void modificarProducto()
        {
            Producto aux = objetoAuxiliarProducto();
            LogicaSolicitudes conexionProducto = new LogicaSolicitudes();
            conexionProducto.ModificarProducto(aux);
            MessageBox.Show("Los datos se modificaron correctamente", "Confirmación");
            LimpiarControles();
            cargarProductos(null);
        }

        private void cargarProductos(string buscado)
        {
            try
            {
                LogicaSolicitudes conexionProducto = new LogicaSolicitudes();
                if (buscado != "" && buscado != null)
                {
                    dgv_ELEMENTOS.DataSource = conexionProducto.BuscarProducto(buscado);

                }
                else
                {
                    dgv_ELEMENTOS.DataSource = conexionProducto.LeerProducto();
                }


                dgv_ELEMENTOS.Columns["Id"].DisplayIndex = 0;
                dgv_ELEMENTOS.Columns["Nombre"].DisplayIndex = 1;
                dgv_ELEMENTOS.Columns["Precio"].DisplayIndex = 2;


            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }

        }

        //VISTA BOTON PROVEEDORES:::
        private void button_PROVEEDORES_Click(object sender, System.EventArgs e)
        {
            vista = "proveedores";

            resetDGV();
            LimpiarControles();
            cargarProveedor(null);

            dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;
            textBox_DATO1.Enabled = true;
            textBox_DATO1.Visible = true;
            textBox_DATO2.Enabled = true;
            textBox_DATO2.Visible = true;


            DeshabilitarBotones();
        }

        private void agregarProveedor()
        {
            Proveedor aux = objetoAuxiliarProveedor();

            LogicaSolicitudes conexionProveedor = new LogicaSolicitudes();

            conexionProveedor.AgregarProveedor(aux);
            MessageBox.Show("Los datos se agregaron correctamente", "Confirmación");
            LimpiarControles();
            cargarProveedor(null);


        }

        private void modificarProveedor()
        {
            Proveedor aux = objetoAuxiliarProveedor();
            LogicaSolicitudes conexionProveedor = new LogicaSolicitudes();
            conexionProveedor.ModificarProveedor(aux);
            MessageBox.Show("Los datos se modificaron correctamente", "Confirmación");
            LimpiarControles();
            cargarProveedor(null);
        }


        private void cargarProveedor(string buscado)
        {

            try
            {
                LogicaSolicitudes conexionProveedor = new LogicaSolicitudes();

                if (buscado != "" && buscado != null)
                {
                    dgv_ELEMENTOS.DataSource = conexionProveedor.BuscarProveedor(buscado);

                }
                else
                {
                    dgv_ELEMENTOS.DataSource = conexionProveedor.LeerProveedor();
                }


                dgv_ELEMENTOS.Columns["Id"].DisplayIndex = 0;
                dgv_ELEMENTOS.Columns["Nombre"].DisplayIndex = 1;
                dgv_ELEMENTOS.Columns["Telefono"].DisplayIndex = 2;
                dgv_ELEMENTOS.Columns["Mail"].DisplayIndex = 3;


            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }

        }
        //VISTA BOTON USUARIO:::
        private void button_USUARIO_Click(object sender, System.EventArgs e)
        {


            vista = "usuario";

            resetDGV();
            LimpiarControles();
            cargarUsuario(null);

            dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;
            textBox_DATO1.Enabled = true;
            textBox_DATO1.Visible = true;

            DeshabilitarBotones();
        }

        private void agregarUsuario()
        {
            Usuario aux = objetoAuxiliarUsuario();

            LogicaSolicitudes conexionUsuario = new LogicaSolicitudes();

            conexionUsuario.AgregarUsuario(aux);
            MessageBox.Show("Los datos se agregaron correctamente", "Confirmación");
            LimpiarControles();
            cargarUsuario(null);


        }

        private void modificarUsuario()
        {
            Usuario aux = objetoAuxiliarUsuario();
            LogicaSolicitudes conexionUsuario = new LogicaSolicitudes();
            conexionUsuario.ModificarUsuario(aux);
            MessageBox.Show("Los datos se modificaron correctamente", "Confirmación");
            LimpiarControles();
            cargarUsuario(null);
        }

        private void cargarUsuario(string buscado)
        {

            try
            {
                LogicaSolicitudes conexionUsuario = new LogicaSolicitudes();

                if (buscado != "" && buscado != null)
                {
                    dgv_ELEMENTOS.DataSource = conexionUsuario.BuscarUsuario(buscado);

                }
                else
                {
                    dgv_ELEMENTOS.DataSource = conexionUsuario.LeerUsuario();
                }


                dgv_ELEMENTOS.Columns["Id"].DisplayIndex = 0;
                dgv_ELEMENTOS.Columns["Nombre"].DisplayIndex = 1;
                dgv_ELEMENTOS.Columns["TipoUsuario"].DisplayIndex = 2;


            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }
        }

        //VISTA BOTON EMPLEADO:::
        private void button_EMPLEADO_Click(object sender, System.EventArgs e)
        {


            vista = "empleado";

            resetDGV();
            LimpiarControles();
            cargarEmpleado(null);

            dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;
            textBox_DATO1.Enabled = true;
            textBox_DATO1.Visible = true;
            textBox_DATO2.Enabled = true;
            textBox_DATO2.Visible = true;


            DeshabilitarBotones();
        }

        private void agregarEmpleado()
        {
            Empleado aux = objetoAuxiliarEmpleado();

            LogicaSolicitudes conexionEmpleado = new LogicaSolicitudes();

            conexionEmpleado.AgregarEmpleado(aux);
            MessageBox.Show("Los datos se agregaron correctamente", "Confirmación");
            LimpiarControles();
            cargarEmpleado(null);


        }

        private void modificarEmpleado()
        {
            Empleado aux = objetoAuxiliarEmpleado();
            LogicaSolicitudes conexionEmpleado = new LogicaSolicitudes();
            conexionEmpleado.ModificarEmpleado(aux);
            MessageBox.Show("Los datos se modificaron correctamente", "Confirmación");
            LimpiarControles();
            cargarEmpleado(null);
        }

        private void cargarEmpleado(string buscado)
        {

            try
            {
                LogicaSolicitudes conexionEmpleado = new LogicaSolicitudes();

                if (buscado != "" && buscado != null)
                {
                    dgv_ELEMENTOS.DataSource = conexionEmpleado.BuscarEmpleado(buscado);

                }
                else
                {
                    dgv_ELEMENTOS.DataSource = conexionEmpleado.LeerEmpleado();
                }


                dgv_ELEMENTOS.Columns["Id"].DisplayIndex = 0;
                dgv_ELEMENTOS.Columns["Nombre"].DisplayIndex = 1;
                dgv_ELEMENTOS.Columns["Cargo"].DisplayIndex = 2;
                dgv_ELEMENTOS.Columns["Salario"].DisplayIndex = 3;


            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }
        }


        // AUXILIARES:::
        private void cargarListaProductos()
        {
            try
            {
                LogicaSolicitudes conexionProducto = new LogicaSolicitudes();
                var productos = conexionProducto.LeerProducto();

                int count = productos.Count;
                listaProductos = new string[count];
                listaPrecios = new string[count];

                for (int i = 0; i < count; i++)
                {
                    listaProductos[i] = productos[i].Nombre;
                    listaPrecios[i] = productos[i].Precio.ToString();
                }

                comboBox_PRODUCTOS.Items.Clear();
                comboBox_PRODUCTOS.Items.AddRange(listaProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }
        }




        private Producto objetoAuxiliarProducto()
        {

            Producto aux = new Producto();
            if (!nuevo) aux.Id = int.Parse(dgv_ELEMENTOS.CurrentRow.Cells["Id"].Value.ToString());
            aux.Nombre = textBox_NOMBRE.Text;
            aux.Precio = int.Parse(textBox_DATO1.Text);

            return aux;
        }
        private Proveedor objetoAuxiliarProveedor()
        {

            Proveedor aux = new Proveedor();
            if (!nuevo) aux.Id = int.Parse(dgv_ELEMENTOS.CurrentRow.Cells["Id"].Value.ToString());
            aux.Nombre = textBox_NOMBRE.Text;
            aux.Telefono = textBox_DATO1.Text;
            aux.Mail = textBox_DATO2.Text;

            return aux;
        }
        private Empleado objetoAuxiliarEmpleado()
        {

            Empleado aux = new Empleado();
            if (!nuevo) aux.Id = int.Parse(dgv_ELEMENTOS.CurrentRow.Cells["Id"].Value.ToString());
            aux.Nombre = textBox_NOMBRE.Text;
            aux.Cargo = textBox_DATO1.Text;
            aux.Salario = int.Parse(textBox_DATO2.Text);

            return aux;
        }
        private Usuario objetoAuxiliarUsuario()
        {

            Usuario aux = new Usuario();
            if (!nuevo) aux.Id = int.Parse(dgv_ELEMENTOS.CurrentRow.Cells["Id"].Value.ToString());
            aux.Nombre = textBox_NOMBRE.Text;
            aux.TipoUsuario = textBox_DATO1.Text;

            return aux;
        }

        private void textBox_DATO2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (vista == "venta" || vista == "empleado")
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_DATO1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (vista == "proveedores" || vista == "productos")
                {
                    e.Handled = true;
                }
            }
        }
    }
}