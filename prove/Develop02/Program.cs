using System;
using System.Collections.Generic;
namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> choices = new List<string> {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
            foreach(string items in choices)
            {
                Console.WriteLine(items);
            }
            Console.Write("Choose what you would like to do");
            string input = Console.ReadLine();
            DateTime Currentdate = DateTime.Now;
            string DateText = Currentdate.ToShortDateString();
            if (input == "1")
            {
                    
                    Entry myentry = new Entry();
                    Console.WriteLine("What is todays date?"); 
                    myentry.date = DateText;
                    myentry.prompt = myentry.GetPromt(); 
                    Console.WriteLine(myentry.prompt);
                    myentry.response = Console.ReadLine();
                    Journal journal = new Journal();
                    journal.AddEntry(myentry);
                    string messages = myentry.ConvertToString();
                    Console.WriteLine($"here is the promt and your respons. {messages} would you like to save it: ");
            }
            else if (input == "2")
            {
            }

            



        }
    }
}