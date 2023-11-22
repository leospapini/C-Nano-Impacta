internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tipos Primitivos");

        string nome = "Leonardo";

        //os 3 tipos de inteiro, short menor, int médio, long grande
        //ou short int16, int int32 e long int64

        short quantidade = 20;
        int numero = 100;
        long numeroGrande = 120000;
        byte item = 20;//0 a 255, tipicamente usado para um arquivo ou elemento de um arquivo

        // int, Int32 e System.Int32 são 3 formas de utilizar a mesma classe inteiro

        double comissao = 32.454654654;// ponto flutuante, números quebrados(decimais)
        decimal valor = 1000;// valores monetários inteiros, não decimais
        decimal dinheiro = Convert.ToDecimal(1000.43);// agora ele converte um double em decimal
        decimal valor1 = 1000.64m;// este m no final converte automaticamente para decimal

        DateTime data = DateTime.Now;
        DateTime dataExemplo = new DateTime(2050, 12, 31);
        Console.WriteLine(data);// data em números do dia atual e hora atual
        Console.WriteLine(dataExemplo);// data do dia específico com hora zerada

        // Formatar uma data

        Console.WriteLine("{0:d}", dataExemplo);// d = data em números sem hora
        Console.WriteLine("{0:D}", dataExemplo);// D = data por extenso
        Console.WriteLine("{0:ddd}", dataExemplo);// ddd = 3 letras relativas ao dia da semana
        Console.WriteLine("{0:dddd}", dataExemplo);// dddd = dia da semana por extenso

        Console.WriteLine("{0:c}", valor1);// c = moeda(currency) no formato padrão do SO utilizado
        Console.ReadLine();
    }
}