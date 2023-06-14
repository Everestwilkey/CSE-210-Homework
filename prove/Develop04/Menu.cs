using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Menu
    {
        public void run()
        {
            Console.Write("Lake[2] or River[1]: ");
            string choice =Console.ReadLine();
            if (choice == "2")
            {
                Console.Write("Enter the name of the Lake: ");
                string lakechoice = Console.ReadLine();

                switch(lakechoice.ToLower())
                {
                case "Henrys":
                    HenrysLake henrysLake = new HenrysLake();
                    string flies = henrysLake.GetLakeInfo();
                    Console.WriteLine(flies);
                    break;
                case "Rirey":
                    break;
                }

            }
            else if (choice == "1")
            {
                Console.Write("Enter the name of the River: ");
                string riverchoice = Console.ReadLine();

                switch(riverchoice.ToLower())
                {
                    case "snake":
                    Snake snakeriver = new Snake();
                    string flies = snakeriver.GetRiverInfo();
                    Console.WriteLine(flies);
                    break;
                    case "warm":
                    break;
                }

            }
            else
            {

            }
        

        }
    }
}