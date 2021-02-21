using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{
    public class Burger
    {
        // attributes
        private bool cheese;
        private bool lettus;
        private bool pickles;

        private List<string> toppingsForBurger = new List<string>();

        //Constructors
        public Burger() { }
        public Burger(bool cheese, bool lettus, bool pickles)
        {
            this.cheese = cheese;
            this.lettus = lettus;
            this.pickles = pickles;
        }

        public bool Cheese { get => cheese; set => cheese = value; }
        public bool Lettus { get => lettus; set => lettus = value; }
        public bool Pickles { get => pickles; set => pickles = value; }

        public List<string> AddBurgerToppings(string topping)
        {
            toppingsForBurger.Add(topping);

            return toppingsForBurger;
        }

    }
}
