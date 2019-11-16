// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="Laptop.cs" company="Bridgelabz">
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
    /// Laptop is inherited from IFactor Interface.
    /// </summary>
    public class Laptop : IFactory
    {
        /// <summary>
        /// LaptopInformation method have the details about the laptop or computer brand.
        /// </summary>
        /// <param name="brand">brand is the laptop or computer type.</param>
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