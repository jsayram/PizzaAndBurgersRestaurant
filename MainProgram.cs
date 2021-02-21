using System;

namespace PizzaAndBurgers
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Restaurant DankFood4You = new Restaurant();
            Person customer = new Person(50.0m, "Jose", "Ramirez", "555 StreetView,Charlottesville,VA,22901");
            //customer.ShowPerson();
            DankFood4You.OrderSomeFood(customer);
        }
    }
}
