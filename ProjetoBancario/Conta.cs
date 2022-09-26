using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    abstract class Conta
    {
        public double Saldo { get; set; }
        public Conta() 
        {

        }
        public double credita(double valor) 
        {
            Saldo = Saldo + valor;
            return Saldo;
        }
        public virtual string debitar(double valor) 
        {
            if (Saldo > 0) 
            {
                Saldo = Saldo - valor;
                return " Saldo: " + Saldo;
            }
            else 
            { 
                return "Saldo: " + Saldo; 
            }
        }
        public abstract string atualizarSaldo();

    }
}
