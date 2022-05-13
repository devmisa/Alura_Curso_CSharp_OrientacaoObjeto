using Bytebank;
using Bytebank.Titular;

namespace Bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string Nome_Agencia { get; set; }
        public int Numero_Agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }

        }

        private int _numero_agencia;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {

                }
                else
                {
                    _conta = value;
                }
            }
        }

        private string _conta;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        private double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo = destino.saldo += valor;
                return true;
            }
        }

        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_Agencia = nome_agencia;
            Numero_Agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }

        //public void SetSaldo(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        saldo += valor;
        //    }
        //}

    }
}
