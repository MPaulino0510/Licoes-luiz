using System;
using System.Media;

class Program
{
    static void Main()
    {
        try
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\dev\Downloads\videoplayback.wav");
            player.PlaySync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadKey();
    }
}