using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{
    public class Restaurant
    { 
        public void OrderSomeFood(Person person)
        {
            Menu menu = new Menu();  //menu broken down by methods
           
            int orderMore = (int)Menu.continueOrder.yes;  // this enum value is 1
        
            Console.WriteLine($"Welcome {person.FirstName} {person.LastName}!");

            int pizzaToppingsCount = 0;
            int burgerToppingsCount = 0;
           
            int friesCount = 0;
            int drinksCount = 0;

            //size counts
            int smallSizeCountFries = 0 ;
            int mediumSizeCountFries = 0;
            int largeSizeCountFries = 0;
            
            int smallSizeCountDrinks = 0;
            int mediumSizeCountDrinks = 0;
            int largeSizeCountDrinks = 0;


            Order order = new Order();
            Burger burger = new Burger();
            BurgerToppings burgerToppings = new BurgerToppings();


            while (orderMore == 1)
            {
                menu.showMainMenu();
                Console.WriteLine("Choose Your item");
                int choice = Convert.ToInt32(Console.ReadLine());
        
                int mainMenuChoice = menu.MainMenuChoice(choice,order);
                Console.WriteLine(mainMenuChoice);
                bool chooseAnother;

                switch (mainMenuChoice)
                {
                    case 1: //burger
                        chooseAnother = true;
                        while (chooseAnother)
                        {   
                            menu.ToppingsForBurgerMenu(burgerToppings);
                            int  burgerToppingChoice = Convert.ToInt32(Console.ReadLine());
                            burgerToppingChoice = menu.ToppingsForBurgerChoice(burgerToppingChoice,burger);
                            if(burgerToppingChoice == 0)
                            {
                                chooseAnother = false;
                            }
                            else
                            {
                                burgerToppingsCount += 1;
                            }                           
                        }

                        /*chooseAnother = true;
                        while (chooseAnother)
                        {
                            menu.ExtraItemsMenu();
                            int extraItemChoice = Convert.ToInt32(Console.ReadLine());
                            extraItemChoice = menu.ExtraItemsChoice(extraItemChoice);
                            if (extraItemChoice == 3)
                            {
                                chooseAnother = false;                 
                            }
                            if(extraItemChoice == 1)
                            {
                                friesCount += 1;
                                menu.SizeOfExtraItemsMenu();
                                int sizeExtraItemChoice = Convert.ToInt32(Console.ReadLine());
                                int sizeExtraItemChoiceFries = menu.SizeofExtraItemChoice(sizeExtraItemChoice);
                                if (sizeExtraItemChoiceFries == 1)
                                {
                                    smallSizeCountFries += 1;
                                }
                                if (sizeExtraItemChoiceFries == 2)
                                {
                                    mediumSizeCountFries += 1;
                                }
                                if (sizeExtraItemChoiceFries == 3)
                                {
                                    largeSizeCountFries += 1;
                                }
                            }
                            if(extraItemChoice == 2)
                            {
                                drinksCount += 1;
                                menu.SizeOfExtraItemsMenu();
                                int sizeExtraItemChoice = Convert.ToInt32(Console.ReadLine());
                                int sizeExtraItemChoiceDrinks = menu.SizeofExtraItemChoice(sizeExtraItemChoice);
                                if (sizeExtraItemChoiceDrinks == 1)
                                {
                                    smallSizeCountDrinks += 1;
                                }
                                if (sizeExtraItemChoiceDrinks == 2)
                                {
                                    mediumSizeCountDrinks += 1;
                                }
                                if (sizeExtraItemChoiceDrinks == 3)
                                {
                                    largeSizeCountDrinks += 1;
                                }
                            }
                        }  */                    
                        break;
                    case 2: //pizza  
                       /* chooseAnother = true;
                        while (chooseAnother)
                        {
                            menu.ToppingsForPizzaMenu();
                            int pizzaToppingChoice = Convert.ToInt32(Console.ReadLine());
                            pizzaToppingChoice = menu.ToppingsForBurgerChoice(pizzaToppingChoice);
                            if (pizzaToppingChoice == 7)
                            {
                                chooseAnother = false;
                            }
                            else
                            {
                                pizzaToppingsCount += 1;
                            }
                        }*/
                        break;
                    default:
                        break;
                }
                int totalTopping = burgerToppingsCount + pizzaToppingsCount;
                Console.WriteLine("BurgerToppings: "+burgerToppingsCount);
                /*Console.WriteLine("friesCount: " + friesCount);
                Console.WriteLine("drinksCount: " + drinksCount);
                
                Console.WriteLine("mediumSizeCountFries: " + mediumSizeCountFries);
                Console.WriteLine("smallSizeCountFries: " + smallSizeCountFries);
                Console.WriteLine("largeSizeCountFries: " + largeSizeCountFries);

                Console.WriteLine("smallSizeCountDrinks: " + smallSizeCountDrinks);
                Console.WriteLine("mediumSizeCountDrinks: " + mediumSizeCountDrinks);
                Console.WriteLine("largeSizeCountDrinks: " + largeSizeCountDrinks);*/                

                if (choice == 0)
                {
                   orderMore = (int)Menu.continueOrder.no;
                }
               
            }

        }
        public void WalkOutOfRestaurant()
        {
            Console.WriteLine("See Ya!");
        }

        public void CheckOut(double personMoney, double total, Order order)
        {
            if (personMoney <= total)
            {
                order.ShowOrder();
            }
            else if (personMoney < total)
            {
                Console.WriteLine("Not enough money for your food, Would you like to edit your order? yes / no");
                string input = Console.ReadLine();
                if (input == "yes" || input == "YES" || input == "Yes" || input == "Y" || input == "Y")
                {
                   // Order.DeleteFromOrder();
                }
                else
                {
                    WalkOutOfRestaurant();
                }
            }
        }

    }
}
