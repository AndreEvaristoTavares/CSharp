using System;
using ByteBank.Titular;
using ByteBank.Contas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public string Agencia;
        public string Conta;
        public Cliente Titular;
        public double Saldo;

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public bool Saque(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
                return true;
            }
            else { return false; }
        }
        public void DadosDaConta()
        {
            Console.WriteLine($"Agencia {Agencia}\nConta: {Conta}\nTitular: {Titular.Nome}\nSaldo: {Saldo.ToString("F2")}");
        }
        public bool Transferir(double valor, ContaCorrente contaCorrente)
        {
            if (Saldo > valor)
            {
                contaCorrente.Saldo += valor;
                return true;
            }
            else { return false; }

        }


    }
}
