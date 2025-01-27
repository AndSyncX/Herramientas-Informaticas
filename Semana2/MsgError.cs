using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana2
{
    internal class MsgError
    {
        public void MsgErrorVacio(Label lblRes, TextBox txtNum) {
            MessageBox.Show("Campos vacíos, Digite un número", "Error Campo Vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblRes.Text = "---";
            txtNum.Clear();
        }
    }
}
