using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Se você é humano, digite sim");
string humano = Console.ReadLine();
if (humano != "sim")
{
    Console.WriteLine("Você não está permitido a prosseguir");
}
else if (humano == "sim")
{ 
    Console.WriteLine("Você tem documento?");
}
string documento = Console.ReadLine();
if (documento != "sim")
{
    Console.WriteLine("Saia");
}
else if (documento == "sim")
{
    Console.WriteLine("Digite sua idade");
}
int.TryParse(Console.ReadLine(), out int idade);
if (idade <= 18)
{
    Console.WriteLine("você não está permitido a prosseguir");
}
else if (idade >= 18)
{
    Console.WriteLine("Você está autorizado a entrar");
    Console.WriteLine("\nEspera, antes digite seu nome inicial");
}
string nome = (Console.ReadLine());
if (nome == "Tardin")
{
    Console.WriteLine("Vai se ferrar Tardin");
}




