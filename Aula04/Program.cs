﻿internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int idade;

        Console.WriteLine("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        int dias = idade * 365;

        Console.WriteLine("Olá {0}, você já viveu {1} dias", nome, dias);
        Console.ReadLine();
    }
}