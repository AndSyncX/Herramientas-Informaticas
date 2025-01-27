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
    public partial class Ejercicio13 : Form
    {
        public Ejercicio13()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int n, z, w;

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
                !int.TryParse(txtNum1.Text, out n) ||
                !int.TryParse(txtNum2.Text, out w) ||
                !int.TryParse(txtNum3.Text, out z))
            {
                MessageBox.Show("No es un número", "Error Numérico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum3.Clear();
            }
            else if (n % z == 0 && n % w == 0)
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
