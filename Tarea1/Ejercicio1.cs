namespace Tarea1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtVelocidad.Select();
        }
        private void btnDistancia_Click(object sender, EventArgs e)
        {
            int v, t, d;

            if (string.IsNullOrWhiteSpace(txtVelocidad.Text) || string.IsNullOrWhiteSpace(txtTiempo.Text))
            {
                MensajeBox.MostrarMensajeErrorCamposVacios();
            }
            else if (!int.TryParse(txtVelocidad.Text, out v) || !int.TryParse(txtTiempo.Text, out t))
            {
                MensajeBox.MonstrarMensajeErrorDatosNoNumericos();
            }
            else
            {
                d = v * t;

                txtDistancia.Text = d.ToString() + "m";
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtVelocidad.Clear();
            txtTiempo.Clear();
            txtDistancia.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
