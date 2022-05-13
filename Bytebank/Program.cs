using System;
using Bytebank;
using Bytebank.Titular;

namespace Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            
            Console.WriteLine("Boas vindas ao seu banco, ByteBank!\n");

            ContaCorrente conta1 = new ContaCorrente();

            conta1.conta = "12345-x";
            conta1.numero_agencia = 12;
            conta1.nome_agencia = "Agência Central";
            conta1.saldo = 100;

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "Amanda Nogueira";
            conta2.conta = "12346-x";
            conta2.numero_agencia = 12;
            conta2.nome_agencia = "Agência Central";
            conta2.saldo = 100;

            Console.WriteLine($"Saldo da {conta2.titular}, pré-transferência: {conta2.saldo}");
            Console.WriteLine($"Saldo da {conta1.titular}, pré-transferência: {conta1.saldo}\n");

            bool transferencia = conta1.Transferir(50, conta2);

            Console.WriteLine($"Transferência realizada com sucesso? {transferencia}\n");

            Console.WriteLine($"Saldo da {conta2.titular}, pós-transferência: {conta2.saldo}");
            Console.WriteLine($"Saldo da {conta1.titular}, pós-transferência: {conta1.saldo}");

            Cliente cliente = new Cliente();

            cliente.nome = "André Silva";
            cliente.cpf = "123456789";
            cliente.profissao = "Programador C#";

            ContaCorrente conta3 = new ContaCorrente();
            conta3.titular = new Cliente();
            conta3.titular.nome = "André Silva";
            conta3.titular.profissao = "Programador c#";
            conta3.titular.cpf = "123456789";
            conta3.conta = "12345-6";
            conta3.numero_agencia = 35;
            conta3.nome_agencia = "Agência Central";

            Console.WriteLine(conta3.titular.nome);

            if (conta3.titular == null)
            {
                Console.WriteLine("O campo titular está nulo.");
            }
            */

            Cliente sarah = new Cliente();
            sarah.Nome = "Sarah Silva";
            sarah.Profissao = "Arquiteta";
            sarah.Cpf = "123.456.789-10";

            Cliente ester = new Cliente();
            ester.Nome = "Julia Almeida";
            ester.Profissao = "Engenheira";
            ester.Cpf = "987.654.321-01";

            Cliente luiz = new Cliente();
            luiz.Nome = "Luiz Ferreira";
            luiz.Profissao = "Empresário";
            luiz.Cpf = "123.987.321-10";

            Console.WriteLine($"Total de clientes: {Cliente.TotalClientesCadastrados}");

            ContaCorrente contaLuiz = new ContaCorrente(luiz, "Agência Central", 21, "78965-x");

            contaLuiz.Titular = new Cliente();
            contaLuiz.Titular.Nome = "Luiz Ferreira";
            contaLuiz.Titular.Profissao = "Empresário";
            contaLuiz.Saldo = 100;

            Console.WriteLine($"Total de contas: {ContaCorrente.TotalDeContasCriadas}");

            Console.ReadKey();


        }
    }
}

