// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="ConcreteComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Creational_Pattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// ConcreateComputerFactory inherited from the ServerFactory Abtract class.
    /// </summary>
    public class ConcreteComputerFactory : ServerFactory
    {
        /// <summary>
        /// IFactory as interface.
        /// </summary>
        /// <param name="company">company as parameter.</param>
        /// <returns>return exception.</returns>
        public override IFactory GetFactory(string company)
        {
            switch (company)
            {
                case "laptop":
                    return new Laptop();

                case "PC":
                    return new PC();

                default:
                    throw new ApplicationException(string.Format("laptop{0} cannot found", company));
            }
        }
    }
}
