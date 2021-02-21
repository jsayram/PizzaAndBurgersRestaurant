using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{
    public class PizzaToppings : Toppings
    {
        public Dictionary<int, Tuple<string, decimal>> PizzaToppingItems()
        {
            Dictionary<int, Tuple<string, decimal>> PizzaToppingITems = new Dictionary<int, Tuple<string, decimal>>
                {
                     {1, Tuple.Create("Pepperoni", 0.1m) },
                     {2, Tuple.Create("Olives", 0.1m) },
                     {3, Tuple.Create("Sausage", 0.1m) }

                };

            return PizzaToppingITems;

        }
    }
}
