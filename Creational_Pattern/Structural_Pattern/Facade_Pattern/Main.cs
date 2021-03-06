﻿//--------------------------------------------------------------------------------------------------------------------
// <Copyright file="Main.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Structural_Pattern.Facade_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Main
    {
        /// <summary>
        /// MinFunction as function
        /// </summary>
        public void MinFunction()
        {
            try
            {
                BookFacade bookFacade = new BookFacade();
                bookFacade.CreateBookFunction();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
