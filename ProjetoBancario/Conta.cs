using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    abstract class Conta
    {
        private double Saldo;
        private int Numero;
        public Conta() { }
        public Conta(double saldo, int numero)
        {
            Saldo = saldo;
            Numero = numero;
        }
        public void setSaldo(double saldo) 
        {
            Saldo = saldo;
        }
        public double getSaldo() { return Saldo; }
        public void setNumero(int numero)
        {
            Numero = numero;
        }
        public double getNumero() 
        { 
            return Numero; 
        }
        
        public double credita(double valor) 
        {
            Saldo = Saldo + valor;
            return Saldo;
        }
        public virtual bool debitar(double valor) 
        {
            if (valor > 0 && valor <= Saldo) 
            {
                Saldo -= valor;
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        public abstract void atualizarSaldo();
    }
}