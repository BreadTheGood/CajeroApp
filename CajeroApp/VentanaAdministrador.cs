using System.Windows.Forms;

namespace CajeroApp
{
    public partial class VentanaAdministrador : Form
    {
        public VentanaAdministrador()
        {
            InitializeComponent();
            label_USUARIO.Text = "Bienvenido, " + "ADMIN" + "!";



            Hide();


            if (dgv_PRODUCTOS.Columns.Count == 0)
            {
                dgv_PRODUCTOS.Columns.Add("Id", "Id");
                dgv_PRODUCTOS.Columns.Add("Producto", "Producto");
                dgv_PRODUCTOS.Columns.Add("Precio", "Precio");
                dgv_PRODUCTOS.Columns.Add("Cantidad", "Cantidad");
            }

            dgv_PRODUCTOS.Columns["Id"].DisplayIndex = 0;
            dgv_PRODUCTOS.Columns["Producto"].DisplayIndex = 1;
            dgv_PRODUCTOS.Columns["Precio"].DisplayIndex = 2;
            dgv_PRODUCTOS.Columns["Cantidad"].DisplayIndex = 3;
        }

        private void button_nuevaVenta_Click(object sender, System.EventArgs e)
        {
            dgv_PRODUCTOS.Visible = true;
            comboBox_PRODUCTOS.Visible = true;
            textBox_CANTIDAD.Visible = true;
            textBox_PRECIO.Visible = true;
            button_AGREGAR.Visible = true;
            button_CALCULAR.Visible = true;
            button_ELIMINAR.Visible = true;
            label_TOTAL.Visible = true;
            textBox_TOTAL.Visible = true;
        }

        private void Hide()
        {
            dgv_PRODUCTOS.Visible = false;
            comboBox_PRODUCTOS.Visible = false;
            textBox_CANTIDAD.Visible = false;
            textBox_PRECIO.Visible = false;
            button_AGREGAR.Visible = false;
            button_CALCULAR.Visible = false;
            button_ELIMINAR.Visible = false;
            label_TOTAL.Visible = false;
            textBox_TOTAL.Visible = false;
        }
    }
}
