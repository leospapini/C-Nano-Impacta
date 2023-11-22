internal class Program
{
    private static void Main(string[] args)
    {
        // Obtendo valores
        Console.Write("Digite o valor do produto: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a quantidade: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        // Calcular

        decimal resultado = quantidade * valor;

        Console.WriteLine("Total da compra: {0:c}", resultado);
        Console.ReadLine();

        // Bonus

        double desconto = Convert.ToDouble(resultado);
        double valorDesconto = desconto * 0.1;
        Console.WriteLine("O desconto aplicado é de: {0:c}", valorDesconto);
        double novoTotal = desconto - valorDesconto;
        Console.WriteLine("Novo valor: {0:c}", novoTotal);
        Console.ReadLine();

        // Parcelas

        Console.Write("Quantas parcelas? ");
        double parcelas = Convert.ToDouble(Console.ReadLine());

        double valorParcelado = novoTotal / parcelas;
        Console.WriteLine("O valor das parcelas da compra é: {0:c}", valorParcelado);
        Console.ReadLine();
    }
}