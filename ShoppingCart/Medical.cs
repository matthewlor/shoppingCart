using System;

namespace ShoppingCartProblem
{
    /// <summary>
    /// The Medical class. 
    /// A sub class of Item.
    /// </summary>
    class Medical : Item
    {
        #region Constructors
        /// <summary>
        /// Constructors
        /// </summary>
        /// 

        //Default constructor. The taxPercent is set to 2.5% for Medical items.
        public Medical(string name, decimal count, decimal ppu, decimal unit)
            : base(name, count, ppu, unit)
        {
            taxPercent = .025m;
        }

        //Sale constructor: buy sale count get one free!!!
        public Medical(string name, decimal count, decimal ppu, decimal unit, int sale)
            : base(name, count, ppu, unit, sale)
        {
            taxPercent = .025m;
        }
        #endregion
    }
}
