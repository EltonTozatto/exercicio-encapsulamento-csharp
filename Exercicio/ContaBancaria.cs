using System.Globalization;

namespace Exercicio
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            Numero = numeroConta;
            Titular = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if(valor <= Saldo)
            {
                Saldo -= valor + 5.0;
            }
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
