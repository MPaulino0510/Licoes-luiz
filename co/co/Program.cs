
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static int width = 30;
    static int height = 20;

    static int playerX = 15;

    static List<(int, int)> bullets = new List<(int, int)>();
    static List<(int, int)> enemies = new List<(int, int)>();

    static Random rand = new Random();
    static bool gameOver = false;
    static int score = 0;

    static void Main()
    {
        Console.CursorVisible = false;

        while (!gameOver)
        {
            Input();
            Update();
            Draw();
            Thread.Sleep(100);
        }

        Console.SetCursorPosition(0, height + 2);
        Console.WriteLine("Game Over! Score: " + score);
    }

    static void Input()
    {
        if (!Console.KeyAvailable) return;

        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.LeftArrow && playerX > 0)
            playerX--;
        else if (key == ConsoleKey.RightArrow && playerX < width - 1)
            playerX++;
        else if (key == ConsoleKey.Spacebar)
            bullets.Add((playerX, height - 2));
    }

    static void Update()
    {
        // mover tiros
        for (int i = 0; i < bullets.Count; i++)
        {
            bullets[i] = (bullets[i].Item1, bullets[i].Item2 - 1);
        }

        bullets.RemoveAll(b => b.Item2 < 0);

        // spawn inimigos
        if (rand.Next(5) == 0)
        {
            enemies.Add((rand.Next(width), 0));
        }

        // mover inimigos
        for (int i = 0; i < enemies.Count; i++)
        {
            enemies[i] = (enemies[i].Item1, enemies[i].Item2 + 1);
        }

        // colisão tiro vs inimigo
        for (int i = 0; i < bullets.Count; i++)
        {
            for (int j = 0; j < enemies.Count; j++)
            {
                if (bullets[i] == enemies[j])
                {
                    bullets.RemoveAt(i);
                    enemies.RemoveAt(j);
                    score++;
                    return;
                }
            }
        }

        // colisão inimigo com jogador
        foreach (var e in enemies)
        {
            if (e.Item2 == height - 1 && e.Item1 == playerX)
            {
                gameOver = true;
            }
        }
    }

    static void Draw()
    {
        Console.SetCursorPosition(0, 0);

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x == playerX && y == height - 1)
                    Console.Write("A"); // jogador
                else if (bullets.Exists(b => b.Item1 == x && b.Item2 == y))
                    Console.Write("|"); // tiro
                else if (enemies.Exists(e => e.Item1 == x && e.Item2 == y))
                    Console.Write("V"); // inimigo
                else
                    Console.Write(".");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Score: " + score);
    }
}