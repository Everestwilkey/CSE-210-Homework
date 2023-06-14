using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class BodyOfWater
    {
        public void canWalk(bool walk)
        {
            if (walk == true)
            {
                Console.Write("You can walk this");
            }
            else
            {
                Console.WriteLine("You Can't walk this");
            }
        }
        public void canfloat(bool boat)
        {
            if (boat == true)
            {
                Console.Write("You can float this");
            }
            else
            {
                Console.Write("You can't float this");
            }
        }
    }
}