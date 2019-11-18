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
    /// Company class have the one constructor
    /// </summary>
   public class Company : Stock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyClass"/> class.
        /// </summary>
        /// <param name="symbol">symbol as parameter</param>
        /// <param name="price">price as parameter</param>
        public Company(string symbol, double price) : base(symbol, price)
        {
        }
    }
}