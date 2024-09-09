using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem
    {
        public string _itemName;
        public double _itemPrice;
        public static int ItemCount;

        public ShoppingCartItem(string name,  double price)
        {
            _itemName = name;
            _itemPrice = price;
            ItemCount++;

        }
        public string ProductName 
        {
          get { return _itemName; }
        }
        public double ItemPrice
        {
            get { return _itemPrice; }  
        }
        public int NumberofItems
        {
            get { return ItemCount; }
        }

    }  
   
}
