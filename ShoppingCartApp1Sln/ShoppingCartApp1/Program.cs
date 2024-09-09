using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            var item = new ShoppingCartItem("XBOX360", 3950);
            cart.ShoppingList(item);

            item = new ShoppingCartItem("PS4", 4000);
            cart.ShoppingList(item);

            List<ShoppingCartItem> product = cart.ShoppingCartItems();
            foreach(ShoppingCartItem productItem in product)
            {
                Console.Write(productItem.ProductName + "\t\t");
                Console.WriteLine(productItem.ItemPrice);
            }
            Console.WriteLine("Subtotal:\t" +cart.GetSubTotal());
            Console.WriteLine("With vat: \t" +cart.GetVat());
            Console.WriteLine("Number of items in shopping Cart:" +cart.GetAmountOfItems());

            


            ShoppingCart app = new ShoppingCart();
           
        }
    }
}
