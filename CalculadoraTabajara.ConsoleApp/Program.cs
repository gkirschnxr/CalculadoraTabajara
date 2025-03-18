using System.Runtime.CompilerServices;

namespace CalculadoraTabajara.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop de execução
            while (true)
            {
                
                string opcao = ExibirMenu();

                if (OpcaoSair(opcao))
                    break;

                else if (OpcaoTabuada(opcao))
                    ExibirTabuada();

                else if (OpcaoHistorico(opcao))
                    ExibirHistorico();

                else
                    ExibirResultado(RealizarCalculo(opcao));


            }
        }

        static string ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico de Operações");
            Console.WriteLine("S - Sair");

            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine()!.ToUpper();

            return opcao;
        }

        static bool OpcaoSair(string opcao)
        {
            bool opcaoSairFoiEscolhida = opcao == "S";

            return opcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuada(string opcao)
        {
            bool opcaoTabuadaFoiEscolhida = opcao == "5";

            return opcaoTabuadaFoiEscolhida;
        }

        static void ExibirTabuada()
        {
            Console.WriteLine("\n################################");
            Console.WriteLine("------------TABUADA-------------");
            Console.WriteLine("################################\n");

            Console.Write("Digite um número para realizar a consulta: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------");
            Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();
        }

        static bool OpcaoHistorico(string opcao)
        {
            bool OpcaoHistoricoFoiEscolhida = opcao == "6";

            return OpcaoHistoricoFoiEscolhida;
        }

        static void ExibirHistorico()
        {
            Console.WriteLine("\n################################");
            Console.WriteLine("-----HISTÓRICO DE OPERAÇÕES-----");
            Console.WriteLine("################################\n");

            for (int operacoes = 0; operacoes < Calculadora.operacoesRealizadas.Length; operacoes++)
            {
                if (Calculadora.operacoesRealizadas[operacoes] != null)
                    Console.WriteLine(Calculadora.operacoesRealizadas[operacoes]);
            }

            Console.WriteLine("----------------------------------");
            Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();
        }

        static decimal RealizarCalculo(string operacao)
        {
            Console.Write("Digite o primeiro número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine()); //ToInt32 converter para numero inteiro

            Console.Write("Digite o segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine()); //ToDecimal converter para numero decimal

            decimal resultado = 0;

            switch (operacao)
            {
                case "1": //adicao
                    resultado = Calculadora.Somar(primeiroNumero, segundoNumero);
                    break;

                case "2": //subtracao
                    resultado = Calculadora.Subtrair(primeiroNumero, segundoNumero);
                    break;

                case "3": //multiplicacao
                    resultado = Calculadora.Multiplicar(primeiroNumero, segundoNumero);
                    break;

                case "4": //divisao
                    resultado = Calculadora.Dividir(primeiroNumero, segundoNumero);
                    break;
            }

            Console.WriteLine("----------------------------------");
            Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();
        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("O resultado é: " + resultado.ToString("F3"));
            Console.WriteLine("--------------------------------");

            Console.ReadLine();
        }
    }
}

