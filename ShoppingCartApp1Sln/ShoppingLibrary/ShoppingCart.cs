using System.Collections.Generic;
using System;

namespace ShoppingLibrary
{
    
    public class ShoppingCart
    {
        List<ShoppingCartItem> _shoppingcartitems = new List<ShoppingCartItem>();
        protected string shoppingitem;
        public decimal _subtotal = 0;
        public ShoppingCart()
        {
            


        }

        public void ShoppingList(ShoppingCartItem shoppingitem)
        {
            _shoppingcartitems.Add(shoppingitem);
        }
        public int GetAmountOfItems()
        {
            return ShoppingCartItem.ItemCount;
        }
         public double GetSubTotal()
         {
             double subtotal = 0;  
             foreach(ShoppingCartItem shoppingcartitem in _shoppingcartitems )
            {
                subtotal= subtotal + shoppingcartitem.ItemPrice;    
            }
           return subtotal; 
         }
        public double GetVat()
        {
            double vat = 0;
            vat += 1.15 * GetSubTotal(); 
            return vat; 
        }
         
        public List<ShoppingCartItem> ShoppingCartItems()
        {
            return _shoppingcartitems;
        }
          
       

        
            
    }
    

    
}
