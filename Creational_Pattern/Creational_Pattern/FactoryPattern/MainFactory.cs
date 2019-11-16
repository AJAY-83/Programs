// --------------------------------------------------------------------------------------------------------------------
// <Copyright file="MainFactory.cs" company="Bridgelabz">
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
    /// MainFactoryClass as class.
    /// </summary>
    public class MainFactory
    {
        /// <summary>
        /// Factory as function.
        /// </summary>
        public static void Factory()
        {
            try
            {
                // create Instance of ServerFactoryClass class.
                ServerFactory serverFactory = new ConcreteComputerFactory();
                IFactory laptop = serverFactory.GetFactory("laptop");
                laptop.LaptopInformation("HP_Laptop");

                IFactory pc = serverFactory.GetFactory("PC");
                //// call LaptopInformation function of the IFactory interface.
                pc.LaptopInformation("HCL_PC");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}