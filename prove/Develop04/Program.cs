using System;

namespace Develop04
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Create new river object
            River river = new River();
            //Get the month
            river.GetMonth(Console.ReadLine());
            //Get River name and info of name
            string riverinfo = river.GetRiverflies(Console.ReadLine());
            Console.WriteLine(riverinfo);
            Console.ReadKey();
        
        }
    }
}