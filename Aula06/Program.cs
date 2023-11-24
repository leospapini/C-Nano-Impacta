internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um número entre 1 e 10: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Operadores lógicos: || (ou) && (e)
        if (n < 1 || n > 10)
        {
            Console.WriteLine("Número errado!");
        }
        else 
        { 
            Console.WriteLine("Obrigado."); 
        }

        int hora = DateTime.Now.Hour;
        if (hora > 17)
        {
            Console.WriteLine("Boa noite");
        }
        else if (hora > 11)
        {
            Console.WriteLine("Boa tarde");
        }
        else
        {
            Console.WriteLine("Bom dia");
        }

        string mensagem = string.Empty;
        switch (hora)
        {
            case 20:
            case 21:
                mensagem = "Hora do intervalo";
                break;
            case 23:
                mensagem = "Hora da janta";
                break;
            default:
                mensagem = string.Empty;
                break;
        }

        Console.ReadLine();
    }
}