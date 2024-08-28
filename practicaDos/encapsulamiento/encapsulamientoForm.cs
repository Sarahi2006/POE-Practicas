using practicaDos.encapsulamiento.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDos.encapsulamiento
{
    public partial class encapsulamientoForm : Form
    {
        Cuenta cuenta = new Cuenta();
        public encapsulamientoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cuenta.RealizarDeposito(double.Parse(textBox1.Text));
        }

        private void Monto_Click(object sender, EventArgs e)
        {
            cuenta.RealizarRetiro(double.Parse(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cuenta.SaldoActual();
        }
    }
}
