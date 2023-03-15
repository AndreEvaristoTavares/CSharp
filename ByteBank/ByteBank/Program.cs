using System.Drawing;
using ByteBank.Contas;
using ByteBank.Titular;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Andre";
            cliente.Cpf = "22877086852";
            cliente.Profissao = "Programador";

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Titular = cliente;
            contaCorrente.Agencia = "1234";
            contaCorrente.Conta = "1234-5";
            contaCorrente.Saldo = 2000;


            Console.WriteLine("Titular: "+contaCorrente.Titular.Nome);
            Console.WriteLine("CPF: "+contaCorrente.Titular.Cpf);
            Console.WriteLine("Profissao: "+contaCorrente.Titular.Profissao);
            Console.WriteLine("Numero da conta:"+contaCorrente.Conta);
            Console.WriteLine("Numero da agencia: " + contaCorrente.Agencia);
            Console.WriteLine("Saldo: " + contaCorrente.Saldo);
        }
    }
}
