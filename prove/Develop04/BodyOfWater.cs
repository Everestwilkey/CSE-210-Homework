using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class BodyOfWater
    {

        private bool _canWalk;
        private bool _canFloat;


        public void SetCanWalk(bool canWalk)
        {
            _canWalk = canWalk;
        }
         public void SetCanFloat(bool canfloat)
        {
            _canFloat = canfloat;
        }
        
        public void canWalk()
        {
            if (_canWalk == true)
            {
                Console.Write("You can walk this");
            }
            else
            {
                Console.WriteLine("You Can't walk this");
            }
        }
        public void canfloat()
        {
            if (_canFloat == true)
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