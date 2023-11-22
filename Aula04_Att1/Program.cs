using System;

internal class Program// classe
{
    private static void Main(string[] args)// método principal
    {
        // Criando três variáveis que recebem valores e somam os mesmos
        int n1, n2, n3;

        // Obtendo valores

        Console.Write("Olá usuário, digite o número 1: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("agora, digite o número 2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        // Processando

        n3 = n1 + n2;

        // Exibindo

        Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, n3);
        Console.ReadLine();
    }
}