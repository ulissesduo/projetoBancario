using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class GerenciadorDeConta
    {
        public double SaldoTotal { get; set; }
        public GerenciadorDeConta()
        {
            SaldoTotal = 0;
        }

        public void totalizarSaldo(Conta conta) 
        {
            //conta.Saldo += SaldoTotal; talvez
            SaldoTotal = SaldoTotal + conta.Saldo;
        }
    }
}
