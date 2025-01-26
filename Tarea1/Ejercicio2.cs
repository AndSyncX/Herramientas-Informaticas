using Tarea1;

namespace Tarea1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, promedio;

            if (
                string.IsNullOrWhiteSpace(txtN1.Text) ||
                string.IsNullOrWhiteSpace(txtN2.Text) ||
                string.IsNullOrWhiteSpace(txtN3.Text))
            {
                MensajeBox.MostrarMensajeErrorCamposVacios();
            }
            else if (
                !double.TryParse(txtN1.Text, out n1) ||
                !double.TryParse(txtN2.Text, out n2) ||
                !double.TryParse(txtN3.Text, out n3))
            {
                MensajeBox.MonstrarMensajeErrorDatosNoNumericos();
            }
            else
            {
                promedio = (n1 + n2 + n3) / 3;

                promedio = Math.Round(promedio, 2);

                txtPromedio.Text = promedio.ToString();

                if (promedio >= 13)
                {
                    txtEstado.Text = "APROBADO";
                }
                else
                {
                    txtEstado.Text = "DESAPROBADO";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtPromedio.Clear();
            txtEstado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            txtN1.Select();
        }
    }
}
