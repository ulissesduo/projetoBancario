using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class ContaCorrente : Conta
    {
        public double LimiteEspecial { get; set; }

        public ContaCorrente() 
        {
        
        }
        public ContaCorrente(double saldo, double limite)
        {
            this.LimiteEspecial = limite;
            Saldo = saldo;
        }

        public override string debitar(double valor)
        {
            if (LimiteEspecial >= Saldo) 
            {
                Saldo -= valor;
                return "Saldo: " + Saldo;
            }
            else 
            {
                return ""; 
            }
        }
        public override string atualizarSaldo()
        { 
            double saldoAnterior = Saldo;
            if (Saldo < 0)
            {
                Saldo = (Saldo * 0.08) - Saldo;
                return "Saldo anterior: " + saldoAnterior + " e saldo atual: " + Saldo;
            }
            else 
            {
                return null;
            }
        }
    }
}
