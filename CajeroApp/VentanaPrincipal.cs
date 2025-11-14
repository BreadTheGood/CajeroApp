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
                case "Debug":
                    label_USUARIO.Text = "   CajeroApp - Modo Debug";
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

        }



        private void botonVolver()
        {
            button_SALIR_VOLVER.BackgroundImage = Properties.Resources.Back_Arrow;
            button_SALIR_VOLVER.Tag = "Back_Row";
        }

        private void OcultarControles()
        {
            textBox_PRECIO.Visible = false;
            textBox_NOMBRE.Visible = false;
            dgv_ELEMENTOS.Visible = false;
            comboBox_PRODUCTOS.Visible = false;
            textBox_CANTIDAD.Visible = false;
            textBox_PRECIO.Visible = false;
            button_AGREGAR.Visible = false;
            textBox_BUSCAR.Visible = false;
            button_BUSCAR.Visible = false;
            button_ELIMINAR.Visible = false;
            label_TOTAL.Visible = false;
            textBox_TOTAL.Visible = false;
            LimpiarControles();

        }


        private void LimpiarControles()
        {

            comboBox_PRODUCTOS.SelectedIndex = -1;
            textBox_NOMBRE.Text = "NOMBRE";
            textBox_CANTIDAD.Text = "CANTIDAD";
            textBox_PRECIO.Text = "PRECIO";
            textBox_BUSCAR.Text = "BUSCADOR";

            textBox_BUSCAR.ForeColor = System.Drawing.Color.Silver;
            textBox_NOMBRE.ForeColor = System.Drawing.Color.Silver;
            textBox_CANTIDAD.ForeColor = System.Drawing.Color.Silver;
            textBox_CANTIDAD.Enabled = false;

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

                    if (comboBox_PRODUCTOS.Text != "" && textBox_PRECIO.Text != "")
                    {
                        dgv_ELEMENTOS.Rows.Add(dgv_ELEMENTOS.Rows.Count, comboBox_PRODUCTOS.Text, textBox_PRECIO.Text, textBox_CANTIDAD.Text);

                        LimpiarControles();

                        dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

                        CalcularTotal();

                        DeshabilitarBotones();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un producto", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "productos":

                    if (textBox_NOMBRE.Text != "" && textBox_PRECIO.Text != "")
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
            }


        }

        private void comboBox_PRODUCTOS_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            int idx = comboBox_PRODUCTOS.SelectedIndex;

            textBox_PRECIO.ForeColor = System.Drawing.Color.Black;
            textBox_PRECIO.Enabled = false;
            textBox_CANTIDAD.Enabled = true;

            HabilitarBotones();

            if (listaPrecios != null && idx >= 0 && idx < listaPrecios.Length)
            {
                textBox_PRECIO.Text = listaPrecios[idx];
            }
            else
            {
                textBox_PRECIO.Text = string.Empty;
            }
        }

        private void HabilitarBotones()
        {

            switch (vista)
            {
                case "venta":
                    if (comboBox_PRODUCTOS.SelectedIndex != -1)
                    {
                        button_AGREGAR.Enabled = true;
                        button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
                    }
                    break;

                case "productos":
                    if (textBox_NOMBRE.Text != "PRODUCTO")
                    {
                        button_AGREGAR.Enabled = true;
                        button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
                    }
                    break;

            }



            if (dgv_ELEMENTOS.Rows.Count > 0)
            {
                button_ELIMINAR.Enabled = true;
                button_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            }


        }

        private void DeshabilitarBotones()
        {


            button_AGREGAR.Enabled = false;
            button_AGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));



            button_ELIMINAR.Enabled = false;
            button_ELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));


        }

        private void dgv_ELEMENTOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotones();

            if (dgv_ELEMENTOS.CurrentCell != null && !dgv_ELEMENTOS.CurrentRow.IsNewRow)
            {
                nuevo = false;
                textBox_CANTIDAD.ForeColor = System.Drawing.Color.Black;
                textBox_NOMBRE.ForeColor = System.Drawing.Color.Black;

                try
                {

                    switch (vista)
                    {
                        case "productos":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_PRECIO.Text = dgv_ELEMENTOS.CurrentRow.Cells["Precio"].Value.ToString();
                            textBox_NOMBRE.TextAlign = HorizontalAlignment.Center;
                            textBox_PRECIO.TextAlign = HorizontalAlignment.Center;
                            break;

                        case "venta":

                            comboBox_PRODUCTOS.Text = dgv_ELEMENTOS.CurrentRow.Cells["Producto"].Value.ToString();
                            textBox_PRECIO.Text = dgv_ELEMENTOS.CurrentRow.Cells["Precio"].Value.ToString();
                            textBox_CANTIDAD.Text = dgv_ELEMENTOS.CurrentRow.Cells["Cantidad"].Value.ToString();

                            break;
                        case "empleado":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_NOMBRE.TextAlign = HorizontalAlignment.Center;

                            break;
                        case "usuario":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_NOMBRE.TextAlign = HorizontalAlignment.Center;

                            break;
                        case "proveedores":
                            textBox_NOMBRE.Text = dgv_ELEMENTOS.CurrentRow.Cells["Nombre"].Value.ToString();
                            textBox_NOMBRE.TextAlign = HorizontalAlignment.Center;


                            break;


                    }

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

        private void button_ELIMINAR_Click(object sender, System.EventArgs e)
        {
            if (dgv_ELEMENTOS.CurrentCell != null && !dgv_ELEMENTOS.CurrentRow.IsNewRow)
            {

                if (MessageBox.Show("Quieres eliminar esta fila?", "Confirmación de Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    Producto aux = objetoAuxiliar();
                    LogicaSolicitudes conexionProducto = new LogicaSolicitudes();

                    conexionProducto.EliminarProducto(aux);

                    MessageBox.Show("Registro eliminado correctamente");

                    cargarProductos(null);

                }


                LimpiarControles();

                DeshabilitarBotones();
            }
        }

        private void CalcularTotal()
        {
            double total = 0;


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

        private void textBox_NOMBRE_Enter(object sender, System.EventArgs e)
        {
            textBox_NOMBRE.Text = "";
            textBox_NOMBRE.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox_PRECIO_Enter(object sender, System.EventArgs e)
        {
            textBox_PRECIO.Text = "";
            textBox_PRECIO.ForeColor = System.Drawing.Color.Black;
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
            }
        }

        private void textBox_PRECIO_Leave(object sender, System.EventArgs e)
        {
            if (textBox_PRECIO.Text == "")
            {
                textBox_PRECIO.Text = "PRECIO";
                textBox_PRECIO.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void textBox_BUSCAR_Leave(object sender, System.EventArgs e)
        {
            if (textBox_BUSCAR.Text == "")
            {
                textBox_BUSCAR.Text = "BUSCADOR";
                textBox_BUSCAR.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void textBox_CANTIDAD_Enter(object sender, System.EventArgs e)
        {
            textBox_CANTIDAD.Text = "";
            textBox_CANTIDAD.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox_CANTIDAD_Leave(object sender, System.EventArgs e)
        {
            if (textBox_CANTIDAD.Text == "")
            {
                textBox_CANTIDAD.Text = "CANTIDAD";
                textBox_CANTIDAD.ForeColor = System.Drawing.Color.Silver;
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

        private void button_VENTA_Click(object sender, System.EventArgs e)
        {
            vista = "venta";
            resetDGV();
            cargarListaProductos();


            dgv_ELEMENTOS.DataSource = null;
            dgv_ELEMENTOS.Rows.Clear();
            dgv_ELEMENTOS.Columns.Clear();

            CrearDGV("Producto", "Precio", "Cantidad");

            botonVolver();
            MostrarControlesBasicos();

            textBox_PRECIO.Visible = true;
            textBox_CANTIDAD.Visible = true;
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
            resetDGV();

            cargarProductos(null);

            dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;
            textBox_PRECIO.ForeColor = System.Drawing.Color.Silver;


            vista = "productos";



            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;
            textBox_PRECIO.Enabled = true;
            textBox_PRECIO.Visible = true;

            button_AGREGAR.Enabled = true;
            button_BUSCAR.Visible = true;



        }

        //VISTA BOTON PROVEEDORES:::
        private void button_PROVEEDORES_Click(object sender, System.EventArgs e)
        {


            vista = "proveedores";

            resetDGV();

            cargarProveedor(null);

            dgv_ELEMENTOS.ForeColor = System.Drawing.Color.Black;

            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;

            button_AGREGAR.Enabled = true;
            button_BUSCAR.Visible = true;
        }
        //VISTA BOTON USUARIO:::
        private void button_USUARIO_Click(object sender, System.EventArgs e)
        {
            CrearDGV("Nombre", "Tipo De Usuario", null);

            vista = "usuario";

            resetDGV();

            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;

            button_AGREGAR.Enabled = true;
            button_BUSCAR.Visible = true;
        }
        //VISTA BOTON EMPLEADO:::
        private void button_EMPLEADO_Click(object sender, System.EventArgs e)
        {
            CrearDGV("Nombre", "Cargo", "Salario");

            vista = "empleado";

            resetDGV();

            textBox_NOMBRE.Enabled = true;
            textBox_NOMBRE.Visible = true;
            textBox_BUSCAR.Enabled = true;
            textBox_BUSCAR.Visible = true;

            button_AGREGAR.Enabled = true;
            button_BUSCAR.Visible = true;
        }

        //COMUNICACION CON LA BBDD

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

        private Producto objetoAuxiliar()
        {

            Producto aux = new Producto();
            if (!nuevo) aux.Id = int.Parse(dgv_ELEMENTOS.CurrentRow.Cells["Id"].Value.ToString());
            aux.Nombre = textBox_NOMBRE.Text;
            aux.Precio = int.Parse(textBox_PRECIO.Text);


            return aux;
        }

        private void agregarProducto()
        {
            Producto aux = objetoAuxiliar();

            LogicaSolicitudes conexionProducto = new LogicaSolicitudes();

            conexionProducto.AgregarProducto(aux);
            MessageBox.Show("El archivo se guardó correctamente", "Confirmación");
            LimpiarControles();
            cargarProductos(null);


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

                }

                return;
            }
        }
    }
}
