internal class Program
{
    private static void Main(string[] args)
    {
        // formas de pagamento
        // se o valor for maior que 1000, pode parcelar em 3x
        // se não apenas a vista

        decimal valorCompra;
        int parcelas = 3;
        decimal valorParcela;
        decimal valorMinimoParcelar = 1000.0m;

        Console.Write("Digite o valor da compra: ");
        valorCompra = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Valor a vista: {0:c}", valorCompra);

        if (valorCompra >= valorMinimoParcelar && valorCompra <= 1500)
        {
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }
        else if (valorCompra > 1500 && valorCompra < 2000)
        {
            parcelas = 4;
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }
        else if (valorCompra > 2000 && valorCompra < 2500)
        {
            parcelas = 5;
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }
        else if (valorCompra > 2500 && valorCompra < 3000)
        {
            parcelas = 6;
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }
        else if (valorCompra > 3000 && valorCompra < 3500)
        {
            parcelas = 7;
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }
        else if (valorCompra > 3500 && valorCompra < 4000)
        {
            parcelas = 8;
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }
        else if (valorCompra > 4000 && valorCompra < 4500)
        {
            parcelas = 9;
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }
        else if (valorCompra > 4500)
        {
            parcelas = 10;
            valorParcela = valorCompra / parcelas;
            Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", parcelas, valorParcela);
        }



        Console.ReadLine();
    }
}