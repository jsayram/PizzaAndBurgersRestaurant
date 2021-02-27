using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PizzaBurgerOOP
{
    public class MenuItems
    {


        public static class MainMenuItems
        {
           public static List<(int index, string itemName, decimal price)> mainMenuItemsList = new List<(int index,string itemName, decimal price)>
            {
              (1, "Burger",5.0m),
              (2, "Pizza",2m),
              (3, "Extra",0m),
              (4, "Checkout",0m),
            };
                        
        }

        public static class PizzaToppingsMenuItems
        {
            public static List<(int index, string itemName, decimal price)> pizzaToppingsMenuItemsList = new List<(int index, string itemName, decimal price)>
            {
              (1, "Pepperoni",1m),
              (2, "Olives",1m),
              (3, "Sausage",1m)
            };

            public static Pizza ChoosePizzaToppings(int topping,Pizza pizza)
            {
                while (topping != 0)
                {
                    topping = Convert.ToInt32(Console.ReadLine());
                    if (topping > 0 && topping <= pizzaToppingsMenuItemsList.Count)
                    {
                        Console.WriteLine($"Choice: {pizzaToppingsMenuItemsList[topping - 1].itemName}");
                        pizza.AddPizzaTopping
                        (
                            pizzaToppingsMenuItemsList[topping - 1].itemName,
                            pizzaToppingsMenuItemsList[topping - 1].price
                        );
                    }
                    if (topping > pizzaToppingsMenuItemsList.Count)
                    {
                        Console.WriteLine("Not a valid topping choice, Please");
                    }
                }
                return pizza;
            }

        }
        public static class BurgerToppingsMenuItems
        {
            public static List<(int index, string itemName, decimal price)> burgerToppingsMenuItemsList = new List<(int index, string itemName, decimal price)>
            {
              (1, "Cheese",1m),
              (2, "Lettus",1m),
              (3, "Pickles",1m)
            };

            public static Burger ChooseBurgerToppings(int topping, Burger burger)
            {
                while (topping != 0)
                {
                   topping = Convert.ToInt32(Console.ReadLine());
                    if (topping > 0 && topping <= burgerToppingsMenuItemsList.Count)
                    {
                        Console.WriteLine($"Choice: {burgerToppingsMenuItemsList[topping - 1].itemName}");
                        burger.AddBurgerTopping
                        (
                            burgerToppingsMenuItemsList[topping - 1].itemName,
                            burgerToppingsMenuItemsList[topping - 1].price
                        );
                    }
                    if (topping > burgerToppingsMenuItemsList.Count)
                    {
                        Console.WriteLine("Not a valid topping choice, Please");
                    }
                }
                return burger;
            }

        }
        public static class ExtraMenuItems
        {
            public static List<(int index, string itemName, decimal price)> extraMenuItemsList = new List<(int index, string itemName, decimal price)>
            {
              (1, "Fries",0m),
              (2, "Drink",0m)
            };

        }
        public static class ItemSizes
        {
            public static List<(int index, string itemName, decimal price)> itemSizesList = new List<(int index, string itemName, decimal price)>
            {
              (1, "Small",5.0m),
              (2, "Medium",2.50m),
              (3, "Large",3.50m)
            };

        }

        public static void CreateMenu(List<(int index, string itemName, decimal price)> myList)
        {   
            for (int i = 0; i < myList.Count; i++)
            {
               Console.WriteLine($"[{myList[i].index}] {myList[i].itemName} Price: {myList[i].price:C}");
            }
        }


        public MenuItems()
        {
            
        }
    }
}
