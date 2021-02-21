using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{

    public class Pizza
    {
        // attributes
        private bool cheese;
        private bool sauce;
        private string[] crust = new String[]{"thin","thick"};
        
        private List<string> toppingsForPizza = new List<string>();

        //Constructors
        public Pizza(){ }
        
        public Pizza(bool cheese, bool sauce, string[] crust)
        {
            this.cheese = cheese;
            this.sauce = sauce;
            this.crust = crust;
        }

        //Getter - Setters
        public bool Cheese { get => cheese; set => cheese = value; }
        public bool Sauce { get => sauce; set => sauce = value; }
        public string[] Crust { get => crust; set => crust = value; }

        public List<string> AddPizzaToppings(string topping)
        {
            toppingsForPizza.Add(topping);

            return toppingsForPizza;
        }
    }
}
