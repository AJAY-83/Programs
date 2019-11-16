using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Facade_Pattern
{
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
