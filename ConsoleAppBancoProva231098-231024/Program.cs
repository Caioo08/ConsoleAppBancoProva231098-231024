using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBancoProva231098_231024
{
    internal class Program
    {
        public static double saldo = 0;
        static void Main(string[] args)
        {
            string resp = "SIM";
            while (resp == "SIM") { 
            Console.WriteLine("Que ação deseja efetuar?\n Efetuar Depósito-1 \n Efetuar Saque-2 \n Efetuar Pagamento-3 \n Consultar Saldo-4");
            string ac = Console.ReadLine();

            switch (ac)
            {
                case "1":
                    Deposito();
                    break;
                case "2":
                    Saque();
                    break; 
                case "3":                        
                    Pagamento();
                    break;
                case "4":
                    ConsultaSaldo();
                    break;
            }
            Console.WriteLine("Deseja continuar?");
            resp = Console.ReadLine().ToUpper();
            Console.Clear();
            }
            Console.ReadKey();
        }

        static void Deposito()
        {

            Console.Clear();
            Console.WriteLine("Insira o valor que deseja depositar: ");
            double deposito = double.Parse(Console.ReadLine());
            saldo = saldo+deposito;
            Console.WriteLine("Valor depositado com sucesso.");
        }

        static void Saque()
        {
            Console.Clear();
            Console.WriteLine("Insira o valor deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());
            if(saldo<saque)
            {
                Console.WriteLine("Sem limite disponível");
            }
            else
            {
                saldo = saldo - saque;
                Console.WriteLine("Saque efetuado com sucesso.");
            }
        }

        static void Pagamento()
        {
            Console.Clear();
            Console.WriteLine("Insira o código do boleto: ");
            string codigo = Console.ReadLine();
            Console.WriteLine("Insira o valor do boleto: ");
            double pagamento = double.Parse(Console.ReadLine());
            if (saldo < pagamento)
            {
                Console.WriteLine("Sem limite disponível");
            }
            else
            {
                saldo = saldo - pagamento;
                Console.WriteLine("Pagamento efetuado com sucesso.");
            }
        }
        static void ConsultaSaldo()
        {
            Console.Clear();
            Console.WriteLine("O seu saldo é de: " + saldo.ToString("C"));
        }
    }
}
