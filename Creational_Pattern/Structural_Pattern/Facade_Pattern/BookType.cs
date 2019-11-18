//--------------------------------------------------------------------------------------------------------------------
// <Copyright file="BookType.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Structural_Pattern.Facade_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BookType
    {

        /// <summary>
        /// SetOfBookDetails as function
        /// </summary>
        public void SetOfBookDetails()
        {
            try
            {
                Console.WriteLine("Which tyoe Of Book you have");
                string booktype = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
