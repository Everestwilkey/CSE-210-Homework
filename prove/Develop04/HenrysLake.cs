namespace Develop04
{
    public class HenrysLake : Lake
    {
        bool _walk = true;
        bool _floats = true;

        public HenrysLake()
        {
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

        }
        public bool returnwalkinfo()
        {
            bool walk = _walk;
            return walk;
        }
        public bool returnfloatsinfo()
        {
            bool floats = _floats;
            return floats;
        }



    }
}