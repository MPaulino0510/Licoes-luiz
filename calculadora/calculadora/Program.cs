namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operacao = ' ';
            float resultado = 0;
            Console.WriteLine("Está é a calculadora automática, escolha a operação:\nsoma +\nsubtração -\nmultiplicação *\ndivisão/");
            operacao = char.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o primeiro número");
            float.TryParse(Console.ReadLine(), out float a);
            Console.WriteLine("Escreva o segundo número");
            float.TryParse(Console.ReadLine(), out float b);
            switch (operacao)
            {
                case '+':
                    resultado = a + b;
                    Console.WriteLine($"Seu resultado é {resultado}.");
                    break;
                case '-':
                    resultado = a - b;
                    Console.WriteLine($"Seu resultado é {resultado}.");
                    break;
                case '*':
                    resultado = a * b;
                    Console.WriteLine($"Seu resultado é {resultado}.");
                    break;
                case '/':
                    resultado = a / b;
                    Console.WriteLine($"Seu resultado é {resultado}.");
                    break;
                default:
                    resultado = -1;
                    break;
            }
            if (resultado == -1){
                Console.WriteLine("Operação inválida!");
            }
        }
    }
}

