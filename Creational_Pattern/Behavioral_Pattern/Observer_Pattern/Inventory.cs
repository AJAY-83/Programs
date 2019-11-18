// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="Company.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Behavioral_Pattern.Observer_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Inventory class is inherited from the InventoryInterface
    /// </summary>
    public class Inventory : InventoryInterface
    {
        /// <summary>
        /// name as field
        /// </summary>
        private string name;

        /// <summary>
        /// StockClass as class
        /// </summary>
        private Stock stock;

        /// <summary>
        /// Initializes a new instance of the <see cref="Inventory"/> class.
        /// </summary>
        /// <param name="name">name as parameter</param>
        public Inventory(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets or sets StockClass
        /// </summary>
        public Stock Stock
        {
            get
            {
                return this.Stock;
            }

            set
            {
                this.Stock = value;
            }
        }

        /// <summary>
        /// Update as function
        /// </summary>
        /// <param name="stock">stockClass as object</param>
        public void Update(Stock stock)
        {
            try
            {
                Console.WriteLine("Placed position {0} {1}'s" + "change to {2 : C}", this.name, this.stock.Symbol, this.stock.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
