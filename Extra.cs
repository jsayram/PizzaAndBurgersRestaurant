using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Extra
    {
        public Extra()
        { 
        }    
        public static List<(string extraItemName, decimal extraItemPrice, string extraItemSize, decimal extraItemSizePrice)> extraItemsList = new List<(string extraItemName, decimal extraItemPrice, string extraItemSize, decimal extraItemSizePrice)>();

        public List<(string extraItemName, decimal extraItemPrice, string extraItemSize, decimal extraItemSizePrice)> AddExtraItemToList(string extraItemName, decimal extraItemPrice, string extraItemSize, decimal extraItemSizePrice)
        {
            extraItemsList.Add((extraItemName, extraItemPrice, extraItemSize, extraItemSizePrice));
            return extraItemsList;
        }

    }
    
}
