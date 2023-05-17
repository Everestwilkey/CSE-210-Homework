using System.Collections.Generic;
using System;
using System.IO;
namespace Develop02
{
    public class Datastorage
    {
        public string _filename;
        public void GetFilename()
        {
            Console.WriteLine("Please Enter file name: ");
            _filename = Console.ReadLine();
            
        }
        public void SaveFile(List<Entry> entries)
        {
            using (StreamWriter writer = File.AppendText(_filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ConvertToString());
                }
            }
        }
        public Journal LoadFile()
        {
            Datastorage load = new Datastorage();
            Journal journal = new Journal();
            string text = File.ReadAllText(_filename);
            string[] splitText = text.Split( '\n', StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < splitText.Length; i += 3)
                        {
                            string date = splitText[i];
                            string prompt = splitText[i + 1];
                            string response = splitText[i + 2];
                            Entry entry = new Entry();
                            entry.Hold(prompt,response,date);
                            journal.AddEntry(entry);
                        }
            return journal;
        }
    }

}
