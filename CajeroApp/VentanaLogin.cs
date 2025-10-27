using System;
using System.Drawing;
using System.Windows.Forms;

namespace CajeroApp
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_lOGIN_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox_CONTRASENA_Enter(object sender, EventArgs e)
        {
            if (textBox_CONTRASENA.Text == "CONTRASEÑA")
            {
                textBox_CONTRASENA.Text = "";
                textBox_CONTRASENA.ForeColor = Color.Black;
                textBox_CONTRASENA.UseSystemPasswordChar = true;
            }
        }

        private void textBox_CONTRASENA_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_CONTRASENA.Text))
            {
                textBox_CONTRASENA.UseSystemPasswordChar = false;
                textBox_CONTRASENA.Text = "CONTRASEÑA";
                textBox_CONTRASENA.ForeColor = Color.Silver
                    ;
            }
        }

        private void textBox_USUARIO_Enter(object sender, EventArgs e)
        {
            if (textBox_USUARIO.Text == "USUARIO")
            {
                textBox_USUARIO.Text = "";
                textBox_USUARIO.ForeColor = Color.Black;

            }
        }

        private void textBox_USUARIO_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_USUARIO.Text))
            {
                textBox_USUARIO.UseSystemPasswordChar = false;
                textBox_USUARIO.Text = "USUARIO";
                textBox_USUARIO.ForeColor = Color.Silver;
            }
        }

        private void BUTTON_lOGIN_Click(object sender, EventArgs e)
        {
            if (textBox_USUARIO.Text == "admin" && textBox_CONTRASENA.Text == "admin123")
            {
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                ventanaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
