using System;

namespace exeMatrix01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas:");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            Console.WriteLine("---------------------------");
            for (int i = 0; i < m; i++ )
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n;  j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("digite o valor de x: ");
            int x = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                   
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("posição: " + i +"," + j);
                        if (i - 1 >= 0)//cima
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        if (i + 1 < m)//baixo
                            Console.WriteLine("Baixo: " + mat[i + 1, j]);
                        if (j - 1 >= 0)//Esquerda
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        if (j + 1 < n)//Direita
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
        }
    }
}
