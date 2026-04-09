namespace Lição
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Escreva aqui o capital: ");
            float.TryParse(Console.ReadLine(), out float c);
            Console.Write("Digite agora a taxa, porcentagem do juros: ");
            float.TryParse(Console.ReadLine(), out float p);
            Console.Write("Agora, digite o tempo que foi investido ou emprestado: ");
            float.TryParse(Console.ReadLine(), out float t);
            float p2 = p / 100f;
            float resultado = c * p2 * t;

            
        }
    }
}
