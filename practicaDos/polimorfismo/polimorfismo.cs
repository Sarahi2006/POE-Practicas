using practicaDos.polimorfismo.carpeta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDos.polimorfismo
{
    public partial class polimorfismo : Form
    {
        private List<Computadora> Computadores;

        public polimorfismo()
        {
            InitializeComponent();
            Computadores = new List<Computadora>
            {
                new Computadora(),
                new ComputadoraPortatil(),
                new ComputadoraEscritorio()

            };
        }

        private void polimorfismo_Load(object sender, EventArgs e)
        {

        }

        private void Encender_Click(object sender, EventArgs e)
        {
            foreach (Computadora computadora in Computadores)
            {
                computadora.Encender();
            }
        }
    }
}
