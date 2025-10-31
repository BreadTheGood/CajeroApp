using System;
using System.Drawing;
using System.Windows.Forms;

namespace CajeroApp
{
    public partial class VentanaRegistro : Form
    {
        public VentanaRegistro()
        {
            InitializeComponent();
            // Inicializar panel1
            panel1 = new Panel
            {
                Size = new Size(100, 100),
                Location = new Point(50, 50),
                BackColor = Color.Blue
            };
            this.Controls.Add(panel1);

            // Inicializar timer1
            //timer1 = new Timer();
            //imer1.Tick += timer1_Tick;
        }

        // Controles necesarios
        private Panel panel1;
        private Timer timer1;

        // Propiedades para la transición
        private Point startLocation;
        private Point endLocation;
        private Point midLocation;
        private int animationDuration = 500; // Duración en milisegundos
        private int currentStep = 0;
        private bool isTransitioning = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isTransitioning)
            {
                startLocation = panel1.Location;

                // Configurar las posiciones de inicio, medio y final
                midLocation = new Point(panel1.Left + 50, panel1.Top); // Posición intermedia (x = 100)
                endLocation = startLocation; // Posición final (x = 50)

                timer1.Interval = 10; // Ajustar el intervalo para el paso de animación
                currentStep = 0;
                isTransitioning = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentStep++;
            double fraction = (double)currentStep / (animationDuration / timer1.Interval);

            if (fraction <= 0.5) // Primera mitad de la animación (hacia midLocation)
            {
                double subFraction = fraction / 0.5; // Normalizar a [0, 1] para esta etapa
                panel1.Left = (int)(startLocation.X + (midLocation.X - startLocation.X) * subFraction);
                panel1.Top = (int)(startLocation.Y + (midLocation.Y - startLocation.Y) * subFraction);
            }
            else if (fraction <= 1.0) // Segunda mitad de la animación (hacia endLocation)
            {
                double subFraction = (fraction - 0.5) / 0.5; // Normalizar a [0, 1] para esta etapa
                panel1.Left = (int)(midLocation.X + (endLocation.X - midLocation.X) * subFraction);
                panel1.Top = (int)(midLocation.Y + (endLocation.Y - midLocation.Y) * subFraction);
            }
            else
            {
                timer1.Stop();
                isTransitioning = false;
                panel1.Location = endLocation; // Asegurar la posición final
            }
        }
    }
}
