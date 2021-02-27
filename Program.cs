using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace PizzaBurgerOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Order order = new Order();
            decimal personMoney = 100m;
            bool payed = false;
            
            int input = 1;
            while (input != 0)
            {   
                Console.WriteLine("Choose Menu Option");
                MenuItems.CreateMenu(MenuItems.MainMenuItems.mainMenuItemsList);
                Console.WriteLine("[0] Exit Restaurant");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        //build burger
                        Burger burger = new Burger();
                        int choice = 1;
                        order.BuildBurgerOrder(order, choice, burger);
                        //order.ShowBurgerOrder();
                        break;
                    case 2:
                        //build pizza
                        Pizza pizza = new Pizza();
                        choice = 1;
                        order.BuildPizzaOrder(order, choice, pizza);
                       // order.ShowPizzaOrder();
                        break;
                    case 3:
                        //Extra Items
                        Extra extra = new Extra();
                        int choiceItem = 1;
                        int choiceSize = 1;
                        order.BuildExtraOrder(choiceItem, choiceSize, order,extra);
                        break;
                    case 4:
                        //Checkout
                        Console.WriteLine("\nTHANK YOU FOR COMMING!!\n");

                        order.CheckOut(personMoney);
                        order.ShowBurgerOrder();
                        order.ShowPizzaOrder();
                        order.ShowExtraOrder();
                        Console.WriteLine("\nGood BYE!\n");
                        payed = true;
                        break;
                    default:

                        break;
                }
            }

            if (!payed)
            {
                Console.WriteLine("YOU DIDNT PAY!!!!!!! COME BACK");
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }

        }
    }
}
