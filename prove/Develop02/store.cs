using System.Collections.Generic;
using System;
using System.IO;
namespace Develop02
{
    public class Datastorage
    {
        public string _filename;
        public string GetFilename()
        {
            Console.WriteLine("Please Enter file name: ");
            string _filename = Console.ReadLine();
            return _filename;
        }
        public void SaveFile(List<Entry> entries, string filename)
        {
            using (StreamWriter writer = File.AppendText(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ConvertToString());
                }
            }
        }

    }

}
