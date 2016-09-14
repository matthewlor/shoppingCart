using System;

namespace ShoppingCartProblem
{
    /// <summary>
    /// The Food class. 
    /// A sub class of Item.
    /// </summary>
    class Food : Item
    {
        #region Constructors
        /// <summary>
        /// Constructors
        /// </summary>
        /// 

        //Default constructor. The taxPercent is set to 0 for Food items.
        public Food(string name, decimal count, decimal ppu, decimal unit)
            : base(name, count, ppu, unit)
        {
            taxPercent = 0;
        }

        //Sale constructor: buy sale count get one free!!!
        public Food(string name, decimal count, decimal ppu, decimal unit, int sale)
            : base(name, count, ppu, unit, sale)
        {
            taxPercent = 0;
        }
        #endregion
    }
}
