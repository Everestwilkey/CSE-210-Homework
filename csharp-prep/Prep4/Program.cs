using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished!");
        string contiune = "y";
        List<int> number = new List<int>();
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
                number.Add(entery);
            }

        }
        for (int i = 0; i < number.Count; i++)
        {
            Console.WriteLine(number[i]);
        }
        int sum = 0;
        foreach (int numbers in number)
        {
            sum += numbers;
        }
        Console.WriteLine($"the Sum is {sum} ");

        float avg = ((float)sum) / number.Count;
        Console.WriteLine($"the average is {avg}");

        int max = number[0];

        foreach (int x in number);   
        {
            if (number > max)
            {
                max = number;
            }
        }     
    
    
    
    
     }
}