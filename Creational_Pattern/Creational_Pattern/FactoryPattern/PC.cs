// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="PC.cs" company="Bridgelabz">
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
    /// PC class have the PC details.
    /// </summary>
    public class PC : IFactory
    {
        /// <summary>
        /// LaptopInformation is inherited from IFactory interface.
        /// </summary>
        /// <param name="brand">LaptopName.</param>
        public void LaptopInformation(string brand)
        {
            try
            {
                Console.WriteLine("The name of the laptop " + brand);
            }
             catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}