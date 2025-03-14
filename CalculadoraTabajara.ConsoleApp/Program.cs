﻿using System.Runtime.CompilerServices;

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

                string opcao = Console.ReadLine().ToUpper(); //ToUpper para a letra ser sempre maiuscula

                if (opcao == "S")
                    break;

                
                else if (opcao == "5") //tabuada
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

                    Console.ReadLine();    
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("\n################################");
                    Console.WriteLine("-----HISTÓRICO DE OPERAÇÕES-----");
                    Console.WriteLine("################################\n");

                    for (int operacoes = 0; operacoes < operacoesRealizadas.Length; operacoes++)
                    {
                        if (operacoesRealizadas[operacoes] != null)
                            Console.WriteLine(operacoesRealizadas[operacoes]);
                    }

                    Console.ReadLine();
                    continue;
                }


                    Console.Write("Digite o primeiro número: ");
                    string primeiroNumeroString = Console.ReadLine();
                    decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString); //ToInt32 converter para numero inteiro

                    Console.Write("Digite o segundo número: ");
                    string segundoNumeroString = Console.ReadLine();
                    decimal segundoNumero = Convert.ToDecimal(segundoNumeroString); //ToDecimal converter para numero decimal

                    decimal resultado = 0;

                switch (opcao)
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
}

