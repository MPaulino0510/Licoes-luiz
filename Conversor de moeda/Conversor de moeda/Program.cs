using System.Globalization;

namespace Conversor_de_moeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este é o conversor de moeda");
            Console.Write("Digite um valor que você quer converter: ");
            float.TryParse(Console.ReadLine(), out float moeda);
            Console.Write("Digite os valores abaixo de acordo com a conversão que você preferir \n1 Para dólar \n2 Para Libras \n3 Para euro " +
                "\n4 Para franco \n5 Para iene \n6 Para bitcoin \nDigite a opção: ");
            int.TryParse(Console.ReadLine(), out int escolha);
            Console.WriteLine("Calculando...");
            Thread.Sleep(1500);
            switch (escolha)
            {
                case 1:
                    Console.WriteLine($"A conversão de {moeda} para dólar é: {moeda * 5.18:F2}");
                    break;
                case 2:
                    Console.WriteLine($"A conversão de {moeda} para Libras é: {moeda * 6.85:F2}");
                    break;
                case 3:
                    Console.WriteLine($"A conversão de {moeda} para euro é: {moeda * 5.98:F2}");
                    break;
                case 4:
                    Console.WriteLine($"A conversão de {moeda} para franco é: {moeda * 6.50:F2}");
                    break;
                case 5:
                    Console.WriteLine($"A conversão de {moeda} para iene é: {moeda * 0.032:F2}");
                    break;
                case 6:
                    Console.WriteLine($"A conversão de {moeda} para bitcoin é: {moeda / 343019.50:F2}");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
