using System.ComponentModel.Design;
using System.Text;

namespace jogo_velho
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bem vindo ao jogo da velha!");
            Console.WriteLine("Cada slot do jogo, é um número, escolha um número para jogar.");
            Console.WriteLine("  1  |  2  |  3  ");
            Console.WriteLine("————–|————–|————–");
            Console.WriteLine("  4  |  5  |  6  ");
            Console.WriteLine("————–|————–|————–");
            Console.WriteLine("  7  |  8  |  9  ");
            int.TryParse(Console.ReadLine(), out int escolhaum);
            if (escolhaum == 1)
            {
                Console.WriteLine("  ❌ |  2  |  3  ");
                Console.WriteLine("————–|————–|————–");
                Console.WriteLine("  4  |  5  |  6  ");
                Console.WriteLine("————–|————–|————–");
                Console.WriteLine("  7  |  8  |  9  ");
                if (escolhaum == 2)
                    Console.WriteLine("  1  | ❌ |  3  ");
                Console.WriteLine("————–|————–|————–");
                Console.WriteLine("  4  |  5  |  6  ");
                Console.WriteLine("————–|————–|————–");
                Console.WriteLine("  7  |  8  |  9  ");
                if (escolhaum == 1)
                {
                    Console.WriteLine("  ❌ |  2  |  3  ");
                    Console.WriteLine("————–|————–|————–");
                    Console.WriteLine("  4  |  5  |  6  ");
                    Console.WriteLine("————–|————–|————–");
                    Console.WriteLine("  7  |  8  |  9  ");
                    if (escolhaum == 2)
                        Console.WriteLine("  1  | ❌ |  3  ");
                    Console.WriteLine("————–|————–|————–");
                    Console.WriteLine("  4  |  5  |  6  ");
                    Console.WriteLine("————–|————–|————–");
                    Console.WriteLine("  7  |  8  |  9  ");
                    if (escolhaum == 1)
                    {
                        Console.WriteLine("  ❌ |  2  |  3  ");
                        Console.WriteLine("————–|————–|————–");
                        Console.WriteLine("  4  |  5  |  6  ");
                        Console.WriteLine("————–|————–|————–");
                        Console.WriteLine("  7  |  8  |  9  ");
                        if (escolhaum == 2)
                            Console.WriteLine("  1  | ❌ |  3  ");
                        Console.WriteLine("————–|————–|————–");
                        Console.WriteLine("  4  |  5  |  6  ");
                        Console.WriteLine("————–|————–|————–");
                        Console.WriteLine("  7  |  8  |  9  ");
                        if (escolhaum == 1)
                        {
                            Console.WriteLine("  ❌ |  2  |  3  ");
                            Console.WriteLine("————–|————–|————–");
                            Console.WriteLine("  4  |  5  |  6  ");
                            Console.WriteLine("————–|————–|————–");
                            Console.WriteLine("  7  |  8  |  9  ");
                            if (escolhaum == 2)
                                Console.WriteLine("  1  | ❌ |  3  ");
                            Console.WriteLine("————–|————–|————–");
                            Console.WriteLine("  4  |  5  |  6  ");
                            Console.WriteLine("————–|————–|————–");
                            Console.WriteLine("  7  |  8  |  9  ");
                            if (escolhaum == 1)
                            {
                                Console.WriteLine("  ❌ |  2  |  3  ");
                                Console.WriteLine("————–|————–|————–");
                                Console.WriteLine("  4  |  5  |  6  ");
                                Console.WriteLine("————–|————–|————–");
                                Console.WriteLine("  7  |  8  |  9  ");
                                if (escolhaum == 2)
                                    Console.WriteLine("  1  | ❌ |  3  ");
                                Console.WriteLine("————–|————–|————–");
                                Console.WriteLine("  4  |  5  |  6  ");
                                Console.WriteLine("————–|————–|————–");
                                Console.WriteLine("  7  |  8  |  9  ");
                                if (escolhaum == 1)
                                {
                                    Console.WriteLine("  ❌ |  2  |  3  ");
                                    Console.WriteLine("————–|————–|————–");
                                    Console.WriteLine("  4  |  5  |  6  ");
                                    Console.WriteLine("————–|————–|————–");
                                    Console.WriteLine("  7  |  8  |  9  ");
                                    if (escolhaum == 2)
                                        Console.WriteLine("  1  | ❌ |  3  ");
                                    Console.WriteLine("————–|————–|————–");
                                    Console.WriteLine("  4  |  5  |  6  ");
                                    Console.WriteLine("————–|————–|————–");
                                    Console.WriteLine("  7  |  8  |  9  ");
                                    if (escolhaum == 1)
                                    {
                                        Console.WriteLine("  ❌ |  2  |  3  ");
                                        Console.WriteLine("————–|————–|————–");
                                        Console.WriteLine("  4  |  5  |  6  ");
                                        Console.WriteLine("————–|————–|————–");
                                        Console.WriteLine("  7  |  8  |  9  ");
                                        if (escolhaum == 2)
                                            Console.WriteLine("  1  | ❌ |  3  ");
                                        Console.WriteLine("————–|————–|————–");
                                        Console.WriteLine("  4  |  5  |  6  ");
                                        Console.WriteLine("————–|————–|————–");
                                        Console.WriteLine("  7  |  8  |  9  ");
                                        if (escolhaum == 1)
                                        {
                                            Console.WriteLine("  ❌ |  2  |  3  ");
                                            Console.WriteLine("————–|————–|————–");
                                            Console.WriteLine("  4  |  5  |  6  ");
                                            Console.WriteLine("————–|————–|————–");
                                            Console.WriteLine("  7  |  8  |  9  ");
                                            if (escolhaum == 2)
                                                Console.WriteLine("  1  | ❌ |  3  ");
                                            Console.WriteLine("————–|————–|————–");
                                            Console.WriteLine("  4  |  5  |  6  ");
                                            Console.WriteLine("————–|————–|————–");
                                            Console.WriteLine("  7  |  8  |  9  ");
                                            if (escolhaum == 1)
                                            {
                                                Console.WriteLine("  ❌ |  2  |  3  ");
                                                Console.WriteLine("————–|————–|————–");
                                                Console.WriteLine("  4  |  5  |  6  ");
                                                Console.WriteLine("————–|————–|————–");
                                                Console.WriteLine("  7  |  8  |  9  ");
                                                if (escolhaum == 2)
                                                    Console.WriteLine("  1  | ❌ |  3  ");
                                                Console.WriteLine("————–|————–|————–");
                                                Console.WriteLine("  4  |  5  |  6  ");
                                                Console.WriteLine("————–|————–|————–");
                                                Console.WriteLine("  7  |  8  |  9  ");
                                                if (escolhaum == 1)
                                                {
                                                    Console.WriteLine("  ❌ |  2  |  3  ");
                                                    Console.WriteLine("————–|————–|————–");
                                                    Console.WriteLine("  4  |  5  |  6  ");
                                                    Console.WriteLine("————–|————–|————–");
                                                    Console.WriteLine("  7  |  8  |  9  ");
                                                    if (escolhaum == 2)
                                                        Console.WriteLine("  1  | ❌ |  3  ");
                                                    Console.WriteLine("————–|————–|————–");
                                                    Console.WriteLine("  4  |  5  |  6  ");
                                                    Console.WriteLine("————–|————–|————–");
                                                    Console.WriteLine("  7  |  8  |  9  ");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

