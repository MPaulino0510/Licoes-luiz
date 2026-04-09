namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {                Console.WriteLine($"Tabuada do {i}");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j}=  { i * j}");
                }
            }




}        }
    }