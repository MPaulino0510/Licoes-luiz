
namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A matemática é a ciência que estuda grandezas, formas, estruturas e variações, " +
                "\nutilizando o raciocínio lógico para compreender e modelar fenômenos reais. \nEssencial no dia a dia," +
                "ela viabiliza desde transações financeiras e culinária até a tecnologia avançada," +
                "\ncomo inteligência artificial, criptografia e análise de dados.");
            string texto = "A matemática é a ciência que estuda grandezas, formas, estruturas e variações, " +
                "utilizando o raciocínio lógico para compreender e modelar fenômenos reais. Essencial no dia a dia," +
                "ela viabiliza desde transações financeiras e culinária até a tecnologia avançada," +
                "como inteligência artificial, criptografia e análise de dados.".Replace(",", "").Replace(".", "").Replace("\n", ""); 
            Console.Write("\n\nEscreva aqui alguma palavra que você queira encontrar no texto: ");
            string procura = Console.ReadLine().Trim();
            string[] palavras = texto.Split(' ');
            for (int percorrer = 0; percorrer < palavras.Length; percorrer++)
            //(O "Length significa quantas casas tem a array, então palavras (o texto em arrays) tem x quantidade de casas, e essas casas são as lenght.
            if (palavras[percorrer].ToLower() == procura.ToLower())
                {
                    int inicio = Math.Max(0, percorrer - 3);
                    int final = Math.Min(palavras.Length -1,percorrer + 3);
                    Console.WriteLine("\n\nSua palavra está localizada em:");
                    for (int escrever = inicio; escrever <= final; escrever++)
                    {
                        Console.Write($"{palavras [escrever]}" + " ");
                    }
                }
            Console.WriteLine();
        }
    }
}
