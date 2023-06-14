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
            bool end = false;
            while (end != true)
            {
                BodyOfWater bodyofwater = new BodyOfWater();
                Console.Write("Lake[2] or River[1]: ");
                string choice = Console.ReadLine();
                if (choice == "2")
                {
                    Console.Write("Enter the name of the Lake: ");
                    string lakechoice = Console.ReadLine();

                    switch (lakechoice.ToLower())
                    {
                        case "henrys":
                            HenrysLake henrysLake = new HenrysLake();
                            string flies = henrysLake.GetLakeInfo();
                            Console.WriteLine(flies);
                            bodyofwater.canWalk(henrysLake.returnwalkinfo());
                            bodyofwater.canfloat(henrysLake.returnfloatsinfo());


                            break;
                        case "Rirey":
                            break;
                    }

                }
                else if (choice == "1")
                {
                    Console.Write("Enter the name of the River: ");
                    string riverchoice = Console.ReadLine();

                    switch (riverchoice.ToLower())
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
        public void Stopping()
        {
            Console.WriteLine("Would you like to end? [1]Yes [2]No ");
            string _end = Console.Read();
            if (_end == )
            {
                end == true;
                return end;
            }
        }
    }
}