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
    public partial class Ejercicio09 : Form
    {
        public Ejercicio09()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double n;

            if (String.IsNullOrWhiteSpace(txtNum.Text))
            {
                MessageBox.Show("Campos vacíos, Digite un número", "Error Campo Vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum.Clear();
            }
            else if (!double.TryParse(txtNum.Text, out n))
            {
                MessageBox.Show("No es un número", "Error Numérico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblRes.Text = "---";
                txtNum.Clear();
            }
            else if (n == 0)
            {
                lblRes.Text = "Soy Zero";
            }
            else if (n % 2 == 0) {
                lblRes.Text = "Par";
            }
            else
            {
                lblRes.Text = "Impar";
            }
        }
    }
}
