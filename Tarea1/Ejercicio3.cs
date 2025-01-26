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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {
            int RC, RI, PF;

            if (string.IsNullOrWhiteSpace(txtPcorrectas.Text) || string.IsNullOrWhiteSpace(txtPincorrectas.Text))
            {
                MensajeBox.MostrarMensajeErrorCamposVacios();
            }
            else if (!int.TryParse(txtPcorrectas.Text, out RC) || !int.TryParse(txtPincorrectas.Text, out RI))
            {
                MensajeBox.MonstrarMensajeErrorDatosNoNumericos();
            }
            else
            {
                RC *= 4;
                RI *= (-1);

                PF = RC + RI;

                txtPuntajeFinal.Text = PF.ToString();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPcorrectas.Clear();
            txtPincorrectas.Clear();
            txtPuntajeFinal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            txtPcorrectas.Select();
        }
    }
}
