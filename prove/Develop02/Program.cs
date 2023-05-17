using System;
using System.Collections.Generic;
namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current working directory: {Environment.CurrentDirectory}");
            Journal journal = new Journal();
            List<string> choices = new List<string> {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
            string input = "";
            while (input != "5") {
                foreach(string items in choices)
                {
                    Console.WriteLine(items);
                }
                Console.Write("Choose what you would like to do: ");
                input = Console.ReadLine();
                DateTime Currentdate = DateTime.Now;
                string DateText = Currentdate.ToShortDateString();
                
                switch(input) {
                    case "1":
                        // Create a new entry
                        Entry myentry = new Entry();
                        // Get today's date 
                        myentry.date = DateText;
                        // Get a random prompt
                        myentry.prompt = myentry.GetPromt();
                        // Display the prompt 
                        Console.WriteLine(myentry.prompt);
                        // Collect response from user
                        myentry.response = Console.ReadLine();
                        // Add entry to the list
                        journal.AddEntry(myentry);
                        string messages = myentry.ConvertToString();
                        break;
                    case "2":
                        foreach (Entry entry in journal.GetAllEntries())
                        {
                            Console.WriteLine(entry.ConvertToString());
                        }
                        break;
                    case "3":
                        Datastorage dataStore = new Datastorage();
                        journal.ClearAllEntries();
                        dataStore.GetFilename();
                        journal = dataStore.LoadFile();

                        break;
                    case "4":
                        Datastorage save = new Datastorage();
                        save.GetFilename();
                        save.SaveFile(journal.GetAllEntries());
                        break;
                    case "5":
                        input = "5";
                        break;
                    default:
                        break;
                }                
            }
        }
    }
}