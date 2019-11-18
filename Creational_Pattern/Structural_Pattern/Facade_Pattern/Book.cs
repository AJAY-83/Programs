//--------------------------------------------------------------------------------------------------------------------
// <Copyright file="Book.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Structural_Pattern.Facade_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Book class have the details about Book name and Author name
    /// </summary>
    public class Book
    {
        /// <summary>
        /// SetOfBook as function
        /// </summary>
        public void SetOfBook()
        {
            Console.WriteLine("Enter Book-Name");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter Author-Name");
            string authorName = Console.ReadLine();
        }
    }
}
