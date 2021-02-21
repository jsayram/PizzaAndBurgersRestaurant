using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaAndBurgers
{

    public class Order
    {
        public List<string> myOrder = new List<string>();

        public Order()
        {   
        }

        public List<string> AddToOrder(string orderItem)
        {
            myOrder.Add(orderItem);
            return myOrder;
        }
        public void DeleteFromOrder(string orderItem)
        {
            myOrder.Remove(orderItem);
        }
        public void ShowOrder()
        {
            for (int i =0; i<myOrder.Count;i++)
            {
                Console.WriteLine($"My Order item [i]: " + myOrder[i]);
            }

        }

    }
}
