using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{
    public class Extra
    {
        /*private const string extraItemOne = "Fries";
        private const string extraItemTwo = "Drink";

        public static string ExtraItemOne => extraItemOne;
        public static string ExtraItemTwo => extraItemTwo;*/

        public Dictionary<int, string> ExtraItems()
        {
            Dictionary<int, string> ExtraITems = new Dictionary<int, string>
            {
                { 1, "Fries" },
                { 2, "Drink" } 
            };

            return ExtraITems;
        }
        public Dictionary<string, decimal> ExtraItemSizes()
        {
            Dictionary<string, decimal> xtraItemSizes = new Dictionary<string, decimal>
            {
                {"Small", 1.50m },
                {"Medium", 3.50m },
                {"Large", 4.50m }
            };

            return xtraItemSizes;
        }
    }
}
