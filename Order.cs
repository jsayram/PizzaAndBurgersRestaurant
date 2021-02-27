using System;
using System.Collections.Generic;
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

        //Pizzas
        public void ShowPizzaOrder()
        {
            for (int i = 0; i < MyPizzas.Count; i++)
            {
                Console.WriteLine($"My Pizza Order:");
                foreach (PizzaTopping p in MyPizzas[i].pizzaToppingsList)
                {
                    Console.WriteLine($"\t{p.ToppingName}");
                }
            }
      
        }
        public Order BuildPizzaOrder(Order order, int choice, Pizza pizza)
        {
            Console.WriteLine("Choose your Pizza Toppings");
            MenuItems.CreateMenu(MenuItems.PizzaToppingsMenuItems.pizzaToppingsMenuItemsList);
            Console.WriteLine("[0] Exit Pizza Toppings");
            pizza = MenuItems.PizzaToppingsMenuItems.ChoosePizzaToppings(choice, pizza);
            order.AddToPizzaOrder(pizza);
            return order;
        }

        //Burgers
        public void ShowBurgerOrder()
        {
            for (int i = 0; i < MyBurgers.Count; i++)
            {
                Console.WriteLine($"My Burger Order:");
                foreach (BurgerTopping p in MyBurgers[i].burgerToppingsList)
                {
                    Console.WriteLine($"\t{p.ToppingName}");
                }
            }

        }
        public Order BuildBurgerOrder(Order order, int choice, Burger burger)
        {
            Console.WriteLine("Choose your Burger Toppings");
            MenuItems.CreateMenu(MenuItems.BurgerToppingsMenuItems.burgerToppingsMenuItemsList);
            Console.WriteLine("[0] Exit Burger Toppings");
            burger = MenuItems.BurgerToppingsMenuItems.ChooseBurgerToppings(choice, burger);
            order.AddToBurgerOrder(burger);
            return order;
        }

        //Extras
        public void ShowExtraOrder()
        {
            for (int i = 0; i < MyExtras.Count; i++)
            {
                Console.WriteLine($"My Extra Order:");
                foreach (var p in MyExtras[i].extraItemsList)
                {
                    Console.WriteLine($"\t{p.extraItemName},{p.extraItemSize},{p.extraItemSizePrice:C}");
                }
            }
        }

        public Order BuildExtraOrder(int choiceItem, int choiceSize,Order order,Extra extra)
        {
            while (choiceItem != 0)
            {
                Console.WriteLine("Choose your Extra Item");
                MenuItems.CreateMenu(MenuItems.ExtraMenuItems.extraMenuItemsList);
                Console.WriteLine("[0] Exit Extra Items Menu");
                choiceItem = Convert.ToInt32(Console.ReadLine());
                if (choiceItem > 0 && choiceItem <= MenuItems.ExtraMenuItems.extraMenuItemsList.Count)
                {
                    Console.WriteLine($"Choice of Extra: {MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].itemName}\n");
                    Console.WriteLine("Choose your Extra Item Size:");
                    MenuItems.CreateMenu(MenuItems.ItemSizes.itemSizesList);

                    choiceSize = Convert.ToInt32(Console.ReadLine());
                    while (choiceSize > MenuItems.ItemSizes.itemSizesList.Count)
                    {
                        Console.WriteLine("Note A valid Size, choose again");
                        choiceSize = Convert.ToInt32(Console.ReadLine());
                    }

                    if (choiceSize > 0 && choiceSize <= MenuItems.ItemSizes.itemSizesList.Count)
                    {
                        Console.WriteLine($"Chosen Size: {MenuItems.ItemSizes.itemSizesList[choiceSize - 1].itemName}");
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
                foreach (var p in MyExtras[i].extraItemsList)
                {
                    itemsTotal += p.extraItemSizePrice;
                    
                }
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

            Console.WriteLine($"Order Total: {itemsTotal:C}");
        }


    }
}
