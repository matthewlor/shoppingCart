using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartProblem;

namespace ShoppingCartProblem
{
    [TestClass]
    public class UnitTest
    {
        ShoppingCart[] carts = new ShoppingCart[3];
        ShoppingCart cart1 = new ShoppingCart();
        ShoppingCart cart2 = new ShoppingCart();
        ShoppingCart cart3 = new ShoppingCart();
            
        Item c1 = new Item("Book", 2m, 12.50m, 1m);
        Medical c2 = new Medical("Ibuprofen", 1m, 9.99m, 1m);
        Food c3 = new Food("Banana", 12m, 3.25m, 6m);

        Item c4 = new Item("Shelving Units", 4m, 32.50m, 1m);
        Food c5 = new Food("Milk", 3m, 3.99m, 1m, 2);
        Food c6 = new Food("Donuts", 12m, 8.25m, 12m);

        Item c7 = new Item("Wireless Router", 1m, 129.99m, 1m);
        Item c8 = new Item("Ethernet Cable", 2m, 13.00m, 1m);
        Item c9 = new Item("Labtop", 2m, 1200.00m, 1m);


        public UnitTest()
        {
            cart1.add(c1);
            cart1.add(c2);
            cart1.add(c3);
            cart2.add(c4);
            cart2.add(c5);
            cart2.add(c6);
            cart3.add(c7);
            cart3.add(c8);
            cart3.add(c9);
            carts[0] = cart1;
            carts[1] = cart2;
            carts[2] = cart3;
        }
            
        [TestMethod]
        public void TestSubTotals()
        {
            Assert.AreEqual(cart1.subTotal, 41.49m);
            Assert.AreEqual(cart2.subTotal, 146.23m);
            Assert.AreEqual(cart3.subTotal, 2555.99m);
        }

        [TestMethod]
        public void TestTotalTaxes()
        {
            Assert.AreEqual(Decimal.Round(cart1.tax, 2), 1.62m);
            Assert.AreEqual(Decimal.Round(cart2.tax, 2), 7.15m);
            Assert.AreEqual(Decimal.Round(cart3.tax, 2), 140.58m);
        }

        [TestMethod]
        public void TestDiscount()
        {
            Assert.AreEqual(Decimal.Round(cart1.discount, 2), 0.00m);
            Assert.AreEqual(Decimal.Round(cart2.discount, 2), 0.00m);
            Assert.AreEqual(Decimal.Round(cart3.discount, 2), 20.00m);
        }

        [TestMethod]
        public void TestTotal()
        {
            Assert.AreEqual(Decimal.Round(cart1.Total, 2), 43.11m);
            Assert.AreEqual(Decimal.Round(cart2.Total, 2), 153.38m);
            Assert.AreEqual(Decimal.Round(cart3.Total, 2), 2676.57m);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestCartArrayOutOfRangeOver()
        {
            cart1[1000] = new Item("Labtop", 2m, 1200.00m, 1m);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestCartArrayOutOfRangeUnder()
        {
            cart1[-1000] = new Item("Labtop", 2m, 1200.00m, 1m);
        }
    }
}
