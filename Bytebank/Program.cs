using System;
using Bytebank;

namespace Bytebank
{
    class Program
    {
       static void Main(string[] args)
        {
                   
            Console.WriteLine("Boas vindas ao seu banco, ByteBank!\n");

            ContaCorrente conta1 = new ContaCorrente();

            conta1.titular = "Gabriela Santos";
            conta1.conta = "12345-x";
            conta1.numero_agencia = 12;
            conta1.nome_agencia = "Agência Central";
            conta1.saldo = 10.123;

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "Bruno Almeida";
            conta2.conta = "54321-x";
            conta2.numero_agencia = 21;
            conta2.nome_agencia = "Agência Central";
            conta2.saldo = 10.321;

            ContaCorrente conta3 = new ContaCorrente();

            conta3.titular = "Rodrigo Silva";
            conta3.conta = "78910-x";
            conta3.numero_agencia = 78;
            conta3.nome_agencia = "Agência Central";
            conta3.saldo = 10.789;

            Console.WriteLine($"Titular: {conta1.titular}\nConta: {conta1.conta}\nNúmero Agência: {conta1.numero_agencia}\nNome Agência: {conta1.nome_agencia}\nSaldo: {conta1.saldo}\nVerificador: {conta1.verificador}\n");
            Console.WriteLine($"Titular: {conta2.titular}\nConta: {conta2.conta}\nNúmero Agência: {conta2.numero_agencia}\nNome Agência: {conta2.nome_agencia}\nSaldo: {conta2.saldo}\n");
            Console.WriteLine($"Titular: {conta3.titular}\nConta: {conta3.conta}\nNúmero Agência: {conta3.numero_agencia}\nNome Agência: {conta3.nome_agencia}\nSaldo: {conta3.saldo}\n");

            Console.ReadKey();
        }
    }
}

