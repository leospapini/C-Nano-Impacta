internal class Program
{
    private static void Main(string[] args)
    {
        // Estruturas de repetição
        // for(inicia, condição, incremento)

        /*
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        */

        // while (condição){}, do {}while (condição);
        /*
        string senha = "123";
        string senhaInformada = string.Empty;

        while (senha != senhaInformada)
        {
            Console.Write("Digite a senha: ");
            senhaInformada = Console.ReadLine();
        }
        Console.WriteLine("Fim");
        */

        // A diferença da utilização do (do) é que a condição vem depois, caso utilizemos apenas o while
        // ela é verificada primeiro antes da execução do restante do algoritmo 
        string senha = "123";
        string senhaInformada = string.Empty;
        do
        {
            Console.Write("Digite a senha: ");
            senhaInformada = Console.ReadLine();
            if (senhaInformada != senha)
            {
                Console.WriteLine("Senha Incorreta!");
            }
        } while (senhaInformada != senha);
        Console.WriteLine("Senha correta!");
        Console.ReadLine();
    }
}