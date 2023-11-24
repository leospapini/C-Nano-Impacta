internal class Program
{
    private static void Main(string[] args)
    {
        // Construir uma tabuada de qualquer número
        Console.Write("Qual a tabuada desejada? ");
        int numero = Convert.ToInt32(Console.ReadLine());
        string valor = string.Empty;

        do
        {
            if (valor != string.Empty)
            {
                numero = Convert.ToInt32(valor);
            }
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }
            Console.WriteLine();
            Console.Write("Digite a tabuada ou enter para sair: ");
            valor = Console.ReadLine();
        } while (valor != string.Empty);

        Console.ReadLine();
    }
}