using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Burger
    {
        
        public List<BurgerTopping> burgerToppingsList = new List<BurgerTopping>();

        public Burger()
        {

        }

        public List<BurgerTopping> AddBurgerTopping(string pt, decimal price)
        {
            BurgerTopping burgerTopping = new BurgerTopping();

            //assign the burger topping variables
            burgerTopping.ToppingName = pt;
            burgerTopping.ToppingPrice = price;
            //return burger topping
            burgerToppingsList.Add(burgerTopping);

            return burgerToppingsList;
        }
        public void ClearBurgerToppings()
        {
            burgerToppingsList.Clear();
        }

        public void ShowBurger()
        {

            Console.Clear();
            foreach (BurgerTopping p in burgerToppingsList)
            {
                Console.WriteLine($"BurgerTopping: {p.ToppingName}, BurgerToppingPrice : {p.ToppingPrice}");
            }

        }


        
    }
}
