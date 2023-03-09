internal class Program
{
    private static void Main(string[] args)
    {
        //  matriz de numeros inteiros de 5 x 5
        // faça as somas dos valores nos caminhos possíveis da matriz (coluna(s), linha(s) e diagonal(is)

        int[,] matriz = new int[5, 5];

        // montagem da matriz

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                matriz[linha, coluna] += (linha * coluna)+1;
            }
        }

        // Impressao da matriz

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                Console.WriteLine($"Posição [{linha},{coluna}] = valor: {matriz[linha, coluna]}");
            }
        }

        // Soma da diagonal principal

        double soma = 0;
        for (int linha = 0;linha < 5; linha++)
        {
            for(int coluna = 0;coluna < 5; coluna++)
            {
                if (linha == coluna)
                soma += matriz[linha, coluna];
            }

        }
        Console.WriteLine($"Soma da diagonal principal é {soma}");

        // Soma da diagonal secundária

        soma = 0;
        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                if (coluna == 4-linha)
                    soma += matriz[linha, coluna];
            }

        }
        Console.WriteLine($"Soma da diagonal secundária é {soma}");

        // Soma das linhas

        for(int linha = 0; linha<5; linha++)
        {
            soma = 0;
            for ( int coluna = 0; coluna<5; coluna++)
            {
                soma += matriz[linha, coluna];
            }
            Console.WriteLine($"A soma da linha {linha + 1} é = {soma}");

        }

        // Soma das colunas

        for (int coluna = 0; coluna < 5; coluna++)
        {
            soma = 0;
            for (int linha = 0; linha < 5; linha++)
            {
                soma += matriz[linha, coluna];
            }
            Console.WriteLine($"A soma da coluna {coluna + 1} é = {soma}");

        }

    }
}