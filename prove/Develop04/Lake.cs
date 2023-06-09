namespace Develop04
{
    public class Lake : BodyOfWater
    {
        protected string name;
        protected string _month;

        protected bool walk;
        protected Dictionary<string, string> _lakeinfo = new Dictionary<string, string>();

        private void SelectMonth()
        {
            Console.Write("Enter a month:");
            _month = Console.ReadLine();

        }

        public string GetLakeInfo()
        {
            SelectMonth();
            return _lakeinfo[_month];


        }
        public void SetLakeInfo(Dictionary<string, string> lakeinfo )
        {
            _lakeinfo = lakeinfo;
        }
    }
}
