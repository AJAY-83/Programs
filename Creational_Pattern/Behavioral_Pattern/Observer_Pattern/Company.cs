using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Observer_Pattern
{
    class Company:Stock
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
