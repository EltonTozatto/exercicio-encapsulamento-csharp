using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            string depositoInicial = Console.ReadLine();

            ContaBancaria contaBancaria;

            if (depositoInicial == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numeroConta, titular, valorDeposito);
            }
            else
                contaBancaria = new ContaBancaria(numeroConta, titular);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            contaBancaria.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre com um valor de saque: ");
            contaBancaria.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
        }
    }
}
