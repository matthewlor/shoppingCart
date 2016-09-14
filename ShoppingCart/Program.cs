using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart[] carts = new ShoppingCart[3];
            ShoppingCart cart1 = new ShoppingCart();
            ShoppingCart cart2 = new ShoppingCart();
            ShoppingCart cart3 = new ShoppingCart();
            
            Item c1 = new Item("Book", 2m, 12.50m, 1m);
            Medical c2 = new Medical("Ibuprofen", 1m, 9.99m, 1m);
            Food c3 = new Food("Banana", 12m, 3.25m, 6m);

            cart1.add(c1);
            cart1.add(c2);
            cart1.add(c3);

            Item c4 = new Item("Shelving Units", 4m, 32.50m, 1m);
            Food c5 = new Food("Milk", 3m, 3.99m, 1m, 2);
            Food c6 = new Food("Donuts", 12m, 8.25m, 12m);

            cart2.add(c4);
            cart2.add(c5);
            cart2.add(c6);

            Item c7 = new Item("Wireless Router", 1m, 129.99m, 1m);
            Item c8 = new Item("Ethernet Cable", 2m, 13.00m, 1m);
            Item c9 = new Item("Labtop", 2m, 1200.00m, 1m);

            cart3.add(c7);
            cart3.add(c8);
            cart3.add(c9);

            carts[0] = cart1;
            carts[1] = cart2;
            carts[2] = cart3;

            var cartCount = 1;
            foreach (var cart in carts)
            {
                Console.WriteLine(string.Format("Cart {0}", cartCount++));
                Console.WriteLine();

                var itemCount = 1;
                foreach (var item in cart)
                {
                    Console.WriteLine(string.Format("{0, 5}. Item: {1}, Quantity: {2} = ${3}", itemCount++, item.Name, item.Count, item.SubTotal));
                }
                Console.WriteLine(string.Format("{0, 7}Subtotal = ${1}", "", Decimal.Round(cart.subTotal,2)));
                Console.WriteLine(string.Format("{0, 7}Tax = ${1}", "", Decimal.Round(cart.tax,2)));
                Console.WriteLine(string.Format("{0, 7}Discount = ${1}", "", Decimal.Round(cart.discount,2)));
                Console.WriteLine(string.Format("{0, 7}Total = ${1}", "", Decimal.Round(cart.Total,2)));

                Console.WriteLine();
                
            }
            Console.Read();

        }
    }
}
