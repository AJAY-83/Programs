
namespace StockMarket
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  Stock Managment have the details about the Json File 
    /// </summary>
    class StockDataManagment
    {
        /// <summary>
        /// Gets or sets the capgemini.
        /// here we are just takes 
        /// </summary>
        /// <value>
        /// The capgemini.
        /// </value>
        public List<CapgeminiRecord> Capgemini { get; set; }
        // public List<CapgeminiRecord> Capgemini { get; set; }

        /// <summary>
        /// Gets or sets the tata.
        /// </summary>
        /// <value>
        /// The tata.
        /// </value>
        public List<TATARecord> TATA { get; set; }

        /// <summary>
        ///  we create a class capgemini to get the value from json file
        ///  here we are takes just two values 
        ///  Avialable_Shares And Share_Price that only important now
        /// </summary>
        public class CapgeminiRecord
        {
            public int Available_Shares { get; set; }
            public int Share_Price { get; set;}
            public int Number_Of_Shares_Holder { get; set; }
        }

        /// <summary>
        /// TATARecord class have to get the values from the json file
        /// here we are takes just two values 
        /// Avialable_Shares And Share_Price that only important now
        /// </summary>
        public class TATARecord
        {
            public int Available_Shares { get; set; }
            public int Share_Price { get; set; }
        }
    }
}
