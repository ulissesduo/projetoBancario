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
            setSaldo( saldo);
        }

        public override bool debitar(double valor)
        {
            if (valor <= getSaldo()+ LimiteEspecial) 
            {
                setSaldo(getSaldo() - valor);
                return true;
            }
            return false;
        }
        public override void atualizarSaldo()
        { 
            if (getSaldo() < 0)
            {
                LimiteEspecial = getSaldo() * 0.08;
                setSaldo(getSaldo() - LimiteEspecial); 
                
            }
        }
    }
}
