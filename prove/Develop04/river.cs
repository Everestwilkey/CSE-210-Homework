using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class River : BodyOfWater
    {

        protected string name;
        protected string _month;
        protected Dictionary<string, string> riverinfo = new Dictionary<string, string>();

        private void SelectMonth()
        {
            Console.Write("Enter a month:");
            _month = Console.ReadLine();

        }

        public string GetRiverInfo()
        {
            SelectMonth();
            return riverinfo[_month];


        }
    }
}

