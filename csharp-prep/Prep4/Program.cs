using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished!");
        string contiune = "y";
        List<int> numbers = new List<int>();
        while (contiune == "y")
        {
            Console.Write("enter a number");
            int entery = int.Parse(Console.ReadLine());
            if (entery == 0)
            {
                contiune = "n";
            }
            else
            {
                numbers.Add(entery);
            }

        }
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"the Sum is {sum} ");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"the average is {avg}");

        float max = numbers[0];

     
    
    
    
     }
}