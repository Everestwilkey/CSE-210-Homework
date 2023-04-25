using System;

class Program
{
    static void Main(string[] args)
    {
        bool RunProgram = true;
        while (RunProgram)
        {
            Random randomGenerator = new Random();

            int MajicNumber = randomGenerator.Next(1, 11);

            Console.WriteLine("welcome to guess the majic number");
        
            string YouWon = "no";
            
                do 
                {
                    Console.Write("guess your number: ");

                    string Userguess = Console.ReadLine();

                    int guess = int.Parse(Userguess);
                    if (guess == MajicNumber)
                    {
                        Console.WriteLine($"congrats the number was {MajicNumber}");
                        YouWon = "yes" ;
                        Console.Write("Do you wish to play again?");
                        string userInput = Console.ReadLine();
                            if (userInput == "yes")
                            {
                                Console.Write("ok");
                                
                            }
                            else
                            {
                                RunProgram = false; 
                            }

                        
                    }
                    else if (guess > MajicNumber)
                    {
                        Console.WriteLine("lower");
                    }
                    else if (guess < MajicNumber)
                        Console.WriteLine("higher");
                }while (YouWon == "no");
        }
    }
}