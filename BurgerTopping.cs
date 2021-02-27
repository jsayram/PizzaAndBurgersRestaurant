using System;
namespace PizzaBurgerOOP
{
    public class BurgerTopping
    {
        private string toppingName;
        private decimal toppingPrice;

        //default constructor
        public BurgerTopping()
        {
        }

        //overloaded constructor
        public BurgerTopping(string toppingName, decimal toppingPrice)
        {
            this.toppingName = toppingName;
            this.toppingPrice = toppingPrice;
        }

        public string ToppingName { get => toppingName; set => toppingName = value; }
        public decimal ToppingPrice { get => toppingPrice; set => toppingPrice = value; }
    }
}
