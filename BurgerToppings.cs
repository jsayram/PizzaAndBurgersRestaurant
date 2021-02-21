using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{
    public class BurgerToppings : Toppings
    {
        /*private const string burgerToppingOne = "Cheese";
        private const string burgerToppingTwo = "Lettuce";
        private const string burgerToppingThree = "Pickles";

        public static string BurgerToppingOne => burgerToppingOne;

        public static string BurgerToppingTwo => burgerToppingTwo;

        public static string BurgerToppingThree => burgerToppingThree;*/

        public Dictionary<int, Tuple<string, decimal>> BurgerToppingItems()
        {
            Dictionary<int, Tuple<string, decimal>> burgerToppingITems = new Dictionary<int, Tuple<string, decimal>>
                {
                     {1, Tuple.Create("Cheese", 0.1m) },
                     {2, Tuple.Create("Lettus", 0.1m) },
                     {3, Tuple.Create("Pickles", 0.1m) }

                };

            return burgerToppingITems;

        }


    }
}
