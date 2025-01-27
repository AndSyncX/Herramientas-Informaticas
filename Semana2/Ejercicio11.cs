using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana2
{
    public partial class Ejercicio11 : Form
    {
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double n, z;

            if (String.IsNullOrWhiteSpace(txtNum1.Text) || String.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Campos vacíos, Digite un número", "Error Campo Vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else if (!double.TryParse(txtNum1.Text, out n) || !double.TryParse(txtNum2.Text, out z))
            {
                MessageBox.Show("No es un número", "Error Numérico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else if (n % z == 0)
            {
                lblRes.Text = "Múltiplo";
            }
            else
            {
                lblRes.Text = "No Múltiplo";
            }
        }
    }
}
