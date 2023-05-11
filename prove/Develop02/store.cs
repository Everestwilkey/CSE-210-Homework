using System.Collections.Generic;
using System;
using System.IO;
namespace Develop02
{
    public class Datastorage
    {
        public string filename;
        public static string Getfilename()
        {
            Console.WriteLine("Please Enter file name: ");
            string filename = Console.ReadLine();
                return filename;
        }
        public static void SaveFile(string filename, string entry)
        {
            File.WriteAllText(filename,entry);
            Console.WriteLine("SAVED");
        }
    }

}