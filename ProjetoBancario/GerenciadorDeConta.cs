using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class GerenciadorDeConta
    {
        private double SaldoTotal;
        public GerenciadorDeConta()
        {
            SaldoTotal = 0;
        }
        public double getSaldoTotal() 
        {
            return SaldoTotal;
        }
        public void setSaldoTotal(double saldototal) 
        {
            SaldoTotal = saldototal;
        }
        public void totalizarSaldo(Conta conta) 
        {
            SaldoTotal = SaldoTotal + conta.getSaldo();
        }
    }
}
