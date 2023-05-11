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
            switch (input)
            {
                case "1":
                    Entry myentry = new Entry();
                    Console.WriteLine("What is todays date?"); 
                    myentry.date = Console.ReadLine();
                    myentry.prompt = "What did you have for dinner?"; 
                    Console.WriteLine(myentry.prompt);
                    myentry.response = Console.ReadLine();
                    Journal journal = new Journal();
                    journal.AddEntry(myentry);
                    break;
            }


            //List<Entry> entries = journal.GetAllEntries();
            //foreach (Entry entry in entries)
                //{
                //    string messages = entry.ConvertToString();
                //    Console.WriteLine(messages);
                //}



        }
    }
}