using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaAndBurgers
{
    public class Menu 
    {
        /*private const string burger = "Burger";
        private const string pizza = "Pizza";*/

        public Dictionary<int, string> MenuItems()
        {
            Dictionary<int, string> MenuItems = new Dictionary<int, string>
            {
                { 1, "Burger" },
                { 2, "Pizza" },
                { 3, "Extras" },
                { 4, "Checkout" }
            };

            return MenuItems;
        }
        /* public enum MenuItems 
         {
             Burger,
             Pizza,
             Extras,
             Checkout,
             Exit

         public enum ToppingItemsForBurger
         {
             Mushrooms,
             Onions,
             Tomatoes,
             Cheese,
             Lettus,
             Pickles,
             Exit
         }
         public enum ToppingItemsForPizza
         {
             Mushroom,
             Onions,
             Tomatoes,
             Pepperoni,
             Olives,
             Sausage,
             Exit
         }
         public enum ExtraItems
         {
             Fries,
             Drink,
             Exit
         }

         public enum SizeofExtraItems
         {
             S,
             M,
             L,
             Exit
         }
         }*/
        public enum continueOrder
        {
            no,
            yes,
            Exit
        }

        public enum Exit { yes };
        

        public void showMainMenu()
        {
            Console.WriteLine($"Main Menu:");

            foreach(var m in MenuItems())
            {
                Console.WriteLine($"[{m.Key}] {m.Value}");
            }

            Console.WriteLine($"\n[0] Exit Restaurant");
        }

        public void ToppingsForBurgerMenu(BurgerToppings burgerToppings)
        {
            /*
             * Console.WriteLine($"Burger Toppings Menu:" +
                              $"\n[1] {Toppings.ToppingOne}" +
                              $"\n[2] {Toppings.ToppingTwo}" +
                              $"\n[3] {Toppings.ToppingThree}" +
                              $"\n[4] {BurgerToppings.BurgerToppingOne}" +
                              $"\n[5] {BurgerToppings.BurgerToppingTwo}" +
                              $"\n[6] {BurgerToppings.BurgerToppingThree}" +
                              $"\n[7] Done Picking Burger Toppings");
            */
            Console.WriteLine($"Burger Toppings Menu:");
            int countItem = 0;
            foreach (var m in burgerToppings.GeneralToppingItems())
            {
                countItem++;
                Console.WriteLine($"[{countItem}] {m.Value}");
            }
            foreach (var m in burgerToppings.BurgerToppingItems())
            {
                countItem++;
                Console.WriteLine($"[{countItem}] {m.Value}");
            }
            Console.WriteLine($"\n[0] Done Picking Buger Toppings");
        }

       /* public void ToppingsForPizzaMenu()
        {
            Console.WriteLine($"Pizza Toppings Menu:" +
                              $"\n[1] {Toppings.ToppingOne}" +
                              $"\n[2] {Toppings.ToppingTwo}" +
                              $"\n[3] {Toppings.ToppingThree}" +
                              $"\n[4] {PizzaToppings.PizzaToppingOne}" +
                              $"\n[5] {PizzaToppings.PizzaToppingTwo}" +
                              $"\n[6] {PizzaToppings.PizzaToppingThree}" +
                              $"\n[7] Done Picking Pizza Toppings");
        }
        public void ExtraItemsMenu()
        {
            Console.WriteLine($"Extra Items Menu:" +
                              $"\n[1] {Extra.ExtraItemOne}" +
                              $"\n[2] {Extra.ExtraItemTwo}" +
                              $"\n[3] Done Picking Extra Items");
        }
        public void SizeOfExtraItemsMenu()
        {
            Console.WriteLine($"Size Of Extra Item:" +
                              $"\n[1] Small" +
                              $"\n[2] Medium" +
                              $"\n[3] Large");        
       }*/
        public int MainMenuChoice(int choice,Order order)
        {    
            Dictionary<int, string> MainMenuItems = MenuItems();
            switch (choice)
            {
                case 1:
                    order.AddToOrder(MainMenuItems[1]);
                    break;
                case 2:
                    order.AddToOrder(MainMenuItems[2]);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Not a Valid Choice try again");
                    break;
            }
            return choice;
        }
      public int ToppingsForBurgerChoice(int choice,Burger burger)
        {
            BurgerToppings burgerToppings = new BurgerToppings();
        
           /* Dictionary<int, Tuple<string, decimal>> burgerToppingItems = burgerToppings.BurgerToppingItems();
            Dictionary<int, Tuple<string, decimal>> generalToppingItems = burgerToppings.GeneralToppingItems();
            Dictionary<int, Tuple<string, decimal>> combinedGeneralAndBurger = new Dictionary<int, Tuple<string, decimal>>();

             burgerToppingItems.ToList().ForEach(x => combinedGeneralAndBurger.Add(x.Key, x.Value));
             generalToppingItems.ToList().ForEach(x => combinedGeneralAndBurger.Add(x.Key, x.Value));

            foreach (var g in generalToppingItems) Console.WriteLine("BURGER TOPPINGS: " +g);
            
            
            burger.AddBurgerToppings(generalToppingItems[choice].Item1);
            
            switch (choice)
            {
                case 1:
                    burger.AddBurgerToppings(burgerToppingItems[choice].Item1);
                    break;
                case 2:
                    burger.AddBurgerToppings(Toppings.ToppingTwo);
                    break;
                case 3:
                    burger.AddBurgerToppings(Toppings.ToppingThree);
                    break;
                case 4:
                    burger.AddBurgerToppings(BurgerToppings.BurgerToppingOne);
                    break;
                case 5:
                    burger.AddBurgerToppings(BurgerToppings.BurgerToppingTwo);
                    break;
                case 6:
                    burger.AddBurgerToppings(BurgerToppings.BurgerToppingThree);
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Not a Valid Choice try again");
                    break;
            }*/
            return choice;
        }
      /*  public int ToppingsForPizzaChoice(int choice)
        {
            Pizza pizza = new Pizza();
            switch (choice)
            {
                case 1:
                    pizza.AddPizzaToppings(Toppings.ToppingOne);
                    break;
                case 2:
                    pizza.AddPizzaToppings(Toppings.ToppingTwo);
                    break;
                case 3:
                    pizza.AddPizzaToppings(Toppings.ToppingThree);
                    break;
                case 4:
                    pizza.AddPizzaToppings(PizzaToppings.PizzaToppingOne);
                    break;
                case 5:
                    pizza.AddPizzaToppings(PizzaToppings.PizzaToppingTwo);
                    break;
                case 6:
                    pizza.AddPizzaToppings(PizzaToppings.PizzaToppingThree);
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Not a Valid Choice try again");
                    break;
            }
            return choice;
        }
        public int ExtraItemsChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Not a Valid Choice try again");
                    break;
            }
            return choice;
        }
        public int SizeofExtraItemChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Not a Valid Choice try again");
                    break;
            }
            return choice;
        }*/


    }
}
