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
            Conta cc = new ContaCorrente(1000, 5000);
            Console.WriteLine( cc.Saldo );
            cc.debitar(100);
            Console.WriteLine(cc.Saldo);
            cc.credita(200);
            Console.WriteLine(cc.Saldo);
            Console.ReadLine();
        }
    }
}
