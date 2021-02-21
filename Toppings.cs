using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{
    public class Toppings
    {

        public Dictionary<int, Tuple<string, decimal>> GeneralToppingItems()
        {
            Dictionary<int, Tuple<string, decimal>> GeneralToppingITems = new Dictionary<int, Tuple<string, decimal>>
                { 
                     {1, Tuple.Create("Mushrooms", 0.1m) },
                     {2, Tuple.Create("Onions", 0.1m) },
                     {3, Tuple.Create("Tomatoes", 0.1m) }

                };

            return GeneralToppingITems;

        }
    }
}
