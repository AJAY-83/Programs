using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Pattern.Facade_Pattern
{
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
