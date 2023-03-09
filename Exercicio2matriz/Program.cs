internal class Program
{
    private static void Main(string[] args)
    {
        //  matriz de numeros inteiros de 5 x 5
        // faça as somas dos valores nos caminhos possíveis da matriz (coluna(s), linha(s) e diagonal(is)

        int[,] matriz = new int[5, 5];

        // montagem da matriz

        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                matriz[linha, coluna] += (linha * coluna)+1;
            }
        }

        // Impressao da matriz

        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                Console.Write($" [{matriz[linha, coluna]}]");
            }
            Console.WriteLine("\n");
        }

        // Soma da diagonal principal

        double soma = 0;
        for (int linha = 0;linha < matriz.GetLength(0); linha++)
        {
            for(int coluna = 0;coluna < matriz.GetLength(1); coluna++)
            {
                if (linha == coluna)
                soma += matriz[linha, coluna];
            }

        }
        Console.WriteLine($"Soma da diagonal principal é {soma}");

        // Soma da diagonal secundária

        soma = 0;
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                //soma += matriz[linha, matriz.GetLength(1)-linha-1];
                if (coluna == 4-linha)
                    soma += matriz[linha, coluna];
            }

        }
        Console.WriteLine($"Soma da diagonal secundária é {soma}");

        // Soma das linhas

        for(int linha = 0; linha< matriz.GetLength(0); linha++)
        {
            soma = 0;
            for ( int coluna = 0; coluna< matriz.GetLength(1); coluna++)
            {
                soma += matriz[linha, coluna];
            }
            Console.WriteLine($"A soma da linha {linha + 1} é = {soma}");

        }

        // Soma das colunas

        for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
        {
            soma = 0;
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                soma += matriz[linha, coluna];
            }
            Console.WriteLine($"A soma da coluna {coluna + 1} é = {soma}");

        }

    }
}