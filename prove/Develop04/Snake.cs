using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Snake : River
    {
        string name = "Snake River";
        List<string> fishes = new List<string>() {"Brown Trout", "Ranbow Trout"};

        Dictionary<string,string> riverInfo = new Dictionary<string, string>();
        public Snake()
        {
            riverInfo = new Dictionary<string, string>
            {
                {"June", "Blue Fly, Black Fly, Red Fly"},
                {"July", "Blue Fly"},
                {"Augest", "Blue Fly, Black Fly, Red Fly"},
                {"September", "Blue Fly"}
            }; 
        }
        public string GetRiverInfo(string month)
        {
            if (riverInfo.ContainsKey(month))
            {
                return riverInfo[month];
            }
            else
            {
                return "No river information available for this month.";
            }
        }
    }
}