using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class ContaPoupanca : Conta
    {
        public double ReajusteMensal { get; set; }
        public ContaPoupanca() { }
        public ContaPoupanca(double saldo, double reajuste) 
        {
            Saldo = saldo;
            ReajusteMensal = reajuste;
        }

        public override string atualizarSaldo()
        {
            return null;
        }
        public string atualizarSaldo(double reajusteMensal)
        {
            double saldoAnterior = Saldo;
            ReajusteMensal = reajusteMensal;
            Saldo = (Saldo * (reajusteMensal / 100)) + Saldo;
            return "Saldo anterior: " + saldoAnterior + " e saldo atual: " + Saldo;
        }
    }
}
