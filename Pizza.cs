using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Pizza
    {
        public List<PizzaTopping> pizzaToppingsList = new List<PizzaTopping>();

        public Pizza()
        {

        }

        public List<PizzaTopping> AddPizzaTopping(string pt, decimal price)
        {
            PizzaTopping pizzaTopping = new PizzaTopping();

            //assign the pizza topping variables
            pizzaTopping.ToppingName = pt;
            pizzaTopping.ToppingPrice = price;
            //return pizza topping
            pizzaToppingsList.Add(pizzaTopping);

            return pizzaToppingsList;
        }
        public void ClearPizzaToppings()
        {
            pizzaToppingsList.Clear();
        }

        public void ShowPizza()
        {

            Console.Clear();
            foreach (PizzaTopping p in pizzaToppingsList)
            {
                Console.WriteLine($"PIzzaTopping: {p.ToppingName}, PizzaToppingPrice : {p.ToppingPrice}");
            }

        }


    }
}
