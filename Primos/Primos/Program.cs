using System.Runtime.InteropServices;
using System;
class Program
{
    static void Main()
    {
        Console.Write("Escreva aqui um valor limite, todos abaixo deste, serão números primos: ");
        float.TryParse(Console.ReadLine(), out float limite);
        for (int i = 1; i <= limite; i++)
        {
            int contador = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    contador++;
            }
            if (contador == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}