//Cálculo 
Console.WriteLine("Digite o valor em metros por segundo");
Console.WriteLine($"O resultado de {MetrosPs} * {conversao} é {resultado}");
float MetrosPs;
float.TryParse(Console.ReadLine(),out MetrosPs);
float conversao = 3.6f;
float resultado = (MetrosPs * conversao);

