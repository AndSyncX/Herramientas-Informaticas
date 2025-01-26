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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {
            int PG, PE, PT;

            if (string.IsNullOrWhiteSpace(txtPganado.Text) || string.IsNullOrWhiteSpace(txtPempatado.Text))
            {
                MensajeBox.MostrarMensajeErrorCamposVacios();
            }
            else if (!int.TryParse(txtPganado.Text, out PG) || !int.TryParse(txtPempatado.Text, out PE))
            {
                MensajeBox.MonstrarMensajeErrorDatosNoNumericos();
            }
            else
            {
                PG *= 3;
                PE *= 1;

                PT = PG + PE;

                txtPuntajeTotal.Text = PT.ToString();
            }
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            txtPganado.Select();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPganado.Clear();
            txtPempatado.Clear();
            txtPuntajeTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
