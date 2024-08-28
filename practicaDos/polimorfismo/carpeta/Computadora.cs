using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDos.polimorfismo.carpeta
{
    public class Computadora
    {
        public virtual void Encender()
        {
            MessageBox.Show("Encendiendo computadora");
        }

    }

    public class ComputadoraPortatil : Computadora
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo computadora Portatil");
        }

    }

    public class ComputadoraEscritorio: Computadora
    {
        public override void Encender()
        {
            MessageBox.Show("Encendiendo computadora de escritorio");
        }
    }
}
