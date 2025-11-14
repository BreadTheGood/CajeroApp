using System;
using System.Windows.Forms;

namespace CajeroApp
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        //Botón para salir de la aplicación
        private void button_EXIT_LOGIN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botón para iniciar sesión
        private void BUTTON_lOGIN_Click(object sender, EventArgs e)
        {
            // Si no hay usuario ni contrasena y no está activado el modo DEBUG, mostrar aviso
            if (checkBox_DEBUG.Checked)
            {

                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal("Debug");
                ventanaPrincipal.Show();
                this.Hide();
            }
            else if (comboBox_Login.SelectedItem != null)
            {

                if (comboBox_Login.Text == "Administrador")
                {
                    VentanaPrincipal ventanaPrincipal = new VentanaPrincipal("Administrador");
                    ventanaPrincipal.Show();
                    this.Hide();
                }
                else if (comboBox_Login.Text == "Empleado")
                {
                    VentanaPrincipal ventanaPrincipal = new VentanaPrincipal("Empleado");
                    ventanaPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para iniciar sesión.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
