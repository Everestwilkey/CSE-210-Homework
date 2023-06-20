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
            River snakeriver = new River();
            Dictionary<string, string> riverinfo = new Dictionary<string, string>();
            riverinfo["January"] = "Midge";
            riverinfo["Febuary"] = "Midge";
            riverinfo["March"] = "Midge, BWO";
            riverinfo["April"] = "Midge, BWO";
            riverinfo["May"] = "Midge, BWO";
            riverinfo["June"] = "Salmon Fly, Golden Stone, Caddis, PMD, March Brown, Green Drake, Midge";
            riverinfo["July"] = "Salmon Fly, Golden Stone, Yellow Sally, Pink Albert, Caddis, PMD, Midge, Ants, Beetles, Hoppers";
            riverinfo["Augest"] = "Yellow Sally, Caddis, PMD, Callibaetis, Midge, Trico, Ants, Beetles, Hoppers";
            riverinfo["September"] = "Mahogany Dun, Midge, Ants, Beetles, Hoppers,";
            riverinfo["October"] = "BWO, Midge";
            riverinfo["November"] = "BWO, Midge";
            riverinfo["Decmber"] = "Midge";
            snakeriver.SetRiverInfo(riverinfo);
            snakeriver.SetCanFloat(true);
            snakeriver.SetCanWalk(false);

            River warmriver = new River();
            Dictionary<string, string> warminfo = new Dictionary<string, string>();
            riverinfo["January"] = "Midge";
            riverinfo["Febuary"] = "Midge";
            riverinfo["March"] = "Midge, BWO";
            riverinfo["April"] = "Midge, BWO";
            riverinfo["May"] = "Midge, BWO";
            riverinfo["June"] = "Salmon Fly, Golden Stone, Caddis, PMD, March Brown, Green Drake, Midge";
            riverinfo["July"] = "Salmon Fly, Golden Stone, Yellow Sally, Pink Albert, Caddis, PMD, Midge, Ants, Beetles, Hoppers";
            riverinfo["Augest"] = "Yellow Sally, Caddis, PMD, Callibaetis, Midge, Trico, Ants, Beetles, Hoppers";
            riverinfo["September"] = "Mahogany Dun, Midge, Ants, Beetles, Hoppers,";
            riverinfo["October"] = "BWO, Midge";
            riverinfo["November"] = "BWO, Midge";
            riverinfo["Decmber"] = "Midge";
            snakeriver.SetRiverInfo(riverinfo);
            snakeriver.SetCanFloat(true);
            snakeriver.SetCanWalk(false);


            Lake henryslake = new Lake();
            Dictionary<string, string> lakeinfo = new Dictionary<string, string>();
            lakeinfo["January"] = "Midge";
            lakeinfo["Febuary"] = "Midge, BWO";
            lakeinfo["March"] = "Midge, BWO";
            lakeinfo["April"] = "Midge, BWO";
            lakeinfo["May"] = "Salmon, March brown, Midge";
            lakeinfo["June"] = "Salmon Fly, Golden Stone, Caddis, PMD, March Brown, Brown Drake, Green Drake, Midge";
            lakeinfo["July"] = "Golden Stone, Yellow Sally, Caddis, PMD, Brown Drake, Callibaetis, Flav, Midge, Ants, Beetles, Hoppers";
            lakeinfo["Augest"] = "Yellow Sally, Caddis, PMD, Callibaetis, Midge, Trico, Ants, Beetles, Hoppers";
            lakeinfo["September"] = "Mahogany Dun, Midge, Ants, Beetles, Hoppers,";
            lakeinfo["October"] = "BWO, Midge";
            lakeinfo["November"] = "BWO, Midge";
            lakeinfo["December"] = "Midge";
            henryslake.SetLakeInfo(lakeinfo);
            henryslake.SetCanFloat(true);
            henryslake.SetCanWalk(false);

            Lake lakeRirey = new Lake();
            Dictionary<string, string> rireyinfo = new Dictionary<string, string>();
            rireyinfo["January"] = "Midge";
            rireyinfo["Febuary"] = "Midge, BWO";
            rireyinfo["March"] = "Midge, BWO";
            rireyinfo["April"] = "Midge, BWO";
            rireyinfo["May"] = "Salmon, March brown, Midge";
            rireyinfo["June"] = "Salmon Fly, Golden Stone, Caddis, PMD, March Brown, Brown Drake, Green Drake, Midge";
            rireyinfo["July"] = "Golden Stone, Yellow Sally, Caddis, PMD, Brown Drake, Callibaetis, Flav, Midge, Ants, Beetles, Hoppers";
            rireyinfo["Augest"] = "Yellow Sally, Caddis, PMD, Callibaetis, Midge, Trico, Ants, Beetles, Hoppers";
            riverinfo["September"] = "Mahogany Dun, Midge, Ants, Beetles, Hoppers,";
            rireyinfo["October"] = "BWO, Midge";
            rireyinfo["November"] = "BWO, Midge";
            rireyinfo["December"] = "Midge";
            lakeRirey.SetLakeInfo(lakeinfo);
            lakeRirey.SetCanFloat(true);
            lakeRirey.SetCanWalk(false);


            bool end = false;
            while (end != true)
            {
                // BodyOfWater bodyofwater = new BodyOfWater();
                Console.Write("Lake[2] or River[1]: ");
                string choice = Console.ReadLine();
                if (choice == "2")
                {
                    Console.Write("Enter the name of the Lake: ");
                    string lakechoice = Console.ReadLine();

                    switch (lakechoice.ToLower())
                    {
                        case "henrys":
                            
                            string flies = henryslake.GetLakeInfo();
                            Console.WriteLine(flies);
                            henryslake.canWalk();
                            end = IsStopping();

                            // bodyofwater.canWalk(.returnwalkinfo());
                            // bodyofwater.canfloat(henrysLake.returnfloatsinfo());


                            break;
                        case "Rirey":
                            string flie = lakeRirey.GetLakeInfo();
                            Console.WriteLine(flie);
                            lakeRirey.canWalk();
                            end = IsStopping();
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
                            string flies = snakeriver.GetRiverInfo();
                            Console.WriteLine(flies);
                            end = IsStopping();
                            break;
                        case "warm":
                            end = IsStopping();
                            break;
                            
                    }

                }
                else
                {

                }
            }


        }
        public bool IsStopping()
        {
            Console.WriteLine("Would you like to end? [1]Yes [2]No ");
            string _input = Console.ReadLine();
            if (_input == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}