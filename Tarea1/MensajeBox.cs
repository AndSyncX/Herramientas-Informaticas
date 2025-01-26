using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class MensajeBox
    {
        public static void MostrarMensajeErrorCamposVacios()
        {
            MessageBox.Show("Campos vacíos, por favor ingrese un dato.", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MonstrarMensajeErrorDatosNoNumericos()
        {
            MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
