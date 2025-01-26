using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            double HL, TH, P;

            if (string.IsNullOrWhiteSpace(txtHoras.Text) || string.IsNullOrWhiteSpace(txtTarifa.Text))
            {
                MensajeBox.MostrarMensajeErrorCamposVacios();
            }
            else if (!double.TryParse(txtHoras.Text, out HL) || !double.TryParse(txtTarifa.Text, out TH))
            {
                MensajeBox.MonstrarMensajeErrorDatosNoNumericos();
            }
            else
            {
                P = HL * TH;

                txtPlanilla.Text = "S/. " + P.ToString();
            }
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {
            txtHoras.Select();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoras.Clear();
            txtTarifa.Clear();
            txtPlanilla.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
