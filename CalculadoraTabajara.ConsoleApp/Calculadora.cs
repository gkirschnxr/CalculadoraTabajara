namespace CalculadoraTabajara.ConsoleApp
{

    public static class Calculadora
    {

        public static string[] operacoesRealizadas = new string[100];
        public static int contador = 0;

        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero + segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            contador += 1;

            return resultado;
        }

        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero - segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            contador += 1;

            return resultado;
        }

        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero * segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} x {segundoNumero} = {resultado}";
            contador += 1;

            return resultado;
        }

        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero / segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            contador += 1;

            return resultado;
        }

        public static string[] GerarTabuada(int numeroTabuada)
        {
            string[] linhasTabuada = new string[10];



            for (int contagem = 1; contagem <= 10; contagem++)
            {
                int resultadoTabuada = numeroTabuada * contagem;

                linhasTabuada[contagem - 1] = $"{numeroTabuada} x {contagem} = {resultadoTabuada}";

            }

            return linhasTabuada;
        }

        public static string[] ObterHistorico()
        {
            return operacoesRealizadas;
        }

    }
}