using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class River
    {
         string name;
         protected string month;
         protected string riversize;

        public string GetMonth(string _month)
        {
            month = _month;
            return month;
        }

        public string GetRiverflies(string _name)
        {
            name = _name;
            switch(name)
            {
                case "Snake":
                    Snake snakeriver = new Snake();
                    snakeriver.riversize = "large";
                    string fliesOfTheMonth = snakeriver.GetRiverInfo(GetMonth(month));
                    string inforForRiver = ($"{month},{fliesOfTheMonth}");
                    return inforForRiver;
                case "Warm":
                    Warm Warmriver = new Warm();
                    Warmriver.riversize = "medium";
                    string fliesOfTheMonthwarm = Warmriver.GetRiverInfo(GetMonth(month));
                    string inforForRiverwarm = ($"{month},{fliesOfTheMonthwarm}");
                    return inforForRiverwarm; 

            }
        
            return "Invalid river name";
        }


    }
}