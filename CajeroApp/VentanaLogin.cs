using System;
using System.Drawing;
using System.Windows.Forms;

namespace CajeroApp
{
    public partial class VentanaLogin : Form
    {
        private Timer timer1;

        public VentanaLogin()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;


            HideRegistro();
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

                textBox_USUARIO.Text = "USUARIO";
                textBox_USUARIO.ForeColor = Color.Silver;
            }
        }

        private void BUTTON_lOGIN_Click(object sender, EventArgs e)
        {
            if (textBox_USUARIO.Text == "admin" && textBox_CONTRASENA.Text == "admin123")
            {
                VentanaAdministrador ventanaPrincipal = new VentanaAdministrador();
                ventanaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        Point startLocation;
        Point endLocation;
        int animationDuration = 500;
        int currentStep = 0;
        bool isTransitioning = true;

        public void button_REGISTRARSE_Click(object sender, EventArgs e)
        {
            if (!isTransitioning)
            {
                startLocation = label_REGISTRO.Location;

                endLocation = startLocation;
                endLocation.Y = 0;
                timer1.Interval = 10;
                currentStep = 0;
                isTransitioning = true;
                timer1.Start();
            }
            label_REGISTRO.Visible = false;
            pictureBox_REGISTRO.Visible = false;
            textBox_CONTRASENAREGISTRO.Visible = false;
            textBox_EMAILREGISTRO.Visible = false;
            textBox_NOMBREREGISTRO.Visible = false;
            textBox_USUARIOREGISTRO.Visible = false;
            button_REGISTRO.Visible = false;



            label_REGISTRO.Location = new Point(225, 0);
            pictureBox_REGISTRO.Location = new Point(355, 55);
            textBox_NOMBREREGISTRO.Location = new Point(235, 150);
            textBox_EMAILREGISTRO.Location = new Point(235, 190);
            textBox_USUARIOREGISTRO.Location = new Point(235, 230);
            textBox_CONTRASENAREGISTRO.Location = new Point(235, 270);
            button_REGISTRO.Location = new Point(235, 340);

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            currentStep++;
            double fraction = (double)currentStep / (animationDuration / timer1.Interval);
            if (fraction <= 1)
            {
                label_REGISTRO.Visible = true;
                pictureBox_REGISTRO.Visible = true;
                textBox_CONTRASENAREGISTRO.Visible = true;
                textBox_EMAILREGISTRO.Visible = true;
                textBox_NOMBREREGISTRO.Visible = true;
                textBox_USUARIOREGISTRO.Visible = true;
                button_REGISTRO.Visible = true;

                label_REGISTRO.Top = (int)(startLocation.Y + (endLocation.Y - startLocation.Y) * fraction);
                pictureBox_REGISTRO.Top = label_REGISTRO.Top + 55;
                textBox_NOMBREREGISTRO.Top = label_REGISTRO.Top + 150;
                textBox_EMAILREGISTRO.Top = label_REGISTRO.Top + 190;
                textBox_USUARIOREGISTRO.Top = label_REGISTRO.Top + 230;
                textBox_CONTRASENAREGISTRO.Top = label_REGISTRO.Top + 270;
                button_REGISTRO.Top = label_REGISTRO.Top + 340;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {
            HideRegistro();
        }

        private void HideRegistro()
        {
            if (!isTransitioning)
            {
                startLocation = label_REGISTRO.Location;

                endLocation = startLocation;
                endLocation.Y = 0;
                timer1.Interval = 10;
                currentStep = 0;
                isTransitioning = true;
                timer1.Start();
            }

            label_REGISTRO.Location = new Point(1000, 1000);
            pictureBox_REGISTRO.Location = new Point(1000, 1000);
            textBox_NOMBREREGISTRO.Location = new Point(1000, 1000);
            textBox_EMAILREGISTRO.Location = new Point(1000, 1000);
            textBox_USUARIOREGISTRO.Location = new Point(1000, 1000);
            textBox_CONTRASENAREGISTRO.Location = new Point(1000, 1000);
            button_REGISTRO.Location = new Point(1000, 1000);

            isTransitioning = false; // Ensure the transitioning flag is reset
        }

        private void VentanaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            HideRegistro();
        }

        private void textBox_NOMBREREGISTRO_Enter(object sender, EventArgs e)
        {
            if (textBox_NOMBREREGISTRO.Text == "NOMBRE")
            {
                textBox_NOMBREREGISTRO.Text = "";
                textBox_NOMBREREGISTRO.ForeColor = Color.Black;

            }
        }

        private void textBox_NOMBREREGISTRO_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_NOMBREREGISTRO.Text))
            {

                textBox_NOMBREREGISTRO.Text = "NOMBRE";
                textBox_NOMBREREGISTRO.ForeColor = Color.Silver;
            }
        }

        private void textBox_EMAILREGISTRO_Enter(object sender, EventArgs e)
        {
            if (textBox_EMAILREGISTRO.Text == "EMAIL")
            {
                textBox_EMAILREGISTRO.Text = "";
                textBox_EMAILREGISTRO.ForeColor = Color.Black;
            }
        }

        private void textBox_EMAILREGISTRO_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_EMAILREGISTRO.Text))
            {
                textBox_EMAILREGISTRO.Text = "EMAIL";
                textBox_EMAILREGISTRO.ForeColor = Color.Silver;
            }
        }

        private void textBox_USUARIOREGISTRO_Enter(object sender, EventArgs e)
        {
            if (textBox_USUARIOREGISTRO.Text == "USUARIO")
            {
                textBox_USUARIOREGISTRO.Text = "";
                textBox_USUARIOREGISTRO.ForeColor = Color.Black;
            }
        }

        private void textBox_USUARIOREGISTRO_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_USUARIOREGISTRO.Text))
            {
                textBox_USUARIOREGISTRO.Text = "USUARIO";
                textBox_USUARIOREGISTRO.ForeColor = Color.Silver;
            }
        }

        private void textBox_CONTRASENAREGISTRO_Enter(object sender, EventArgs e)
        {
            if (textBox_CONTRASENAREGISTRO.Text == "CONTRASEÑA")
            {
                textBox_CONTRASENAREGISTRO.Text = "";
                textBox_CONTRASENAREGISTRO.ForeColor = Color.Black;

            }
        }

        private void textBox_CONTRASENAREGISTRO_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_CONTRASENAREGISTRO.Text))
            {
                textBox_CONTRASENAREGISTRO.Text = "CONTRASEÑA";
                textBox_CONTRASENAREGISTRO.ForeColor = Color.Silver;

            }
        }
    }
}
