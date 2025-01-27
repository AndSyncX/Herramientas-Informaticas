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
    public partial class Ejercicio14 : Form
    {
        public Ejercicio14()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int n, w;

            if (String.IsNullOrWhiteSpace(txtNum1.Text) ||
                String.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Campos vacíos, Digite un número", "Error Campo Vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else if (
                !int.TryParse(txtNum1.Text, out n) ||
                !int.TryParse(txtNum2.Text, out w))
            {
                MessageBox.Show("No es un número", "Error Numérico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else if (n > w)
            {
                lblRes.Text = n + " es mayor que " + w;
            }
            else if (n == w)
            {
                lblRes.Text = n + " es igual que " + w;
            }
            else
            {
                lblRes.Text = w + " es mayor que " + n;
            }
        }
    }
}
