using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Schema;

namespace PizzaBurgerOOP
{
    public class Order
    {
        public List<Burger> MyBurgers = new List<Burger>();
        public List<Pizza> MyPizzas = new List<Pizza>();
        public List<Extra> MyExtras = new List<Extra>();

        public Order()
        { 
            
        }
        public void AddToPizzaOrder(Pizza pizza)
        {
            this.MyPizzas.Add(pizza);
        }
        public void AddToBurgerOrder(Burger burger)
        {
            this.MyBurgers.Add(burger);
        }
        public void AddToExtraOrder(Extra extra)
        {
            this.MyExtras.Add(extra);
        }

        //--------------Pizzas---------------------
        public void ShowPizzaOrder()
        {
            
            if (MyPizzas.Count > 0)
            {
               // Console.WriteLine($"My Pizza Order:");
                for (int i = 0; i < MyPizzas.Count; i++)
                {
                    Console.WriteLine($"Pizzas: {i + 1}");
                    foreach (PizzaTopping p in MyPizzas[i].pizzaToppingsList)
                    {
                        Console.WriteLine($"\t{p.ToppingName}");
                    }
                }
            }

        }
        public Order BuildPizzaOrder(Order order, int choice, Pizza pizza)
        {
            Console.WriteLine("\nChoose your Pizza Toppings");
            MenuItems.CreateMenu(MenuItems.PizzaToppingsMenuItems.pizzaToppingsMenuItemsList);
           // Console.WriteLine("\n[0] Exit Pizza Toppings");
            pizza = MenuItems.PizzaToppingsMenuItems.ChoosePizzaToppings(choice, pizza);
            order.AddToPizzaOrder(pizza);
            return order;
        }

        //-----------------Burgers--------------------
        public void ShowBurgerOrder()
        {
            
            if (MyBurgers.Count > 0)
            {
                //Console.WriteLine($"My Burger Order:");
                for (int i = 0; i < MyBurgers.Count; i++)
                {
                    Console.WriteLine($"Burgers: {i+1}");
                    foreach (BurgerTopping p in MyBurgers[i].burgerToppingsList)
                    {
                        Console.WriteLine($"\t{p.ToppingName}");
                    }
                }
            }
           
        }
        public Order BuildBurgerOrder(Order order, int choice, Burger burger)
        {
            Console.WriteLine("\nChoose your Burger Toppings");
            MenuItems.CreateMenu(MenuItems.BurgerToppingsMenuItems.burgerToppingsMenuItemsList);
           // Console.WriteLine("\t[0] Exit Burger Toppings");
            burger = MenuItems.BurgerToppingsMenuItems.ChooseBurgerToppings(choice, burger);
            order.AddToBurgerOrder(burger);
            return order;
        }

        //---------------Extras---------------------
        public void ShowExtraOrder()
        {
            if (MyExtras.Count > 0)
            {
                Console.WriteLine($"Extra Items: ");
                for (int i = 0; i < MyExtras.Count; i++)
                {
                     
                    
                        //Console.WriteLine("Text");
                  Console.WriteLine($"\t{MyExtras[i].extraItemsList[0].extraItemName},{MyExtras[i].extraItemsList[0].extraItemSize},{MyExtras[i].extraItemsList[0].extraItemSizePrice:C}");
                    
                           
                }
            }
        }

        public Order BuildExtraOrder(int choiceItem, int choiceSize,Order order,Extra extra)
        {
            while (choiceItem != 0)
            {
                Console.WriteLine("\nChoose your Extra Item");
                MenuItems.CreateMenu(MenuItems.ExtraMenuItems.extraMenuItemsList);
                Console.WriteLine("[0] Exit Extra Items Menu");
                choiceItem = Convert.ToInt32(Console.ReadLine());
                if (choiceItem > 0 && choiceItem <= MenuItems.ExtraMenuItems.extraMenuItemsList.Count)
                {
                    Console.WriteLine($"Choice of Extra: {MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].itemName}\n");
                    Console.WriteLine("Item Size: ");
                    MenuItems.CreateMenu(MenuItems.ItemSizes.itemSizesList);

                    choiceSize = Convert.ToInt32(Console.ReadLine());
                    while (choiceSize > MenuItems.ItemSizes.itemSizesList.Count)
                    {
                        Console.WriteLine("\tNot a valid Size, please choose a valid option: ");
                        choiceSize = Convert.ToInt32(Console.ReadLine());
                    }

                    if (choiceSize > 0 && choiceSize <= MenuItems.ItemSizes.itemSizesList.Count)
                    {
                        Console.WriteLine($"Chosen Size: {MenuItems.ItemSizes.itemSizesList[choiceSize - 1].itemName}\n");
                        switch (choiceSize)
                        {
                            case 1:
                                //small
                                extra.AddExtraItemToList
                                (
                                    MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].itemName,
                                    MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].price,
                                    MenuItems.ItemSizes.itemSizesList[choiceSize - 1].itemName,
                                    MenuItems.ItemSizes.itemSizesList[choiceSize - 1].price
                                );
                                order.AddToExtraOrder(extra);
                                break;
                            case 2:
                                //medium
                                extra.AddExtraItemToList
                                (
                                    MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].itemName,
                                    MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].price,
                                    MenuItems.ItemSizes.itemSizesList[choiceSize - 1].itemName,
                                    MenuItems.ItemSizes.itemSizesList[choiceSize - 1].price
                                );
                                order.AddToExtraOrder(extra);

                                break;
                            case 3:
                                // large
                                extra.AddExtraItemToList
                                (
                                    MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].itemName,
                                    MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].price,
                                    MenuItems.ItemSizes.itemSizesList[choiceSize - 1].itemName,
                                    MenuItems.ItemSizes.itemSizesList[choiceSize - 1].price
                                );
                                order.AddToExtraOrder(extra);

                                break;
                            default:

                                break;
                        }
                    }

                }

                if (choiceItem > MenuItems.ExtraMenuItems.extraMenuItemsList.Count || choiceSize > MenuItems.ItemSizes.itemSizesList.Count)
                {
                    Console.WriteLine("Not a valid option, Please Choose Again");
                }

            }
            return order;
        }


        public void CheckOut(decimal personMoney)
        {
            decimal itemsTotal = 0;
            itemsTotal += MyPizzas.Count*MenuItems.MainMenuItems.mainMenuItemsList[1].price;

            itemsTotal += MyBurgers.Count*MenuItems.MainMenuItems.mainMenuItemsList[0].price;


            for (int i = 0; i < MyExtras.Count; i++)
            {

                itemsTotal += MyExtras[i].extraItemsList[0].extraItemSizePrice;

            }

            for (int i = 0; i < MyBurgers.Count; i++)
            {
                
                foreach (BurgerTopping p in MyBurgers[i].burgerToppingsList)
                {
                    itemsTotal += p.ToppingPrice;
                  
                }
            }

            for (int i = 0; i < MyPizzas.Count; i++)
            {
                
                foreach (PizzaTopping p in MyPizzas[i].pizzaToppingsList)
                {
                    itemsTotal += p.ToppingPrice; 
                }
            }
            Console.WriteLine($"\nOrder Total: {itemsTotal:C}\n");
            
        }


    }
}
