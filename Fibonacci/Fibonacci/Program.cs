using System;

using System.Diagnostics.CodeAnalysis;

using static System.Runtime.InteropServices.JavaScript.JSType;



class Program

{



    static void Main()

    {

        int erro = 0;

        bool f = false;

        bool l = false;

        bool o = false;

        bool a = false;

        bool t = false;



        Console.WriteLine("A muito tempo foi criado o famoso jogo da forca. \n" +

            "Quem hoje acredita que seja uma simples brincadeira, mal sabe \n" +

            "que foi feita para decidir a vida ou a morte. A muitos anos, \n" +

            "uma prisão enfrentava problemas de superlotação, e os guardas, \n" +

            "entediados, decidiram fazer uma “brincadeira” semanal entre os detentos. \n" +

            "Essa, no qual eles teriam que adivinhar a palavra, apenas dando algumas letras, \n" +

            "porém com poucas chances. Se o presidiário errasse três vezes, \n" +

            "este seria assassinado na forca na frente de todos, sem nenhuma dignidade. \n" +

            "Já se ele acertasse, estaria vivo por mais uma semana, talvez.");

        Console.WriteLine("O tema de hoje, será: C#!");

        Console.WriteLine("Funcionará deste modo, escreva uma letra, de acordo com os espaços vazios, se você acertar a palavra\n" +

          "você não se churrascará, caso erre 3 vezes, perde. \nNúmero de letras:" +

          "\n_____");



    tentativa1:

        if (erro >= 3) { Mostrar(f, l, o, a, t, erro); return; }



        Console.WriteLine("Digite alguma letra:");

        string palavras = Console.ReadLine();



        if (palavras == "f") f = true;

        else if (palavras == "l") l = true;

        else if (palavras == "o") o = true;

        else if (palavras == "a") a = true;

        else if (palavras == "t") t = true;

        else { erro++; Console.WriteLine("Você errou!"); }



        Mostrar(f, l, o, a, t, erro);



        if (f && l && o && a && t) return;



        goto tentativa1;





        static void Mostrar(bool f, bool l, bool o, bool a, bool t, int erro)

        {

            if (f)

                Console.Write("f");

            else

                Console.Write("_");



            if (l)

                Console.Write("l");

            else

                Console.Write("_");



            if (o)

                Console.Write("o");

            else

                Console.Write("_");



            if (a)

                Console.Write("a");

            else

                Console.Write("_");



            if (t)

                Console.Write("t");

            else

                Console.Write("_");



            if (f && l && o && a && t)

                Console.WriteLine("\nVocê ganhou!");



            if (erro >= 3)

                Console.WriteLine("\nVocê perdeu!");

        }

    }

}