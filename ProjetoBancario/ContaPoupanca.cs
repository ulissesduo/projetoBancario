using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class ContaPoupanca : Conta
    {
        private double ReajusteMensal { get; set; }
        public ContaPoupanca() :base() { }
        public ContaPoupanca(double saldo, int numero, double reajuste) : base(saldo, numero) 
        {
            ReajusteMensal = reajuste;
        }
        public void setReajuste(double reajuste) 
        {
            ReajusteMensal = reajuste;
        }
        public double getReajuste() 
        {
            return ReajusteMensal;
        }

        public override void atualizarSaldo()
        {
        }
        public void atualizarSaldo(double reajusteMensal)
        {
            if(getSaldo() > 0)
            {
                ReajusteMensal = getSaldo() * reajusteMensal;
                setSaldo(getSaldo() + reajusteMensal);
            }
        }
    }
}