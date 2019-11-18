//--------------------------------------------------------------------------------------------------------------------
// <Copyright file="IFactory.cs" company="Bridgelabz">
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
    /// IFactory is the interface in that have the one abstract method that will
    /// use for another class.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// LaptopInformation method have the details about the lapop.
        /// </summary>
        /// <param name="brand">brand is the name of computer type or laptop type.</param>
        void LaptopInformation(string brand);
    }
}
