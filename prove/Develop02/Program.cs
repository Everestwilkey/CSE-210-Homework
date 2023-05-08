using System;
using System.Collections.Generic;
namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry myentry = new Entry();
            myentry.Hold("What is your name?", "mattew Manly", "8 May 2023");

            Journal journal = new Journal();
            journal.AddEntry(myentry);

            List<Entry> entries = journal.GetAllEntries();
            foreach (Entry entry in entries)
            {
                string messages = entry.ConvertToString();
                Console.WriteLine(messages);
            }



        }
    }
}