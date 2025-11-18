using CapaBLL;
using System;
using System.Windows.Forms;

namespace CajeroApp
{
    public partial class VentanaLogin : Form
    {

        private string[] listaNombrePerfil;
        private string[] listaTipoPerfil;
        private string[] listaLogin;

        public VentanaLogin()
        {

            InitializeComponent();
            cargarListaLogin();
        }

        //Botón para salir de la aplicación
        private void button_EXIT_LOGIN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botón para iniciar sesión
        private void BUTTON_lOGIN_Click(object sender, EventArgs e)
        {
            if (comboBox_Login.SelectedItem != null)
            {

                if (comboBox_Login.Text.Contains("Administrador"))
                {
                    VentanaPrincipal ventanaPrincipal = new VentanaPrincipal("Administrador");
                    ventanaPrincipal.Show();
                    this.Hide();
                }
                else if (comboBox_Login.Text.Contains("Empleado"))
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

        private void cargarListaLogin()
        {
            try
            {
                LogicaSolicitudes conexion = new LogicaSolicitudes();
                var usuarios = conexion.LeerUsuario();
                var empleados = conexion.LeerEmpleado();

                int countUsuarios = usuarios.Count;
                int countEmpleados = empleados.Count;
                int total = countUsuarios + countEmpleados;

                listaNombrePerfil = new string[total];
                listaTipoPerfil = new string[total];
                listaLogin = new string[total];


                for (int i = 0; i < countUsuarios; i++)
                {
                    listaNombrePerfil[i] = usuarios[i]?.Nombre;
                    listaTipoPerfil[i] = usuarios[i]?.TipoUsuario;
                }

                for (int i = 0; i < countEmpleados; i++)
                {
                    int idx = countUsuarios + i;
                    listaNombrePerfil[idx] = empleados[i]?.Nombre;
                    listaTipoPerfil[idx] = empleados[i]?.Cargo;
                }


                for (int i = 0; i < total; i++)
                {
                    listaLogin[i] = $"{listaNombrePerfil[i].Trim()} - {listaTipoPerfil[i]}";
                }

                comboBox_Login.Items.Clear();

                comboBox_Login.Items.AddRange(listaLogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }
        }

    }
}
