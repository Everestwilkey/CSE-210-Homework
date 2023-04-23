using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your percentage on your grade? ");
        string score = Console.ReadLine();

        int ScoreNumber = int.Parse(score);

        if (ScoreNumber >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (ScoreNumber >= 80)
        {
            Console.WriteLine("You have an B");
        }
        else if (ScoreNumber >= 70)
        {
            Console.WriteLine("You have an C");
        }
        else if (ScoreNumber >= 60)
        {
            Console.WriteLine("You have an D");
        }
        else if (ScoreNumber < 60)
        {
            Console.WriteLine("You have an F");
        }
        if (ScoreNumber >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Ummm.. you didn't make it....");
        }
    }
}