using NAudio.Wave;
using System;
using System.IO;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vinda à empresa de bem-estar da Lavinha");
        Console.WriteLine("Este é o cálculo de IMC");

        Console.Write("Coloque aqui seu peso: ");
        float.TryParse(Console.ReadLine(), out float peso);

        Console.Write("Coloque aqui sua altura: ");
        float.TryParse(Console.ReadLine(), out float altura);

        // Cálculo do IMC
        float imc = (float)(peso / Math.Pow(altura, 2));

        Console.Clear();
        Console.WriteLine("Calculando...");
        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine($"Seu IMC é: {imc:F2}");

        // Classificação do IMC
        if (imc < 18.5)
        {
            Console.WriteLine("Você está magra");
            TocarSom("Correto.mp3");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Você está com um peso normal");

            // 🔊 TOCA SOM AQUI (som de correto)
            TocarSom("Correto.mp3");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Você está acima do peso");
        }
        else if (imc >= 30 && imc <= 39.9)
        {
            Console.WriteLine("Você está obesa");
        }
        else if (imc >= 40)
        {
            Console.WriteLine("Você está com obesidade severa");
            TocarSom("Erro.mp3");
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }

        Console.ReadKey();
    }

    static void TocarSom(string nomeArquivo)
    {
        try
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            using (var audioFile = new AudioFileReader(caminho))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(200);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tocar som:");
            Console.WriteLine(ex.Message);
        }
    }
}