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
    public partial class Ejercicio12 : Form
    {
        public Ejercicio12()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double n, z, w;

            if (String.IsNullOrWhiteSpace(txtNum1.Text) || 
                String.IsNullOrWhiteSpace(txtNum2.Text) ||
                String.IsNullOrWhiteSpace(txtNum3.Text))
            {
                MessageBox.Show("Campos vacíos, Digite un número", "Error Campo Vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum3.Clear();
            }
            else if (
                !double.TryParse(txtNum1.Text, out n) || 
                !double.TryParse(txtNum2.Text, out z) ||
                !double.TryParse(txtNum3.Text, out w))
            {
                MessageBox.Show("No es un número", "Error Numérico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum3.Clear();
            }
            else if (z % n == 0 && w == n)
            {
                lblRes.Text = "Divisor";
            }
            else
            {
                lblRes.Text = "No Divisor";
            }
        }
    }
}
