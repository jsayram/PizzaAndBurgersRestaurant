using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PizzaBurgerOOP
{
    public class MenuItems
    {
        public MenuItems() { }

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
                    Console.WriteLine("[0] Exit Pizza Toppings");
                    Console.WriteLine("Pick your topping: ");
                    while (!int.TryParse(Console.ReadLine(), out topping))
                    {
                        Console.Clear();
                        Console.WriteLine("\nChoose your Pizza Toppings");
                        CreateMenu(pizzaToppingsMenuItemsList);
                        Console.WriteLine("[0] Exit Pizza Toppings");
                        Console.WriteLine("Pick your topping: ");
                    }

                    Console.WriteLine("");
                    if (topping > 0 && topping <= pizzaToppingsMenuItemsList.Count)
                    {
                        pizza.AddPizzaTopping
                        (
                            pizzaToppingsMenuItemsList[topping - 1].itemName,
                            pizzaToppingsMenuItemsList[topping - 1].price
                        );
                        Console.WriteLine($"\tTopping chosen so far:");
                        if (pizza.pizzaToppingsList.Count < 0)
                        {
                            Console.WriteLine("\t* NONE *");
                        }
                        foreach (PizzaTopping p in pizza.pizzaToppingsList)
                        {
                            Console.WriteLine($"\t\t\t{p.ToppingName}");
                        }
                        Console.WriteLine();
                        CreateMenu(pizzaToppingsMenuItemsList);
                    }
                    if (topping > pizzaToppingsMenuItemsList.Count)
                    {
                        Console.WriteLine("\nNot a valid topping choice, Please choose again\n");
                        
                        CreateMenu(pizzaToppingsMenuItemsList);
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
                    Console.WriteLine("[0] Exit Burger Toppings");
                    Console.WriteLine("Pick your topping: ");
                    while (!int.TryParse(Console.ReadLine(), out topping))
                    {
                        Console.Clear();
                        Console.WriteLine("\nChoose your Burger Toppings");
                        CreateMenu(burgerToppingsMenuItemsList);
                        Console.WriteLine("[0] Exit Burger Toppings");
                        Console.WriteLine("Pick your topping: ");
                    }

                    Console.WriteLine("");
                    if (topping > 0 && topping <= burgerToppingsMenuItemsList.Count)
                    {
                        burger.AddBurgerTopping
                        (
                            burgerToppingsMenuItemsList[topping - 1].itemName,
                            burgerToppingsMenuItemsList[topping - 1].price
                        );
                        Console.WriteLine($"\tToppings chosen so far:");
                        if (burger.burgerToppingsList.Count < 0)
                        {
                            Console.WriteLine("\t* NONE *");
                        }
                        foreach (BurgerTopping b in burger.burgerToppingsList)
                        {
                            Console.WriteLine($"\t\t\t{b.ToppingName}");
                        }
                        Console.WriteLine();
                        CreateMenu(burgerToppingsMenuItemsList);
                    }
                    if (topping > burgerToppingsMenuItemsList.Count)
                    {
                        Console.WriteLine("\nNot a valid topping choice, Please choose again\n");
                        Console.WriteLine();
                        CreateMenu(burgerToppingsMenuItemsList);
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
              (3, "Large",3.50m),
              (4, "x-large",1m)
            };

        }
        public static void ChooseExtraItemsMenu()
        {
            Console.WriteLine("\nChoose your Extra Item");
            MenuItems.CreateMenu(MenuItems.ExtraMenuItems.extraMenuItemsList);
            Console.WriteLine("[0] Exit Extra Items Menu");
        }
        public static void CreateMenu(List<(int index, string itemName, decimal price)> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].itemName.ToLower() == "extra" || myList[i].itemName.ToLower() == "checkout" || myList[i].itemName.ToLower() == "fries" || myList[i].itemName.ToLower() == "drink")
                {
                    Console.WriteLine($"[{myList[i].index}] {myList[i].itemName}");
                }
                else
                {
                    Console.WriteLine($"[{myList[i].index}] {myList[i].itemName} - {myList[i].price:C}");
                }

            }
        }
              
    }
}
