using System;
using System.Collections.Generic;
using System.Globalization;

namespace PizzaBurgerOOP
{
    public class PizzaTopping
    {
        private string toppingName;
        private decimal toppingPrice;

        //default constructor
        public PizzaTopping()
        {
        }

        //overloaded constructor
        public PizzaTopping(string toppingName, decimal toppingPrice)
        {
            this.toppingName = toppingName;
            this.toppingPrice = toppingPrice;
        }

        public string ToppingName { get => toppingName; set => toppingName = value; }
        public decimal ToppingPrice { get => toppingPrice; set => toppingPrice = value; }
    }
}


