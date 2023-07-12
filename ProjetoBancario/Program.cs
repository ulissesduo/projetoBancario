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
            double valor;
            int op = -1, opcao = -1;

            Conta cp = new ContaPoupanca(5000, 001, 0);
            Conta cc = new ContaCorrente(500, 1000);
            GerenciadorDeConta gc = new GerenciadorDeConta();

            do
            {
                Console.WriteLine("1 - Conta corrente\n2 - Poupança\n3 - Consultar total dos saldo\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        do
                        {
                            Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Consultar saldo\n4 - Reajustar saldo\n0 - Sair");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Valor a debitar");
                                    valor = double.Parse(Console.ReadLine());
                                    cc.credita(valor);
                                    break;
                                case 2:
                                    Console.WriteLine("Valor a debitar");
                                    valor = double.Parse(Console.ReadLine());
                                    cc.debitar(valor);
                                    break;
                                case 3:
                                    Console.WriteLine("Valor a debitar");
                                    cc.atualizarSaldo();
                                    Console.WriteLine(cc.getSaldo());
                                    cc.atualizarSaldo();
                                    break;
                                case 4:
                                    Console.WriteLine("Reajustar?");
                                    break;
                                default:
                                    Console.WriteLine("Inválido");
                                    break;
                            }
                        }
                        while (op != 0);
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Consultar saldo\n4 - Reajustar saldo\n0 - Sair");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Valor a debitar");
                                    valor = double.Parse(Console.ReadLine());
                                    cp.credita(valor);
                                    break;
                                case 2:
                                    Console.WriteLine("Valor a debitar");
                                    valor = double.Parse(Console.ReadLine());
                                    cp.debitar(valor);
                                    break;
                                case 3:
                                    Console.WriteLine("Valor a debitar");
                                    cp.atualizarSaldo();
                                    Console.WriteLine(cp.getSaldo());
                                    break;
                                case 4:
                                    Console.WriteLine("Reajustar?");
                                    break;
                                default:
                                    Console.WriteLine("Inválido");
                                    break;
                            }
                        }
                        while (op != 0);
                        break;

                    case 3:
                        do
                        {
                            gc.totalizarSaldo(cc);
                            gc.totalizarSaldo(cp);
                            Console.WriteLine(cc.getSaldo() + "\n" + cp.getSaldo() + "\nTotal é igual a: " + gc.getSaldoTotal());
                        }
                        while (op != 0);
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}