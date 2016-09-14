using System;
using System.Collections.Generic;

namespace ShoppingCartProblem
{
    /// <summary>
    /// The ShoppingCart class. 
    /// A basic array list implementation.
    /// </summary>
    class ShoppingCart : IEnumerable<Item>
    {
        #region Instance Variables
        /// <summary>
        /// Instance variables.
        /// </summary>
        /// 
       
        //The default size of the base array.
        private const int DEFAULT_START_SIZE = 10;

        //The base array of items.
        private Item[] items;

        //This keeps track of the number of elements added to the array.
        //Serves as an index of last item + 1.
        private int itemCount;

        //the total cost
        private decimal total;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor.
        /// </summary>
        /// 

        //Default constructor
        public ShoppingCart()
        {
            itemCount = 0;
            items = new Item[DEFAULT_START_SIZE]; 
        }
        #endregion

        #region Properties
        //Auto implemented properties in case for future refactoring. 
        public decimal subTotal { get; set; }
        public decimal tax { get; set; }

        //total property
        //get the total - discounts.
        public decimal Total 
        {
            get { return total - discount; }
            set { total = value; }
        }

        //The discount property. Returns a descount decimal number.
        /// <summary>
        /// discount property
        /// Gets a descount decimal number based on current subTotal.
        public decimal discount
        {
            get
            {
                if (subTotal >= 150 && subTotal < 1000)
                {
                    return 5.00m;
                }
                else if (subTotal >= 1000)
                {
                    return 20.00m;
                }
                else
                {
                    return 0.00m;
                }

            }
        }

        /// <summary>
        /// Indexer property
        /// Gets or sets the item at the specified index.
        /// example: var a = list[0];
        /// example: list[0] = 1;
        /// </summary>
        /// <param name="index">Index.</param>
        public Item this[int index]
        {
            get
            {
                if (index < 0 || index >= itemCount)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= itemCount)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;
            }
        }
        #endregion
        
        #region Methods
        /// <summary>
        /// Adds a new item to the shopping cart base array.
        /// Increases the itemCount.
        /// Updates totals and tax.
        /// </summary>
        public void add(Item i)
        {
            if (itemCount == items.Length)
            {
                resize();
            }
            items[itemCount++] = i;
            subTotal += i.SubTotal;
            tax += i.TaxTotal;
            total += i.Total;
        }

        /// <summary>
        /// Resizes the collection to current length * 2.
        /// </summary>
        public void resize()
        {
            int newSize = items.Length * 2;
            Array.Resize(ref items, newSize);

        }

        
        #endregion

        #region IEnumerable Methods

        //Enumerate only to the itemCount.
        public IEnumerator<Item> GetEnumerator()
        {
            for (int i = 0; i < itemCount; i++)
            {
                yield return items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
