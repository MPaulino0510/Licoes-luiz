namespace Atividade_Heroi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual será o nome do seu Herói?");
            string heroi = Console.ReadLine();
            Console.WriteLine("Digite a classe do seu herói: Mago, Clérigo, Guerreiro, Druida, Anão, Elfo ou Troll\n");
            string classe = Console.ReadLine();
            Console.WriteLine("Nível:");
            int nivel = int.Parse(Console.ReadLine());
            Console.WriteLine("HP (pontos de vida):");
            float.TryParse(Console.ReadLine(), out float HP);
            Console.WriteLine("Digite seus pontos de magia (mana):");
            int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quanto de ouro você possui na mochila:");
            float.TryParse(Console.ReadLine(), out float ouro);
            if (classe == "Troll" && nivel <= 5)
            {
                Console.WriteLine("você não está autorizado a entrar");
            }
            else if (classe != "Troll" && nivel >= 5)
            {
                Console.WriteLine("Você pode entrar na guilda!");
            }


        }
    }
}
