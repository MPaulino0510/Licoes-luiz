namespace JogoForca
{
    using System;
    using System.ComponentModel.Design;
    using System.Diagnostics.CodeAnalysis;
    using static System.Runtime.InteropServices.JavaScript.JSType;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int erros = 0;
            bool m = false;
            bool i = false;
            bool n = false;
            bool e = false;
            bool c = false;
            bool r = false;
            bool a = false;
            bool f = false;
            bool t = false;
            Console.WriteLine("Bem-vindo ao jogo da forca!");
            Console.WriteLine("A palavra a ser adivinhada tem 9 letras.");
            Console.WriteLine("Dica: É um jogo.");


        voltar:
            Console.WriteLine("\nDigite uma letra:");
            string letra = Console.ReadLine().ToLower();
            if (letra == "m")
                m = true;
            else if (letra == "i")
                i = true;
            else if (letra == "n")
                n = true;
            else if (letra == "e")
                e = true;
            else if (letra == "c")
                c = true;
            else if (letra == "r")
                r = true;

            else if (letra == "a")
                a = true;
            else if (letra == "f")
                f = true;
            else if (letra == "t")
                t = true;
            else
            {
                erros++;
                Console.WriteLine("Letra incorreta! Erros: " + erros);
            }
            Mostrar(m, i, n, e, c, r, a, f, t, erros);

            if (m && i && n && e && c && r && a && f && t) return;

            goto voltar;

            static void Mostrar(bool m, bool i, bool n, bool e, bool c, bool r, bool a, bool f, bool t, int erros)
            {
                if (m)
                    Console.Write("M");
                else
                    Console.Write("_");

                if (i)
                    Console.Write("I");
                else
                    Console.Write("_");

                if (n)
                    Console.Write("N");
                else
                    Console.Write("_");

                if (e)
                    Console.Write("E");
                else
                    Console.Write("_");

                if (c)
                    Console.Write("C");
                else
                    Console.Write("_");

                if (r)
                    Console.Write("R");
                else
                    Console.Write("_");

                if (a)
                    Console.Write("A");
                else
                    Console.Write("_");

                if (f)
                    Console.Write("F");
                else
                    Console.Write("_");

                if (t)
                    Console.Write("T");
                else
                    Console.Write("_");

                if (m && i && n && e && c && r && a && f && t)
                {
                    Console.WriteLine("\nParabéns! Você adivinhou a palavra!");
                }
                if (erros == 4)
                {
                    Console.WriteLine("\nVocê perdeu! A palavra era MINECRAFT");
                }



                if (erros == 4 || m && i && n && e && c && r && a && f && t)
                {
                    Console.WriteLine("Aperte 1 para continuar jogando ou 2 para sair.");
                    int.TryParse(Console.ReadLine(), out int opcao);
                    if (opcao != 1)
                    {
                        Environment.Exit(0);
                    }
                    else if (opcao == 1)
                    {
                        Console.Clear();
                        bool g = false;
                        bool i2 = false;
                        bool r2 = false;
                        bool a2 = false;
                        bool s = false;
                        bool s2 = false;
                        bool o = false;
                        bool l = false;
                        int erro = 0;
                        Console.WriteLine(" A palavra desta vez tem 8 letras.");
                        Console.WriteLine(" Dica: É uma flor.");
                    volta2:
                        Console.WriteLine("\nDigite uma letra:");
                        string letra2 = Console.ReadLine().ToLower();
                        if (letra2 == "g")
                            g = true;
                        else if (letra2 == "i")
                            i2 = true;
                        else if (letra2 == "r")
                            r2 = true;
                        else if (letra2 == "a")
                            a2 = true;
                        else if (letra2 == "s")
                        {
                            s = true;
                            s2 = true;
                        }
                        else if (letra2 == "o")
                            o = true;
                        else if (letra2 == "l")
                            l = true;
                        else
                        {
                            erro++;
                            Console.WriteLine("\nLetra errada! Número de erros:" + erro);
                        }
                        Mostrar2(g, i2, r2, a2, s, s2, o, l, erro);

                        if (g && i2 && r2 && a2 && s && s2 && o && l) return;
                        goto volta2;

                    }




                    static void Mostrar2(bool g, bool i2, bool r2, bool a2, bool s, bool s2, bool o, bool l, int erro)
                    {
                        if (g)
                            Console.Write("G");
                        else
                            Console.Write("_");

                        if (i2)
                            Console.Write("I");
                        else
                            Console.Write("_");

                        if (r2)
                            Console.Write("R");
                        else
                            Console.Write("_");
                        if (a2)
                            Console.Write("A");
                        else
                            Console.Write("_");
                        if (s)
                            Console.Write("S");
                        else
                            Console.Write("_");
                        if (s2)
                            Console.Write("S");
                        else
                            Console.Write("_");
                        if (o)
                            Console.Write("O");
                        else
                            Console.Write("_");
                        if (l)
                            Console.Write("L");
                        else
                            Console.Write("_");

                        if (g && i2 && r2 && a2 && s && s2 && o && l)
                        {
                            Console.WriteLine("\nParabéns! Você adivinhou a palavra!");
                        }
                        if (erro == 4)
                        {
                            Console.WriteLine("\nVocê perdeu! A palavra era GIRASSOL");
                        }
                        if (g && i2 && r2 && a2 && s && s2 && o && l || erro == 4)
                        {
                            Console.WriteLine("Pressione 1 para continuar e 2 para sair.");
                            int.TryParse(Console.ReadLine(), out int opcao2);


                            if (opcao2 != 1)
                            {
                                Environment.Exit(0);
                            }
                            else if (opcao2 == 1)
                            {
                                Console.Clear();
                                bool v = false;
                                bool i3 = false;
                                bool n2 = false;
                                bool g2 = false;
                                bool a3 = false;
                                bool d = false;
                                bool o2 = false;
                                bool r3 = false;
                                bool e2 = false;
                                bool s3 = false;
                                int erros2 = 0;
                                Console.WriteLine("A palavra tem 10 letras");
                                Console.WriteLine("O tema é: Filme ou série");

                            VoltaAqui:
                                Console.WriteLine("\nDigite uma letra");
                                string LETRA = Console.ReadLine().ToLower();
                                if (LETRA == "v")
                                    v = true;
                                else if (LETRA == "i")
                                    i3 = true;
                                else if (LETRA == "n")
                                    n2 = true;
                                else if (LETRA == "g")
                                    g2 = true;
                                else if (LETRA == "a")
                                    a3 = true;
                                else if (LETRA == "d")
                                    d = true;
                                else if (LETRA == "o")
                                    o2 = true;
                                else if (LETRA == "r")
                                    r3 = true;
                                else if (LETRA == "e")
                                    e2 = true;
                                else if (LETRA == "s")
                                    s3 = true;
                                else
                                {
                                    erros2++;
                                    Console.WriteLine("\nVocê errou! Erros:" + erros2);
                                }
                                Mostrar3(v, i3, n2, g2, a3, d, o2, r3, e2, s3, erros2);

                                if (v && i3 && n2 && g2 && a3 && d && o2 && r3 && e2 && s3) return;
                                goto VoltaAqui;


                            }
                            static void Mostrar3(bool v, bool i3, bool n2, bool g2, bool a3, bool d, bool o2, bool r3, bool e2, bool s3, int erros2)
                            {
                                if (v)
                                    Console.Write("V");
                                else
                                    Console.Write("_");

                                if (i3)
                                    Console.Write("I");
                                else
                                    Console.Write("_");

                                if (n2)
                                    Console.Write("N");
                                else
                                    Console.Write("_");
                                if (g2)
                                    Console.Write("G");
                                else
                                    Console.Write("_");
                                if (a3)
                                    Console.Write("A");
                                else
                                    Console.Write("_");
                                if (d)
                                    Console.Write("D");
                                else
                                    Console.Write("_");
                                if (o2)
                                    Console.Write("O");
                                else
                                    Console.Write("_");
                                if (r3)
                                    Console.Write("R");
                                else
                                    Console.Write("_");
                                if (e2)
                                    Console.Write("E");
                                else
                                    Console.Write("_");
                                if (s3)
                                    Console.Write("S");
                                else
                                    Console.Write("_");

                                if (v && i3 && n2 && g2 && a3 && d && o2 && r3 && e2 && s3)
                                {
                                    Console.WriteLine("\nParabéns! Você acertou!");
                                    Environment.Exit(0);
                                }
                                if (erros2 == 4)
                                {
                                    Console.WriteLine("\nVocê perdeu! A palavra era VINGADORES!");
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}