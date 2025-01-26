using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Menu : Form
    {

        private Ejercicio1 form1;
        private Ejercicio2 form2;
        private Ejercicio3 form3;
        private Ejercicio4 form4;
        private Ejercicio5 form5;
        private Ejercicio6 form6;

        public Menu()
        {
            InitializeComponent();
            form1 = new Ejercicio1();
            form2 = new Ejercicio2();
            form3 = new Ejercicio3();
            form4 = new Ejercicio4();
            form5 = new Ejercicio5();
            form6 = new Ejercicio6();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

        private void btnEjercicio5_Click(object sender, EventArgs e)
        {
            form5.ShowDialog();
        }

        private void btnEjercicio6_Click(object sender, EventArgs e)
        {
            form6.ShowDialog();
        }
    }
}
