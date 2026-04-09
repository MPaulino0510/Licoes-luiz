namespace Mago_merlin
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("O Deus da profanidade (infofuxo) ataca novamente! Digite o número do raio do \n" +
                "Circulo para acertá-lo, se a área for maior que 10, você vence!");
            Console.WriteLine("Antes disso, você Mago Merlin, precisará treinar muito, para isto,\n" +
                "digite um valor de área de quadrado que seja menor ou igual a 10, e o Mago triplicará esse valor (para treinar as suas habilidades" +
                "\nde forças mágicas geométricas");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Escreva aqui o lado: ");
                float.TryParse(Console.ReadLine(), out float lado);
                float r = lado * lado;
                Console.WriteLine($"Seu nível é: {r}");
            }



            Console.Write("\nDigite o valor do raio aqui: ");
            int.TryParse(Console.ReadLine(), out int raio);
            float circulo = (raio * raio) * 3.14f;
            if (circulo < 10)
            {
                Console.WriteLine("Você perdeu!!");
            }
            else
            {
                Console.WriteLine("Você ganhou!!");
            }
            Console.WriteLine("Para continuar, digite 1, para parar, digite 2");
            int.TryParse(Console.ReadLine(), out int OPCAO);
            if (OPCAO != 1)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("Bem vindo ao portal da arqueologia. Digite um valor abaixo para anotar seu fóssil:" +
                    "\nDigite 1 para registrar poríferos." +
                    "\nDigite 2 para registrar cnídários." +
                    "\nDigite 3 para registrar platelmintos." +
                    "\nDigite 4 para registrar moluscos." +
                    "\nDigite 5 para registrar anelídeos." +
                    "\nDigite 6 para registrar artrópodes." +
                    "\nDigite 7 para registrar urucordados.");

                int.TryParse(Console.ReadLine(), out int opcao);
                switch (opcao)
                {
                    case (1):
                        Console.WriteLine("Você escolheu poríferos");
                        break;
                    case (2):
                        Console.WriteLine("Você escolheu cnídários");
                        break;
                    case (3):
                        Console.WriteLine("Você escolheu platelmintos");
                        break;
                    case (4):
                        Console.WriteLine("Você escolheu moluscos");
                        break;
                    case (5):
                        Console.WriteLine("Você escolheu anelídeos");
                        break;
                    case (6):
                        Console.WriteLine("Você escolheu artrópodes");
                        break;
                    case (7):
                        Console.WriteLine("Você escolheu urucordados");
                        break;
                }

            }
        }
    }
}
