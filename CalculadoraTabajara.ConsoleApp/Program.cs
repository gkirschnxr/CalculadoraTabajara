using System.Runtime.CompilerServices;

namespace CalculadoraTabajara.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] operacoesRealizadas = new string[100];
            int contador = 0;

            //loop de execução
            while (true)
            {
                
                string opcao = ExibirMenu();

                if (OpcaoSair(opcao) == true)
                    break;

                else if (OpcaoTabuada(opcao))
                    ExibirTabuada();

                else if (OpcaoHistorico(opcao))
                    ExibirHistorico(operacoesRealizadas);

                else if ()
                    RealizarCalculo();

                   

                


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

            string opcao = Console.ReadLine().ToUpper();

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



            for (int contagem = 1; contagem <= 10; contagem++)
            {
                int resultadoTabuada = numeroTabuada * contagem;


                string linhaTabuada = $"{numeroTabuada} x {contagem} = {resultadoTabuada}";

                Console.WriteLine(linhaTabuada);
            }

            Console.WriteLine("----------------------------------");
            Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();
        }

        static bool OpcaoHistorico(string opcao)
        {
            bool OpcaoHistoricoFoiEscolhida = opcao == "6";

            return OpcaoHistoricoFoiEscolhida;
        }

        static void ExibirHistorico(string[] operacoesRealizadas)
        {
            Console.WriteLine("\n################################");
            Console.WriteLine("-----HISTÓRICO DE OPERAÇÕES-----");
            Console.WriteLine("################################\n");

            for (int operacoes = 0; operacoes < operacoesRealizadas.Length; operacoes++)
            {
                if (operacoesRealizadas[operacoes] != null)
                    Console.WriteLine(operacoesRealizadas[operacoes]);
            }

            Console.WriteLine("----------------------------------");
            Console.Write("Aperte ENTER para continuar");
            Console.ReadLine();
        }

        static void RealizarCalculo(string operacao, string[] operacoesRealizadas, string[] contador)
        {
            Console.Write("Digite o primeiro número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine()); //ToInt32 converter para numero inteiro

            Console.Write("Digite o segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine()); //ToDecimal converter para numero decimal

            decimal resultado = 0;

            switch (operacao)
            {
                case "1": //adicao
                    resultado = primeiroNumero + segundoNumero;
                    operacoesRealizadas[contador] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                    break;

                case "2": //subtracao
                    resultado = primeiroNumero - segundoNumero;
                    operacoesRealizadas[contador] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                    break;

                case "3": //multiplicacao
                    resultado = primeiroNumero * segundoNumero;
                    operacoesRealizadas[contador] = $"{primeiroNumero} x {segundoNumero} = {resultado}";
                    break;

                case "4": //divisao
                    resultado = primeiroNumero / segundoNumero;
                    operacoesRealizadas[contador] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                    break;
            }

            contador += 1;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("O resultado é: " + resultado.ToString("F3"));
            Console.WriteLine("--------------------------------");

            Console.Write("Deseja continuar? [S/N]");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar == "N")
                break;

            Console.ReadLine();
        }
    }
}

