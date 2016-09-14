using System;

namespace ShoppingCartProblem
{
    /// <summary>
    /// The Item class. 
    /// The base class for items.
    /// </summary>
    class Item
    {
        #region Instance Variables
        /// <summary>
        /// Instance variables.
        /// </summary>
        /// 

        protected string name;

        ///This is the price for each unit. 
        ///Example: Bananas are sold at $3.25 for 6 bananas.
        ///         A unit is 6 bananas.
        protected decimal pricePerUnit;
        protected decimal unit;

        //An literal count of the items.
        protected decimal count;

        //The tax percentage.
        protected decimal taxPercent;

        //saleCount used for marking and calculating if item is on sale.
        protected int sale;

        #endregion

        #region Constructors
        /// <summary>
        /// Constructors
        /// </summary>

        //Default item constructor. taxPercent is set to a standard 5.5%
        public Item(string name, decimal count, decimal ppu, decimal unit)
        {
            this.name = name;
            this.count = count;
            this.pricePerUnit = ppu;
            this.unit = unit;
            taxPercent = .055m;
        }

        //Sale constructor: buy sale unit count get one free!!!
        public Item(string name, decimal count, decimal ppu, decimal unit, int sale)
        {
            this.name = name;
            this.count = count;
            this.pricePerUnit = ppu;
            this.unit = unit;
            taxPercent = .055m;

            this.sale = sale;
        }
        #endregion

        #region Properties
        public string Name { get { return name; } }
        public decimal PricePerUnit { get { return pricePerUnit; } }
        public decimal Unit { get { return unit; } }
        public decimal Count { get { return count; } }
        public decimal TaxTotal { get { return taxTotal(); } }
        public decimal SubTotal { get { return subTotal(); } }
        public decimal Total { get { return total(); } }
        #endregion

        #region Methods

        /// <summary>
        /// Calulate the total tax 
        /// Returns a decimal for TaxTotal property.
        /// </summary>
        /// <returns>Returns a decimal for TaxTotal property.</returns>
        protected decimal taxTotal()
        {
            return (SubTotal * taxPercent);
        }

        /// <summary>
        /// Calulate the sub total 
        /// Assumptions: Sales are not limited to 1. 
        /// Checks if there is a sale then
        /// Returns a decimal for SubTotal property.
        /// </summary>
        /// <returns>Returns a decimal for SubTotal property.</returns>
        protected decimal subTotal()
        {
            if (count >= sale && sale != 0)
            {
                int countFree = (int) Math.Floor(count / sale);

                return (pricePerUnit * ((count / unit) - countFree));
            }
            else
            {
                return (pricePerUnit * (count / unit)); 
            }
            
        }

        protected decimal total()
        {
            return (SubTotal + TaxTotal);
        }
        #endregion
    }
}
