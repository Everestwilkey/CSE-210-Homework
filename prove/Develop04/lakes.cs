namespace Develop04
{
    public class Lake
    {
        protected string name;
        protected string _month;
        protected Dictionary<string,string> lakeinfo = new Dictionary<string, string>();

        private void SelectMonth()
        {
            Console.Write("Enter a month:");
            _month = Console.ReadLine();

        }
        
        public string GetLakeInfo()
        {
            SelectMonth();
            return lakeinfo[_month];


        }

    }
}