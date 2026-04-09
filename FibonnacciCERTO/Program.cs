namespace Fibonnacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva aqui um limite para a sua sequência fibonacci: ");
            int.TryParse(Console.ReadLine(), out int limite);
            int termos, t1 = 0, t2 = 2, t3 = 4;
            for (int i = 0; i < limite; i++)
            {
                t3 = t1 + t2;
                t1 = t2;
                t2 = t3;
                Console.Write($"{t3} --> ");
            }
        }
    }
}
