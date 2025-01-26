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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double l1, l2, l3, semi, area;

            if (
                string.IsNullOrWhiteSpace(txtL1.Text) ||
                string.IsNullOrWhiteSpace(txtL2.Text) ||
                string.IsNullOrWhiteSpace(txtL3.Text))
            {
                MensajeBox.MostrarMensajeErrorCamposVacios();
            }
            else if (
                !double.TryParse(txtL1.Text, out l1) ||
                !double.TryParse(txtL2.Text, out l2) ||
                !double.TryParse(txtL3.Text, out l3))
            {
                MensajeBox.MonstrarMensajeErrorDatosNoNumericos();
            }
            else
            {
                semi = (l1 + l2 + l3) / 2;

                semi = Math.Round(semi, 2);
                area = Math.Round((Math.Sqrt(semi * (semi - l1) * (semi - l2) * (semi - l3))), 2);

                txtSemiperimetro.Text = semi.ToString();
                txtArea.Text = area.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtSemiperimetro.Clear();
            txtL1.Clear();
            txtL2.Clear();
            txtL3.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
