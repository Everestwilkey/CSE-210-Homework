using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class Snake : River
    {
        public Snake()
        {
            riverinfo["January"] = "Midge";
            riverinfo["Febuary"] = "Midge";
            riverinfo["March"] = "Midge, BWO";
            riverinfo["April"] = "Midge, BWO";
            riverinfo["May"] =  "Midge, BWO";
            riverinfo["June"] = "Salmon Fly, Golden Stone, Caddis, PMD, March Brown, Green Drake, Midge";
            riverinfo["July"] = "Salmon Fly, Golden Stone, Yellow Sally, Pink Albert, Caddis, PMD, Midge, Ants, Beetles, Hoppers";
            riverinfo["Augest"] = "Yellow Sally, Caddis, PMD, Callibaetis, Midge, Trico, Ants, Beetles, Hoppers";
            riverinfo["September"] = "Mahogany Dun, Midge, Ants, Beetles, Hoppers,";
            riverinfo["October"] = "BWO, Midge";
            riverinfo["November"] = "BWO, Midge";
            riverinfo["Decmber"] = "Midge";
            bool walk = false;
            bool Float = true;
        }
        
    }
}