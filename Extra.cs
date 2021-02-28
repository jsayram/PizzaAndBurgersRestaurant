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

        public static Order AddExtrasToExtrasListandExtrasOrder(Extra extra, Order order,int choiceItem, int choiceSize)
        {
            extra.AddExtraItemToList
            (
                MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].itemName,
                MenuItems.ExtraMenuItems.extraMenuItemsList[choiceItem - 1].price,
                MenuItems.ItemSizes.itemSizesList[choiceSize - 1].itemName,
                MenuItems.ItemSizes.itemSizesList[choiceSize - 1].price
            );
            order.AddToExtraOrder(extra);
            return order;
        }
       
    }

}
