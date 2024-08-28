using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDos.encapsulamiento.modelo
{
    public class Cuenta
    {

        public double Saldo { get; set; }
        

        private void Depositar(double monto)
        {
            Saldo += monto;
            MessageBox.Show("Deposito realizado con exito");


        }

        private void Retiro(double monto)
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
                MessageBox.Show("retiro realizado con exito");

            }
            else 
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        public void RealizarDeposito(double monto) 
        {
            Depositar(monto);

        }

        public void RealizarRetiro(double monto)
        {
            Retiro(monto);

        }



        public void SaldoActual()
        {
            MessageBox.Show($"Su saldo actual es de {Saldo}");
        }


    }
}
