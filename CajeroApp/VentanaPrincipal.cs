using System.Windows.Forms;

namespace CajeroApp
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            label_USUARIO.Text = "Bienvenido, " + "ADMIN" + "!";
        }
    }
}
