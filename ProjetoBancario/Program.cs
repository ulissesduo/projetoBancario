using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cc = new ContaCorrente(500, 1000);
            Conta cp = new ContaCorrente(5000, 0.01);
            
            cc.credita(100);
            cc.debitar(200);
            cc.atualizarSaldo();
            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cc.atualizarSaldo());

            Console.WriteLine(" ========================================== ");
            Console.WriteLine(cp.Saldo);
            cp.credita(100);
            Console.WriteLine(cp.Saldo);
            cp.debitar(200);
            Console.WriteLine(cp.Saldo);
            cp.atualizarSaldo();
            Console.WriteLine(cp.Saldo);
            Console.WriteLine(cp.atualizarSaldo());

            Console.ReadLine();
        }
    }
}